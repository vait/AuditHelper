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
    public partial class EditDicOutsideOrg : Form
    {
        private int _editableId = -1;
        public int EditableId
        {
            get { return _editableId; }
            set { _editableId = value; }
        }
        private OutsideOrg _entity = null;

        public EditDicOutsideOrg()
        {
            InitializeComponent();
        }

        private void EditDicLevelOfRisk_Shown(object sender, EventArgs e)
        {
            if (this._editableId != -1)
            {
                this._entity = ApplicationMap.OutsideOrg[this._editableId];
                this.nameTB.Text = _entity.Name;
                this.fullNameTB.Text = _entity.FullName;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nameTB.Text.Trim()))
            {
                this.Close();
                return;
            }

            if (this._editableId != -1)
            {
                this._entity.Name = nameTB.Text.Trim();
                this._entity.FullName = fullNameTB.Text.Trim();
                ApplicationMap.OutsideOrg[this._editableId] = this._entity;
            }
            else
            {
                this._entity = new OutsideOrg(this.fullNameTB.Text.Trim(), this.nameTB.Text.Trim());
                ApplicationMap.OutsideOrg[this._editableId] = this._entity;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
