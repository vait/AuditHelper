namespace AuditHelper.Forms
{
    partial class DicOutsideEmp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newTSBtn = new System.Windows.Forms.ToolStripButton();
            this.editTSBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.filterTB = new System.Windows.Forms.ToolStripTextBox();
            this.itemsLV = new System.Windows.Forms.ListView();
            this.fioCl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postCl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orgCl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTSBtn,
            this.editTSBtn,
            this.deleteBtn,
            this.filterTB});
            this.toolStrip1.Location = new System.Drawing.Point(0, 237);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(570, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newTSBtn
            // 
            this.newTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTSBtn.Image = global::AuditHelper.Properties.Resources.Add_16;
            this.newTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newTSBtn.Name = "newTSBtn";
            this.newTSBtn.Size = new System.Drawing.Size(23, 22);
            this.newTSBtn.Text = "Новый";
            this.newTSBtn.Click += new System.EventHandler(this.newTSBtn_Click);
            // 
            // editTSBtn
            // 
            this.editTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editTSBtn.Image = global::AuditHelper.Properties.Resources.Edit_16;
            this.editTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editTSBtn.Name = "editTSBtn";
            this.editTSBtn.Size = new System.Drawing.Size(23, 22);
            this.editTSBtn.Text = "Редактировать";
            this.editTSBtn.Click += new System.EventHandler(this.editTSBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteBtn.Image = global::AuditHelper.Properties.Resources.Delete_16;
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(23, 22);
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // filterTB
            // 
            this.filterTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.filterTB.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.filterTB.Name = "filterTB";
            this.filterTB.Size = new System.Drawing.Size(200, 25);
            this.filterTB.Text = "Поиск...";
            this.filterTB.Enter += new System.EventHandler(this.filterTB_Enter);
            this.filterTB.Leave += new System.EventHandler(this.filterTB_Leave);
            this.filterTB.TextChanged += new System.EventHandler(this.filterTB_TextChanged);
            // 
            // itemsLV
            // 
            this.itemsLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.fioCl,
            this.postCl,
            this.orgCl});
            this.itemsLV.FullRowSelect = true;
            this.itemsLV.GridLines = true;
            this.itemsLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.itemsLV.HideSelection = false;
            this.itemsLV.Location = new System.Drawing.Point(12, 12);
            this.itemsLV.MultiSelect = false;
            this.itemsLV.Name = "itemsLV";
            this.itemsLV.ShowGroups = false;
            this.itemsLV.Size = new System.Drawing.Size(546, 212);
            this.itemsLV.TabIndex = 4;
            this.itemsLV.UseCompatibleStateImageBehavior = false;
            this.itemsLV.View = System.Windows.Forms.View.Details;
            this.itemsLV.SelectedIndexChanged += new System.EventHandler(this.itemsLB_SelectedIndexChanged);
            this.itemsLV.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemsLB_MouseDoubleClick);
            // 
            // fioCl
            // 
            this.fioCl.Text = "ФИО";
            this.fioCl.Width = 175;
            // 
            // postCl
            // 
            this.postCl.Text = "Должность";
            this.postCl.Width = 175;
            // 
            // orgCl
            // 
            this.orgCl.Text = "Организация";
            this.orgCl.Width = 185;
            // 
            // DicOutsideEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 262);
            this.Controls.Add(this.itemsLV);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DicOutsideEmp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Внешние сотрудники";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newTSBtn;
        private System.Windows.Forms.ToolStripButton editTSBtn;
        private System.Windows.Forms.ToolStripButton deleteBtn;
        private System.Windows.Forms.ListView itemsLV;
        private System.Windows.Forms.ColumnHeader fioCl;
        private System.Windows.Forms.ColumnHeader postCl;
        private System.Windows.Forms.ColumnHeader orgCl;
        private System.Windows.Forms.ToolStripTextBox filterTB;
    }
}