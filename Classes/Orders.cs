using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Office.Interop.Excel;
using AuditHelper.DB;
using System.Globalization;

namespace AuditHelper.Classes
{
    public class Orders
    {
        bool _excelInWork = false;
        object _working = new object();
        ApplicationClass _exApp = null;
        Workbook _exWbk = null;
        Worksheet _exSht = null;
        CultureInfo _ci = CultureInfo.CurrentCulture;

        string[] _templates = { 
            System.IO.Path.Combine(Program.startupPath, "templates\\corrective_action_plan.xltm")
        };
        string[] _sheets = {
            "План"
        };
        private static Orders instance;
        public static Orders Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Orders();
                }
                return instance;
            }
        }
        private Orders()
        {  }

        private void StartExcel(int index)
        {
            if (index < 0 || index > this._templates.Length)
                return;
            lock (this._working)
            {
                if (this._excelInWork)
                    return;
                this._excelInWork = true;
                this._exApp = (ApplicationClass)new Microsoft.Office.Interop.Excel.Application();

                this._exWbk = _exApp.Workbooks.Open(this._templates[index], Type.Missing, true);

                this._exSht = (Worksheet)this._exWbk.Sheets[_sheets[index]];
            }
        }

        private void TerminateExcel()
        {
            if (this._exApp != null)
            {
                lock (this._working)
                {
                    if (!this._excelInWork)
                        return;
                    this._exApp.ScreenUpdating = true;
                    if (!this._exApp.Interactive)
                        this._exApp.Interactive = true;
                    this._exApp.UserControl = true;

                    if (this._exApp.Workbooks.Count == 0)
                    {
                        this._exApp.Quit();
                    }
                    else
                    {
                        if (!this._exApp.Visible) 
                            this._exApp.Visible = true;
                        this._exApp.ActiveWorkbook.Saved = true;
                    }
                    releaseObject(this._exSht);
                    releaseObject(this._exWbk);
                    releaseObject(this._exApp);

                    this._exApp = null;
                    this._excelInWork = false;
                }
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

        public bool MakeCAPEx(int aPlanId)
        {
            Plan plan = null;
            bool result = true;

            plan = ApplicationMap.Plan[aPlanId];
            if (plan == null)
                return false;

            OutsideOrg org = ApplicationMap.OutsideOrg[plan.OrgID];

            this.StartExcel(0);
            Range range, workRange;
            //Формируем шапку
            range = _exSht.UsedRange;
            range.Cells[7, 1] = "План корректирующих мероприятий по результатам проведения комплексной аудиторской проверки в " +
                                    org.FullName;

            
            range.Cells[5, 1] = String.Format("\" ___ \"  {0} {1} г.", _ci.DateTimeFormat.MonthGenitiveNames[DateTime.Now.Month - 1].ToLower(), DateTime.Now.Year);
            range.Cells[5, 6] = String.Format("\" ___ \"  {0} {1} г.", _ci.DateTimeFormat.MonthGenitiveNames[DateTime.Now.Month - 1].ToLower(), DateTime.Now.Year);
                
            List<PlanContent> content = new List<PlanContent>();

            //Заполняем содержание
            foreach (int i in plan.Content)
            {
                content.Add(ApplicationMap.PlanContent[i]);
            }

            /* Голый линк (вложенность только до второго уровня) */
            //Получаем список всех родителей
            List<PlanContent> parents = content.Where(parent => parent.ParentId == -1).ToList();
            List<PlanContent> children = null;
            parents.Sort(SimpleEntity.CompareSimpleEntities);

            int row = 9;

            //Выводим содержание
            foreach (PlanContent parent in parents)
            {
                //Заголовок раздела
                range.Cells[row, 1] = parent.Name;
                range.Cells[row, 2] = parent.Recomendation;
                
                //Жирность и шрифт
                workRange = _exSht.get_Range("a" + row.ToString(), "b" + row.ToString());
                workRange.Font.Bold = true;
                workRange.Font.Size = 10;
                //Выравнивание
                workRange = _exSht.get_Range("a" + row.ToString());
                workRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
                workRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                workRange = _exSht.get_Range("b" + row.ToString());
                workRange.VerticalAlignment = XlVAlign.xlVAlignCenter;
                workRange.HorizontalAlignment = XlHAlign.xlHAlignLeft;

                row++;
                //Обходим потомков
                children = content.Where(item => item.ParentId == parent.Id).ToList();
                children.Sort(SimpleEntity.CompareSimpleEntities);
                foreach (PlanContent child in children)
                {
                    //Раздел
                    range.Cells[row, 1] = child.Name;
                    range.Cells[row, 2] = child.Recomendation;
                    range.Cells[row, 3] = child.CorrectActions;
                    range.Cells[row, 4] = ApplicationMap.OutsideEmp[child.EmployeeId].ToString();
                    range.Cells[row, 5] = child.Expired.ToShortDateString();
                    range.Cells[row, 6] = child.Comments;
                    range.Cells[row, 7] = ApplicationMap.LevelsOfRisk[child.RiskId].Name;

                    row++;
                }

                //оформление
                if (children.Count > 0)
                {
                    //Выравнивание
                    workRange = _exSht.get_Range("a" + (row - children.Count).ToString(), "g" + (row - 1).ToString());
                    workRange.VerticalAlignment = XlVAlign.xlVAlignCenter;

                    //шрифт
                    workRange = _exSht.get_Range("a" + (row - children.Count).ToString(), "c" + (row - 1).ToString());
                    workRange.Font.Size = 9;

                    workRange = _exSht.get_Range("d" + (row - children.Count).ToString(), "f" + (row - 1).ToString());
                    workRange.Font.Size = 8;

                    //Выравнивание
                    workRange = _exSht.get_Range("a" + (row - children.Count).ToString(), "a" + (row - 1).ToString());
                    workRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    workRange = _exSht.get_Range("b" + (row - children.Count).ToString(), "c" + (row - 1).ToString());
                    workRange.HorizontalAlignment = XlHAlign.xlHAlignLeft;

                    workRange = _exSht.get_Range("d" + (row - children.Count).ToString(), "e" + (row - 1).ToString());
                    workRange.HorizontalAlignment = XlHAlign.xlHAlignCenter;

                    workRange = _exSht.get_Range("f" + (row - children.Count).ToString(), "f" + (row - 1).ToString());
                    workRange.HorizontalAlignment = XlHAlign.xlHAlignLeft;

                    //граница
                    workRange = _exSht.get_Range("a" + (row - children.Count).ToString(), "f" + (row - 1).ToString());
                    workRange.Borders.LineStyle = XlLineStyle.xlDot;
                    workRange.Borders.Weight = XlBorderWeight.xlHairline;
                    workRange.Borders.ColorIndex = 0;
                    workRange.Borders.Color = 0;
                }


            }

            //Выводим подписи
            row += 2;
            workRange = _exSht.get_Range("b" + row.ToString());
            workRange.Font.Bold = true;
            workRange.Font.Size = 12;
            range.Cells[row, 2] = "Согласовано";

            row += 2;
            OutsideEmp emp = null;
            OutsideOrg orge = null;
            emp = ApplicationMap.OutsideEmp[plan.Employee1ID];
            orge = ApplicationMap.OutsideOrg[emp.OrgID];
            workRange = _exSht.get_Range("b" + row.ToString(), "c" + row.ToString());
            workRange.Font.Size = 12;
            range.Cells[row, 2] = emp.PostName + " " + orge.FullName;
            range.Cells[row, 3] = emp.GetFIO();

            if (plan.Employee2ID != -1)
            {
                row += 2;
                emp = null;
                orge = null;
                emp = ApplicationMap.OutsideEmp[plan.Employee2ID];
                orge = ApplicationMap.OutsideOrg[emp.OrgID];
                workRange = _exSht.get_Range("b" + row.ToString(), "c" + row.ToString());
                workRange.Font.Size = 12;
                range.Cells[row, 2] = emp.PostName + " " + orge.FullName;
                range.Cells[row, 3] = emp.GetFIO();
            }

            if (plan.Employee3ID != -1)
            {
                row += 2;
                emp = null;
                orge = null;
                emp = ApplicationMap.OutsideEmp[plan.Employee3ID];
                orge = ApplicationMap.OutsideOrg[emp.OrgID];
                workRange = _exSht.get_Range("b" + row.ToString(), "c" + row.ToString());
                workRange.Font.Size = 12;
                range.Cells[row, 2] = emp.PostName + " " + orge.FullName;
                range.Cells[row, 3] = emp.GetFIO();
            }


            this.TerminateExcel();
            return result;

        }
    }
}
