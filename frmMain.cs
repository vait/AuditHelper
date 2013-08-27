﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AuditHelper.DB.auditHelperDataSetTableAdapters;
using AuditHelper.Forms;
using System.Threading;

namespace AuditHelper
{
    public partial class frmMain : Form
    {
        

        public frmMain()
        {
            InitializeComponent();
        }

 


        private void button1_Click(object sender, EventArgs e)
        {
            DicLevelOfRisk frm = new DicLevelOfRisk();
            frm.Show();
            MessageBox.Show(DB.ApplicationMap.LevelsOfRisk.GetAll()[0].Name);
            
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
    }
}
