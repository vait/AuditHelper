namespace AuditHelper
{
    partial class frmMain
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "11",
            "12",
            "13"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("2");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("3");
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.планToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.организацииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.должностиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.уровниРискаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.статусыРекомендацийToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.totalPlansSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.expiredPlansSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.notExpiredSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.contentTV = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.plansLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.планToolStripMenuItem,
            this.справочникиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // планToolStripMenuItem
            // 
            this.планToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.планToolStripMenuItem.Name = "планToolStripMenuItem";
            this.планToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.планToolStripMenuItem.Text = "План";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.создатьToolStripMenuItem.Text = "Создать";
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.организацииToolStripMenuItem,
            this.должностиToolStripMenuItem,
            this.уровниРискаToolStripMenuItem,
            this.статусыРекомендацийToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // организацииToolStripMenuItem
            // 
            this.организацииToolStripMenuItem.Name = "организацииToolStripMenuItem";
            this.организацииToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.организацииToolStripMenuItem.Text = "Организации";
            this.организацииToolStripMenuItem.Click += new System.EventHandler(this.организацииToolStripMenuItem_Click);
            // 
            // должностиToolStripMenuItem
            // 
            this.должностиToolStripMenuItem.Name = "должностиToolStripMenuItem";
            this.должностиToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.должностиToolStripMenuItem.Text = "Сотрудники";
            this.должностиToolStripMenuItem.Click += new System.EventHandler(this.должностиToolStripMenuItem_Click);
            // 
            // уровниРискаToolStripMenuItem
            // 
            this.уровниРискаToolStripMenuItem.Name = "уровниРискаToolStripMenuItem";
            this.уровниРискаToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.уровниРискаToolStripMenuItem.Text = "Уровни риска";
            this.уровниРискаToolStripMenuItem.Click += new System.EventHandler(this.уровниРискаToolStripMenuItem_Click);
            // 
            // статусыРекомендацийToolStripMenuItem
            // 
            this.статусыРекомендацийToolStripMenuItem.Name = "статусыРекомендацийToolStripMenuItem";
            this.статусыРекомендацийToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.статусыРекомендацийToolStripMenuItem.Text = "Статусы рекомендаций";
            this.статусыРекомендацийToolStripMenuItem.Click += new System.EventHandler(this.статусыРекомендацийToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.totalPlansSSL,
            this.expiredPlansSSL,
            this.notExpiredSSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(817, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // totalPlansSSL
            // 
            this.totalPlansSSL.AutoSize = false;
            this.totalPlansSSL.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.totalPlansSSL.Name = "totalPlansSSL";
            this.totalPlansSSL.Size = new System.Drawing.Size(180, 17);
            this.totalPlansSSL.Text = "Всего планов: 0";
            this.totalPlansSSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.totalPlansSSL.ToolTipText = "Всего планов";
            // 
            // expiredPlansSSL
            // 
            this.expiredPlansSSL.AutoSize = false;
            this.expiredPlansSSL.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.expiredPlansSSL.DoubleClickEnabled = true;
            this.expiredPlansSSL.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.expiredPlansSSL.ForeColor = System.Drawing.Color.Red;
            this.expiredPlansSSL.Name = "expiredPlansSSL";
            this.expiredPlansSSL.Size = new System.Drawing.Size(180, 17);
            this.expiredPlansSSL.Text = "Просроченные планы: 0";
            this.expiredPlansSSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.expiredPlansSSL.ToolTipText = "Просроченные планы";
            // 
            // notExpiredSSL
            // 
            this.notExpiredSSL.AutoSize = false;
            this.notExpiredSSL.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.notExpiredSSL.DoubleClickEnabled = true;
            this.notExpiredSSL.ForeColor = System.Drawing.Color.DodgerBlue;
            this.notExpiredSSL.Name = "notExpiredSSL";
            this.notExpiredSSL.Size = new System.Drawing.Size(180, 17);
            this.notExpiredSSL.Text = "Осталось менее 4х дней: 0";
            this.notExpiredSSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.notExpiredSSL.ToolTipText = "Срок истекает через три дня";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Size = new System.Drawing.Size(817, 411);
            this.splitContainer1.SplitterDistance = 561;
            this.splitContainer1.TabIndex = 3;
            // 
            // contentTV
            // 
            this.contentTV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentTV.Location = new System.Drawing.Point(3, 16);
            this.contentTV.Name = "contentTV";
            this.contentTV.Size = new System.Drawing.Size(246, 392);
            this.contentTV.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.contentTV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Содержание";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Controls.Add(this.plansLV);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 411);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // plansLV
            // 
            this.plansLV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.plansLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.plansLV.FullRowSelect = true;
            this.plansLV.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.plansLV.HideSelection = false;
            this.plansLV.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.plansLV.Location = new System.Drawing.Point(3, 16);
            this.plansLV.MultiSelect = false;
            this.plansLV.Name = "plansLV";
            this.plansLV.ShowGroups = false;
            this.plansLV.Size = new System.Drawing.Size(555, 364);
            this.plansLV.TabIndex = 0;
            this.plansLV.UseCompatibleStateImageBehavior = false;
            this.plansLV.View = System.Windows.Forms.View.Details;
            this.plansLV.Resize += new System.EventHandler(this.plansLV_Resize);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Название";
            this.columnHeader1.Width = 194;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Организация";
            this.columnHeader2.Width = 97;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ответственный";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Дата ближайшего пункта";
            this.columnHeader4.Width = 146;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Location = new System.Drawing.Point(3, 383);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(555, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 457);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Помошник аудитора";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem планToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem организацииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem должностиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem уровниРискаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem статусыРекомендацийToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel totalPlansSSL;
        private System.Windows.Forms.ToolStripStatusLabel expiredPlansSSL;
        private System.Windows.Forms.ToolStripStatusLabel notExpiredSSL;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView contentTV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListView plansLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

