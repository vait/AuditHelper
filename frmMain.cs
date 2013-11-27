using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AuditHelper.Forms;
using AuditHelper.DB;
using AuditHelper.Classes;

namespace AuditHelper
{
    public partial class frmMain : Form
    {
        private int _currentPage = 1;
        private const int _perPage = 50;
        private int _selectedPlanID = -1;
        private int _selectedPlanContentId = -1;

        private void UpdateStatusBar()
        {
            totalPlansSSL.Text = "Всего планов: " + ApplicationMap.Plan.Count.ToString();
            expiredPlansSSL.Text = "Просроченные планы: " + AuditHelper.Program.countExpired.ToString();
            notExpiredSSL.Text = "Осталось менее 4х дней: " + AuditHelper.Program.countNearestExpired.ToString();
        }

        private void LoadPlans()
        {
            List<Plan> plans = null;
            ListViewItem lvi = null;

            if (this._currentPage == -1)
            {
                plans = ApplicationMap.Plan.GetAll();
                pageSSL.Text = "Все записи";
            }
            else
            {
                int total = ApplicationMap.Plan.Count;
                int start = ((this._currentPage - 1) * _perPage);
                plans = ApplicationMap.Plan.GetAll().Skip(start).Take(_perPage).ToList();

                pageSSL.Text = "Страница: " + this._currentPage.ToString();
            }

            plansLV.BeginUpdate();
            plansLV.Items.Clear();
            contentTV.Nodes.Clear();

            foreach (Plan pl in plans)
            {
                string name = (pl.Employee1ID == -1 ? "" : ApplicationMap.OutsideEmp[pl.Employee1ID].LastName) +
                              (pl.Employee2ID == -1 ? "" : " " + ApplicationMap.OutsideEmp[pl.Employee2ID].LastName) +
                              (pl.Employee3ID == -1 ? "" : " " + ApplicationMap.OutsideEmp[pl.Employee3ID].LastName);

                lvi = new ListViewItem(new string[] { pl.Name, ApplicationMap.OutsideOrg[pl.OrgID].Name, name.Trim(), 
                    pl.NearestDate == DateTime.MaxValue ? pl.EndDate.ToShortDateString() : pl.NearestDate.ToShortDateString() });
                lvi.Tag = pl;

                //Расцветка (подкраска)
                if (pl.NearestDate != DateTime.MaxValue)
                {
                    if (pl.NearestDate <= DateTime.Now)
                        lvi.BackColor = Color.Red;

                    if (pl.NearestDate <= DateTime.Now.AddDays(4) && pl.NearestDate > DateTime.Now)
                        lvi.BackColor = Color.LightBlue;
                }

                plansLV.Items.Add(lvi);
            }

            plansLV.EndUpdate();
        }

        private void LoadContent()
        {
            if (this._selectedPlanID == -1)
            {
                return;
            }

            List<PlanContent> content = new List<PlanContent>();

            //Заполняем содержание
            foreach (int i in ApplicationMap.Plan[this._selectedPlanID].Content)
            {
                content.Add(ApplicationMap.PlanContent[i]);
            }

            /* Голый линк (вложенность только до второго уровня) */
            //Получаем список всех родителей
            List<PlanContent> parents = content.Where(parent => parent.ParentId == -1).ToList();
            List<PlanContent> children = null;
            parents.Sort(SimpleEntity.CompareSimpleEntities);

            //Вывод
            TreeNode parentNode, childNode;

            contentTV.BeginUpdate();
            this.contentTV.Nodes.Clear();

            foreach (PlanContent parent in parents)
            {
                parentNode = new TreeNode(parent.Name + " " + parent.Recomendation);
                parentNode.Tag = parent.Id;
                
                children = content.Where(item => item.ParentId == parent.Id).ToList();
                children.Sort(SimpleEntity.CompareSimpleEntities);
                //Обходим потомков
                foreach (PlanContent child in children)
                {
                    childNode = new TreeNode(child.Name + " " + 
                        (child.Recomendation.Length > 47 ?  child.Recomendation.Substring(0, 47) + "..." : child.Recomendation));
                    childNode.Tag = child.Id;
                    parentNode.Nodes.Add(childNode);
                }


                this.contentTV.Nodes.Add(parentNode);
            }

            contentTV.EndUpdate();
        }

        private void ShowEditPlanForm()
        {
            EditPlan frm = new EditPlan();
            frm.EditableId = this._selectedPlanID;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.LoadPlans();
        }

        private void ShowEditPlanContentForm(int aParent = -1)
        {
            EditPlanContent frm = new EditPlanContent();
            frm.ParentId = aParent;
            frm.EditableId = this._selectedPlanContentId;
            frm.PlanId = this._selectedPlanID;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.LoadContent();
        }

        private bool DeletePlanContentData()
        {
            if (this._selectedPlanContentId != -1)
            {
                ApplicationMap.Plan[this._selectedPlanID].DeleteContent(this._selectedPlanContentId);
                this.LoadContent();
            }
            return true;
        }

        private bool DeletePlanData()
        {
            //Удаляем пункты плана
            try
            {
                ApplicationMap.Plan[_selectedPlanID].DeleteContent(-1);
            }
            catch
            {
                return false;
            }

            //Удаляем сам план
            try
            {
                ApplicationMap.Plan.Delete(ApplicationMap.Plan[_selectedPlanID]);
            }
            catch
            {
                return false;
            }

            this.LoadPlans();
            this.UpdateStatusBar();
            return true;
        }

        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DicOutsideEmp frm = new DicOutsideEmp();
            frm.Show();
            
