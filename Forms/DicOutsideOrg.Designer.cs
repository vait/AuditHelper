namespace AuditHelper.Forms
{
    partial class DicOutsideOrg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DicOutsideOrg));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newTSBtn = new System.Windows.Forms.ToolStripButton();
            this.editTSBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteBtn = new System.Windows.Forms.ToolStripButton();
            this.itemsLB = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newTSBtn,
            this.editTSBtn,
            this.deleteBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 237);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(381, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newTSBtn
            // 
            this.newTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newTSBtn.Image = ((System.Drawing.Image)(resources.GetObject("newTSBtn.Image")));
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
            this.deleteBtn.Image = ((System.Drawing.Image)(resources.GetObject("deleteBtn.Image")));
            this.deleteBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(23, 22);
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // itemsLB
            // 
            this.itemsLB.FormattingEnabled = true;
            this.itemsLB.Location = new System.Drawing.Point(12, 6);
            this.itemsLB.MultiColumn = true;
            this.itemsLB.Name = "itemsLB";
            this.itemsLB.Size = new System.Drawing.Size(357, 212);
            this.itemsLB.TabIndex = 2;
            this.itemsLB.SelectedIndexChanged += new System.EventHandler(this.itemsLB_SelectedIndexChanged);
            this.itemsLB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.itemsLB_MouseDoubleClick);
            // 
            // DicOutsideOrg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 262);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.itemsLB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DicOutsideOrg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Внешние организации";
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
        private System.Windows.Forms.ListBox itemsLB;
    }
}