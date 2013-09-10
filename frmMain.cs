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
                        lvi.BackColor = Color.DodgerBlue;
                }

                plansLV.Items.Add(lvi);
            }

            plansLV.EndUpdate();
        }

        private void ShowEditPlanForm()
        {
            EditPlan frm = new EditPlan();
            frm.EditableId = this._selectedPlanID;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.LoadPlans();
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
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this._selectedPlanID != -1)
                this.ShowEditPlanForm();
        }

        private void plansLV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListView).SelectedItems.Count > 0)
                this._selectedPlanID = ((sender as ListView).SelectedItems[0].Tag as Entity).Id;
            else
                this._selectedPlanID = -1;
        }

    }
}