            //MessageBox.Show(DB.ApplicationDataMappers.LevelsOfRiskDM.GetAllIDs().Count.ToString());
            //DB.ApplicationMap.LevelsOfRisk[-1] = new Classes.LevelOfRisk("qwertyu");
            //MessageBox.Show(DB.ApplicationMap.LevelsOfRisk[16].Name);



            /*DB.ApplicationDataMappers.LevelsOfRiskDM.Insert(new Classes.LevelOfRisk(Guid.NewGuid().ToString()));
            int ID = DB.ApplicationDataMappers.LevelsOfRiskDM.Insert(new Classes.LevelOfRisk(Guid.NewGuid().ToString()));
            DB.ApplicationDataMappers.LevelsOfRiskDM.Insert(new Classes.LevelOfRisk(Guid.NewGuid().ToString()));
            DB.ApplicationDataMappers.LevelsOfRiskDM.Insert(new Classes.LevelOfRisk(Guid.NewGuid().ToString()));
            DB.ApplicationDataMappers.LevelsOfRiskDM.Insert(new Classes.LevelOfRisk(Guid.NewGuid().ToString()));

            Classes.Entity en = DB.ApplicationMap.LevelsOfRisk[ID];
            DB.ApplicationMap.LevelsOfRisk.Delete(en as Classes.LevelOfRisk);*/
            

            /*tbl_Levels_of_RiskTableAdapter _adapter = new tbl_Levels_of_RiskTableAdapter();
            MessageBox.Show(DB.ApplicationMap.LevelsOfRisk[1].Name);
            MessageBox.Show( _adapter.Update("123", 2).ToString());
            MessageBox.Show(DB.ApplicationMap.LevelsOfRisk[1].Name);*/
        }

        private void уровниРискаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DicLevelOfRisk frm = new DicLevelOfRisk();
            frm.ShowDialog();
        }

        private void организацииToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DicOutsideOrg frm = new DicOutsideOrg();
            frm.ShowDialog();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DicOutsideEmp frm = new DicOutsideEmp();
            frm.ShowDialog();
        }

        private void статусыРекомендацийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DicContentStatus frm = new DicContentStatus();
            frm.ShowDialog();
        }

        private void plansLV_Resize(object sender, EventArgs e)
        {
            columnHeader1.Width = this.plansLV.Width - 361;
            if (columnHeader1.Width < 190) columnHeader1.Width = 190;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.LoadPlans();
            this.UpdateStatusBar();
        }

        private void allTSBtn_CheckStateChanged(object sender, EventArgs e)
        {
            if ((sender as ToolStripButton).Checked)
            {
                this.prev50TSBtn.Enabled = this.next50TSBtn.Enabled = !(sender as ToolStripButton).Checked;
                this._currentPage = -1;
            }
            else
            {
                this._currentPage = 1;
                this.next50TSBtn.Enabled = !(sender as ToolStripButton).Checked;
                this.prev50TSBtn.Enabled = !this.next50TSBtn.Enabled;
                if (this._currentPage * _perPage > ApplicationMap.Plan.Count)
                    this.next50TSBtn.Enabled = false;
            }

            this.LoadPlans();
        }

        private void prev50TSBtn_Click(object sender, EventArgs e)
        {
            --this._currentPage;
            this.next50TSBtn.Enabled = true;
            if (this._currentPage == 1)
            {
                this._currentPage = 1;
                this.prev50TSBtn.Enabled = false;
            }
            this.LoadPlans();
        }

        private void next50TSBtn_Click(object sender, EventArgs e)
        {
            ++this._currentPage;
            this.prev50TSBtn.Enabled = true;
            if (this._currentPage * _perPage > ApplicationMap.Plan.Count)
            {
                this.next50TSBtn.Enabled = false;
            }
            this.LoadPlans();
        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this._selectedPlanID = -1;
            this.ShowEditPlanForm();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (this._currentPage * _perPage > ApplicationMap.Plan.Count)
                this.next50TSBtn.Enabled = false;

            this.contentTV.Nodes.Clear();
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._selectedPlanID != -1)
                this.ShowEditPlanForm();
        }

        private void plansLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._selectedPlanContentId = -1;

            if ((sender as ListView).SelectedItems.Count > 0)
                this._selectedPlanID = ((sender as ListView).SelectedItems[0].Tag as Entity).Id;
            else
                this._selectedPlanID = -1;

            this.LoadContent();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._selectedPlanID == -1)
                return;

            if (MessageBox.Show("Удалить выбранный план?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            if (this.DeletePlanData())
                MessageBox.Show("Запись успешно удалена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void contentTV_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this._selectedPlanContentId = (int)e.Node.Tag;
        }

        private void contentTV_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != System.Windows.Forms.MouseButtons.Left)
                return;

            this._selectedPlanContentId = (int)e.Node.Tag;
            if (this._selectedPlanContentId != -1)
                this.ShowEditPlanContentForm();
        }

        private void создатьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int tmp = this._selectedPlanContentId;
            this._selectedPlanContentId = -1;
            if (this._selectedPlanID != -1)
                this.ShowEditPlanContentForm(tmp);
        }

        private void редактироватьПунктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._selectedPlanContentId != -1)
                this.ShowEditPlanContentForm();
        }

        private void удалитьПунктToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._selectedPlanContentId == -1)
                return;

            if (MessageBox.Show("Удалить выбранный пункт плана?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            if (this.DeletePlanContentData())
                MessageBox.Show("Запись успешно удалена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void reloadTSBtn_Click(object sender, EventArgs e)
        {
            this.LoadPlans();
            this.UpdateStatusBar();
        }

        private void планКорректирующихМероприятийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._selectedPlanID != -1)
                Orders.Instance.MakeCAPEx(this._selectedPlanID);
        }
        
    }
}
