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
    public partial class EditDicOutsideEmp : Form
    {
        private int _editableId = -1;
        public int EditableId
        {
            get { return _editableId; }
            set { _editableId = value; }
        }

        private OutsideEmp _entity = null;

        public EditDicOutsideEmp()
        {
            InitializeComponent();
            this.orgIDCmB.DataSource = ApplicationMap.OutsideOrg.GetAll();
        }

        private void EditDicOutsideEmp_Shown(object sender, EventArgs e)
        {
            if (this._editableId != -1)
            {
                this._entity = ApplicationMap.OutsideEmp[this._editableId];
                this.lastNameTB.Text = _entity.LastName;
                this.nameTB.Text = _entity.Name;
                this.middleNameTB.Text = _entity.MiddleName;
                this.postNameTB.Text = _entity.PostName;
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
            if (String.IsNullOrEmpty(nameTB.Text.Trim()) || String.IsNullOrEmpty(lastNameTB.Text.Trim()) ||
                String.IsNullOrEmpty(postNameTB.Text.Trim()) || this.orgIDCmB.SelectedItem == null)
            {
                MessageBox.Show("Не заполнено одно из полей","Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (this._editableId != -1)
            {
                _entity.Name = this.nameTB.Text.Trim();
                _entity.LastName = this.lastNameTB.Text.Trim();
                _entity.MiddleName = this.middleNameTB.Text.Trim();
                _entity.PostName = this.postNameTB.Text.Trim();
                _entity.OrgID = (this.orgIDCmB.SelectedItem as OutsideOrg).Id;

                ApplicationMap.OutsideEmp[this._editableId] = this._entity;
            }
            else
            {
                this._entity = new OutsideEmp((this.orgIDCmB.SelectedItem as OutsideOrg).Id,
                    this.postNameTB.Text.Trim(), this.lastNameTB.Text.Trim(),
                    this.nameTB.Text.Trim(), this.middleNameTB.Text.Trim());

                ApplicationMap.OutsideEmp[this._editableId] = this._entity;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
