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
    public partial class EditPlanContent : Form
    {
        private int _editableId = -1;
        public int EditableId
        {
            get { return _editableId; }
            set { _editableId = value; }
        }

        private int _planId = -1;
        public int PlanId
        {
            get { return _planId; }
            set
            {
                _planId = value;
                this._plan = ApplicationMap.Plan[this._planId];
            }
        }

        private int _parentId = -1;
        public int ParentId
        {
            get { return _parentId; }
            set { _parentId = value; }
        }

        private Plan _plan = null;
        private List<PlanContent> _content = null;
        private PlanContent _entity = null;

        private void SetEnabledRoot(bool aRoot = true)
        {
            if (aRoot)
            {
                this.empIDCmB.SelectedIndex = 0;
                this.expiredDTP.Value = DateTime.Now.AddDays(1);
                this.riskIDCmB.SelectedIndex = 0;
                this.correctActionTB.Text = "none";
            }
            else
            {
                this.empIDCmB.SelectedItem = null;
                this.expiredDTP.Value = DateTime.Now;
                this.riskIDCmB.SelectedItem = null;
                this.correctActionTB.Clear();
            }
            this.empIDCmB.Enabled = !aRoot;
            this.expiredDTP.Enabled = !aRoot;
            this.riskIDCmB.Enabled = !aRoot;
            this.correctActionTB.Enabled = !aRoot;
            this.contentStatusIDCmB.Enabled = !aRoot;
        }

        public EditPlanContent()
        {
            InitializeComponent();
            this.empIDCmB.DataSource = ApplicationMap.OutsideEmp.GetAll();
            this.riskIDCmB.DataSource = ApplicationMap.LevelsOfRisk.GetAll();
            this.contentStatusIDCmB.DataSource = ApplicationMap.ContentStatus.GetAll();
        }

        private void EditContent_Shown(object sender, EventArgs e)
        {
            if (_planId == -1)
            {
                MessageBox.Show("Не указан план", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }

            this.expiredDTP.Value = DateTime.Now;

            this.empIDCmB.SelectedItem = null;
            this.riskIDCmB.SelectedItem = null;
            this.contentStatusIDCmB.SelectedItem = null;

            if (_planId != -1)
            {
                _content = new List<PlanContent>();

                //Заполняем содержание
                _content.Add(new PlanContent(-1, "", "", -1, DateTime.Now, "", -1, -1, -1, "<Корневой пункт>", -1));

                foreach (int i in this._plan.Content)
                {
                    _content.Add(ApplicationMap.PlanContent[i]);
                }

                /* Голый линк (вложенность только до второго уровня) */
                //Если нет потомков, то можно выводить список 
                if (_content.Where(parent => parent.ParentId == this._editableId).Count() == 0 ||
                    this._editableId == -1)
                    //Получаем список всех родителей
                    this.parentIDCmB.DataSource = _content.Where(parent => parent.ParentId == -1).ToList();
                else
                    this.parentIDCmB.Items.Add(this._content[0]);
            }

            this.parentIDCmB.SelectedIndex = 0;

            if (this._editableId != -1)
            {
                this._entity = ApplicationMap.PlanContent[this._editableId];

                if (this._entity.ParentId != -1)
                    this.parentIDCmB.SelectedItem = ApplicationMap.PlanContent[this._entity.ParentId];
                else
                    this.parentIDCmB.SelectedIndex = 0;

                this.numberTB.Text = this._entity.Name;

                this.empIDCmB.SelectedItem = ApplicationMap.OutsideEmp[this._entity.EmployeeId];

                this.expiredDTP.Value = this._entity.Expired;

                if (this._entity.RiskId != -1)
                    this.riskIDCmB.SelectedItem = ApplicationMap.LevelsOfRisk[this._entity.RiskId];
                else
                    this.riskIDCmB.SelectedIndex = -1;

                if (this._entity.StatusId != -1)
                    this.contentStatusIDCmB.SelectedItem = ApplicationMap.ContentStatus[this._entity.StatusId];
                else
                    this.contentStatusIDCmB.SelectedIndex = -1;

                this.recomendationTB.Text = this._entity.Recomendation;

                this.correctActionTB.Text = this._entity.CorrectActions;

                this.commentsTB.Text = this._entity.Comments;

            }
            else
            {
                if (this._parentId != -1)
                    this.parentIDCmB.SelectedItem = ApplicationMap.PlanContent[this._parentId];
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            //Если создаем корневой элемент
          /*  if (this.parentIDCmB.SelectedItem != null &&
                (this.parentIDCmB.SelectedItem as SimpleEntity).Id == -1)
            {
                if (String.IsNullOrEmpty(numberTB.Text.Trim()) || String.IsNullOrEmpty(recomendationTB.Text.Trim()))
                {
                    MessageBox.Show("Не заполнено одно из полей (*)","Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                    return;
                }

            } 
            else //Не корневой элемент
            {
                if (String.IsNullOrEmpty(numberTB.Text.Trim()) || this.empIDCmB.SelectedItem == null ||
                    this.riskIDCmB.SelectedItem == null || String.IsNullOrEmpty(recomendationTB.Text.Trim()) ||
                    String.IsNullOrEmpty(correctActionTB.Text.Trim()))
                {
                    MessageBox.Show("Не заполнено одно из полей (*)", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                    return;
                }
            }*/

            if (String.IsNullOrEmpty(numberTB.Text.Trim()) || this.empIDCmB.SelectedItem == null ||
                    this.riskIDCmB.SelectedItem == null || String.IsNullOrEmpty(recomendationTB.Text.Trim()) ||
                    String.IsNullOrEmpty(correctActionTB.Text.Trim()))
            {
                MessageBox.Show("Не заполнено одно из полей (*)", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = System.Windows.Forms.DialogResult.None;
                return;
            }

            if (this._editableId != -1)
            {
                if (this.expiredDTP.Value != this._entity.Expired &&
                    this.expiredDTP.Value < DateTime.Now)
                {
                    MessageBox.Show("Не заполнено одно из полей (*)", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                    return;
                }
 
                if (this.parentIDCmB.SelectedItem != null)
                    this._entity.ParentId = (this.parentIDCmB.SelectedItem as SimpleEntity).Id;
                else
                    this._entity.ParentId = -1;

                this._entity.Name = this.numberTB.Text.Trim();

                this._entity.EmployeeId = (this.empIDCmB.SelectedItem as SimpleEntity).Id;
                
                this._entity.Expired = this.expiredDTP.Value;

                this._entity.RiskId = (this.riskIDCmB.SelectedItem as SimpleEntity).Id;

                if (this.contentStatusIDCmB.SelectedItem != null)
                    this._entity.StatusId = (this.contentStatusIDCmB.SelectedItem as SimpleEntity).Id;
                else
                    this._entity.StatusId = -1;

                this._entity.Recomendation = this.recomendationTB.Text.Trim();

                this._entity.CorrectActions = this.correctActionTB.Text.Trim();

                this._entity.Comments = this.commentsTB.Text.Trim();

                ApplicationMap.Plan[this._planId][this._editableId] = this._entity;
                //ApplicationMap.PlanContent[this._editableId] = this._entity;
            }
            else
            {
                if (this.expiredDTP.Value < DateTime.Now && (this.parentIDCmB.SelectedItem as SimpleEntity).Id != -1)
                {
                    MessageBox.Show("Не заполнено одно из полей (*)", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                    return;
                }

                this._entity = new PlanContent(
                    this.parentIDCmB.SelectedValue != null ? (this.parentIDCmB.SelectedItem as SimpleEntity).Id : -1,
                    this.recomendationTB.Text.Trim(), 
                    this.correctActionTB.Text.Trim(),
                    (this.empIDCmB.SelectedItem as SimpleEntity).Id,
                    this.expiredDTP.Value,
                    commentsTB.Text.Trim(),
                    (this.riskIDCmB.SelectedItem as SimpleEntity).Id,
                    this.contentStatusIDCmB.SelectedItem != null ? (this.contentStatusIDCmB.SelectedItem as SimpleEntity).Id : -1,
                    this.PlanId, 
                    this.numberTB.Text.Trim());

                //ApplicationMap.PlanContent[this._editableId] = this._entity;
                ApplicationMap.Plan[this._planId][-1] = this._entity;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void parentIDCmB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.parentIDCmB.SelectedItem == null)
                return;
            //Выбираем родителя и на его основе назначаем номер (всегда последний, изменение 
            //порядка доступно только в главной форме)
            if ((this.parentIDCmB.SelectedItem as SimpleEntity).Id == -1)
            {
                this.numberTB.Text = _content.Where(parent => parent.ParentId == -1).Count().ToString() + ".";
                this.SetEnabledRoot(true);
            }
            else
            {
                this.numberTB.Text = (this.parentIDCmB.SelectedItem as PlanContent).Name +
                    (this._content.Where(item => item.ParentId == (this.parentIDCmB.SelectedItem as PlanContent).Id).ToList().Count + 1).ToString("##") + ".";
                this.SetEnabledRoot(false);
            }
        }

        private void editNameBtn_Click(object sender, EventArgs e)
        {
            this.numberTB.Enabled = !this.numberTB.Enabled;
        }
    }
}
