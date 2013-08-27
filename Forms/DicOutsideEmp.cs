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
    public partial class DicOutsideEmp : Form
    {
        private int _selectedID = -1;
        private bool _isFull = false;
        private Font _clear = null;
        private Font _full = null;
        private Color _clearColor = System.Drawing.SystemColors.ControlLight;
        private Color _fullColor = Color.Black;


        private void LoadData()
        {
            this._clear = filterTB.Font;
            this._full = new Font(this._clear, FontStyle.Regular);
            //this._full.


            itemsLV.Items.Clear();
            ListViewItem lvi = null;

            foreach (OutsideEmp tmp in ApplicationMap.OutsideEmp.GetAll())
            {
                lvi = new ListViewItem(new string[] { tmp.ToString(), tmp.PostName, 
                    ApplicationMap.OutsideOrg[tmp.OrgID].ToString()});
                lvi.Tag = tmp;
                itemsLV.Items.Add(lvi);
            }

        }

        private bool DeleteData()
        {
            try
            {
                ApplicationMap.OutsideEmp.Delete(ApplicationMap.OutsideEmp[_selectedID]);
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

            EditDicOutsideEmp frm = new EditDicOutsideEmp();
            frm.EditableId = this._selectedID;
            if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                this.LoadData();
        }
        
        public DicOutsideEmp()
        {
            InitializeComponent();
            this.LoadData();
        }

        private void itemsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ListView).SelectedItems.Count > 0)
                this._selectedID = ((sender as ListView).SelectedItems[0].Tag as Entity).Id;
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

        private void filterTB_Enter(object sender, EventArgs e)
        {
            if (!_isFull)
            {
                this.filterTB.Text = "";

                filterTB.Font = this._full;
                filterTB.ForeColor = this._fullColor;
            }
            else
            {
                filterTB.SelectAll();
            }

        }

        private void filterTB_Leave(object sender, EventArgs e)
        {
            _isFull = filterTB.Text != "";
            if (!_isFull)
            {
                this.filterTB.Text = "Поиск...";
                filterTB.Font = this._clear;
                filterTB.ForeColor = this._clearColor;
            }
        }

        private void filterTB_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(filterTB.Text.Trim()))
                return;

            ListViewItem lvi = itemsLV.FindItemWithText(filterTB.Text);
            if (lvi != null)
            {
                //MessageBox.Show((lvi.Tag as SimpleEntity).Name);
                lvi.Selected = true;
                //itemsLV.se
            }
        }
    }
}
