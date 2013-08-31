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
    public partial class EditDicContentStatus : Form
    {
        private int _editableId = -1;
        public int EditableId
        {
            get { return _editableId; }
            set { _editableId = value; }
        }
        private ContentStatus _entity = null;

        public EditDicContentStatus()
        {
            InitializeComponent();
        }

        private void EditContentStatus_Shown(object sender, EventArgs e)
        {
            if (this._editableId != -1)
            {
                this._entity = ApplicationMap.ContentStatus[this._editableId];
                this.nameTB.Text = _entity.Name;
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
                ApplicationMap.ContentStatus[this._editableId] = this._entity;
            }
            else
            {
                this._entity = new ContentStatus(this.nameTB.Text.Trim());
                ApplicationMap.ContentStatus[this._editableId] = this._entity;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
