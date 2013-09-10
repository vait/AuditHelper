using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AuditHelper.DB;
using AuditHelper.Classes;

namespace AuditHelper.Forms
{
    public partial class EditPlan : Form
    {
        private int _editableId = -1;
        public int EditableId
        {
            get { return _editableId; }
            set { _editableId = value; }
        }

        private Plan _entity = null;

        public EditPlan()
        {
            InitializeComponent();
            this.emp1IDCmB.DataSource = ApplicationMap.OutsideEmp.GetAll();
            this.emp2IDCmB.DataSource = ApplicationMap.OutsideEmp.GetAll();
            this.emp3IDCmB.DataSource = ApplicationMap.OutsideEmp.GetAll();
            this.orgIDCmB.DataSource = ApplicationMap.OutsideOrg.GetAll();
        }

        private void EditPlan_Shown(object sender, EventArgs e)
        {
            this.emp1IDCmB.SelectedItem = null;
            this.emp2IDCmB.SelectedItem = null;
            this.emp3IDCmB.SelectedItem = null;
            this.orgIDCmB.SelectedItem = null;

            if (this._editableId != -1)
            {
                this._entity = ApplicationMap.Plan[this._editableId];
                this.nameTB.Text = _entity.Name;

                this.emp1IDCmB.SelectedItem = ApplicationMap.OutsideEmp[_entity.Employee1ID];

                if (_entity.Employee2ID != -1)
                    this.emp2IDCmB.SelectedItem = ApplicationMap.OutsideEmp[_entity.Employee2ID];
                else
                    this.emp2IDCmB.SelectedIndex = -1;

                if (_entity.Employee3ID != -1)
                    this.emp3IDCmB.SelectedItem = ApplicationMap.OutsideEmp[_entity.Employee3ID];
                else
                    this.emp3IDCmB.SelectedIndex = -1;

                this.orgIDCmB.SelectedItem = ApplicationMap.OutsideOrg[_entity.OrgID];
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTB.Text.Trim()) || this.orgIDCmB.SelectedItem == null || 
                this.emp1IDCmB.SelectedItem == null)
            {
                MessageBox.Show("Не заполнено одно из полей","Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }

            if (this._editableId != -1)
            {
                _entity.Name = this.nameTB.Text.Trim();
                _entity.Employee1ID = (this.emp1IDCmB.SelectedItem as OutsideEmp).Id;

                if (this.emp2IDCmB.SelectedItem != null)
                    _entity.Employee2ID = (this.emp2IDCmB.SelectedItem as OutsideEmp).Id;
                else
                    _entity.Employee2ID = -1;

                if (this.emp3IDCmB.SelectedItem != null)
                    _entity.Employee3ID = (this.emp3IDCmB.SelectedItem as OutsideEmp).Id;
                else
                    _entity.Employee3ID = -1;
                
                _entity.OrgID = (this.orgIDCmB.SelectedItem as OutsideOrg).Id;

                ApplicationMap.Plan[this._editableId] = this._entity;
            }
            else
            {
                this._entity = new Plan(this.nameTB.Text.Trim(),
                    (this.emp1IDCmB.SelectedItem as OutsideEmp).Id,
                    this.emp2IDCmB.SelectedItem != null? (this.emp2IDCmB.SelectedItem as OutsideEmp).Id : -1,
                    this.emp3IDCmB.SelectedItem != null?  (this.emp3IDCmB.SelectedItem as OutsideEmp).Id:-1,
                    (this.orgIDCmB.SelectedItem as OutsideOrg).Id,
                    DateTime.MaxValue, DateTime.MaxValue);

                ApplicationMap.Plan[this._editableId] = this._entity;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
