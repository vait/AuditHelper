using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AuditHelper.Classes;
using AuditHelper.DB;

namespace AuditHelper.Forms
{
    public partial class DicContentStatus : Form
    {
        private int _selectedID = -1;

        private void LoadData()
        {
            itemsLB.DataSource = ApplicationMap.ContentStatus.GetAll();
        }

        private bool DeleteData()
        {
            try
            {
                ApplicationMap.ContentStatus.Delete(ApplicationMap.ContentStatus[_selectedID]);
            }
            catch
            {
                return false;
            }

            this.LoadData();
            return true;
        }

        private void ShowEditForm()
        {
            /*if (this._selectedID < 0)
            {
                MessageBox.Show("Не выбран элемент", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }*/

            EditDicContentStatus frm = new EditDicContentStatus();
            frm.EditableId = this._selectedID;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.LoadData();
        }

        public DicContentStatus()
        {
            InitializeComponent();
            this.itemsLB.ColumnWidth = this.itemsLB.Width - 4;
            this.LoadData();
        }

        private void itemsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListBox).SelectedItem != null)
                this._selectedID = ((sender as ListBox).SelectedItem as Entity).Id;
            else
                this._selectedID = -1;
        }

        private void itemsLB_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.ShowEditForm();
        }

        private void editTSBtn_Click(object sender, EventArgs e)
        {
            this.ShowEditForm();
        }

        private void newTSBtn_Click(object sender, EventArgs e)
        {
            this._selectedID = -1;
            this.ShowEditForm();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить выбранный элемент?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                return;
            }

            if (this.DeleteData())
                MessageBox.Show("Запись успешно удалена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
