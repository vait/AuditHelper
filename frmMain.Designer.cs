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
            this.pageSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalPlansSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.expiredPlansSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.notExpiredSSL = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addPlanTSBtn = new System.Windows.Forms.ToolStripButton();
            this.editPlanTSBtn = new System.Windows.Forms.ToolStripButton();
            this.deletePalnTSBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.prev50TSBtn = new System.Windows.Forms.ToolStripButton();
            this.next50TSBtn = new System.Windows.Forms.ToolStripButton();
            this.allTSBtn = new System.Windows.Forms.ToolStripButton();
            this.plansLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.addItemTSBtn = new System.Windows.Forms.ToolStripButton();
            this.editItemTSBtn = new System.Windows.Forms.ToolStripButton();
            this.deleteItemTSBtn = new System.Windows.Forms.ToolStripButton();
            this.contentTV = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
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
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
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
            this.pageSSL,
            this.totalPlansSSL,
            this.expiredPlansSSL,
            this.notExpiredSSL});
            this.statusStrip1.Location = new System.Drawing.Point(0, 435);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(817, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pageSSL
            // 
            this.pageSSL.AutoSize = false;
            this.pageSSL.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.pageSSL.Name = "pageSSL";
            this.pageSSL.Size = new System.Drawing.Size(100, 17);
            this.pageSSL.Text = "Страница: ";
            this.pageSSL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPlanTSBtn,
            this.editPlanTSBtn,
            this.deletePalnTSBtn,
            this.toolStripSeparator1,
            this.prev50TSBtn,
            this.next50TSBtn,
            this.allTSBtn});
            this.toolStrip1.Location = new System.Drawing.Point(3, 383);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(555, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addPlanTSBtn
            // 
            this.addPlanTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addPlanTSBtn.Image = global::AuditHelper.Properties.Resources.Add_16;
            this.addPlanTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addPlanTSBtn.Name = "addPlanTSBtn";
            this.addPlanTSBtn.Size = new System.Drawing.Size(23, 22);
            this.addPlanTSBtn.Text = "Создать план";
            this.addPlanTSBtn.ToolTipText = "Создать план";
            this.addPlanTSBtn.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // editPlanTSBtn
            // 
            this.editPlanTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editPlanTSBtn.Image = global::AuditHelper.Properties.Resources.Edit_16;
            this.editPlanTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editPlanTSBtn.Name = "editPlanTSBtn";
            this.editPlanTSBtn.Size = new System.Drawing.Size(23, 22);
            this.editPlanTSBtn.Text = "Редактировать план";
            this.editPlanTSBtn.ToolTipText = "Редактировать план";
            this.editPlanTSBtn.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // deletePalnTSBtn
            // 
            this.deletePalnTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deletePalnTSBtn.Image = global::AuditHelper.Properties.Resources.Delete_16;
            this.deletePalnTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deletePalnTSBtn.Name = "deletePalnTSBtn";
            this.deletePalnTSBtn.Size = new System.Drawing.Size(23, 22);
            this.deletePalnTSBtn.Text = "Удалить план";
            this.deletePalnTSBtn.ToolTipText = "Удалить план";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // prev50TSBtn
            // 
            this.prev50TSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prev50TSBtn.Enabled = false;
            this.prev50TSBtn.Image = global::AuditHelper.Properties.Resources.Previous_16;
            this.prev50TSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prev50TSBtn.Name = "prev50TSBtn";
            this.prev50TSBtn.Size = new System.Drawing.Size(23, 22);
            this.prev50TSBtn.Text = "toolStripButton1";
            this.prev50TSBtn.ToolTipText = "Предыдущие 50";
            this.prev50TSBtn.Click += new System.EventHandler(this.prev50TSBtn_Click);
            // 
            // next50TSBtn
            // 
            this.next50TSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.next50TSBtn.Image = global::AuditHelper.Properties.Resources.Next_16;
            this.next50TSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.next50TSBtn.Name = "next50TSBtn";
            this.next50TSBtn.Size = new System.Drawing.Size(23, 22);
            this.next50TSBtn.Text = "toolStripButton2";
            this.next50TSBtn.ToolTipText = "Следующие 50";
            this.next50TSBtn.Click += new System.EventHandler(this.next50TSBtn_Click);
            // 
            // allTSBtn
            // 
            this.allTSBtn.CheckOnClick = true;
            this.allTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.allTSBtn.Image = global::AuditHelper.Properties.Resources.ShowAll_16;
            this.allTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.allTSBtn.Name = "allTSBtn";
            this.allTSBtn.Size = new System.Drawing.Size(23, 22);
            this.allTSBtn.Text = "toolStripButton1";
            this.allTSBtn.ToolTipText = "Все записи";
            this.allTSBtn.CheckStateChanged += new System.EventHandler(this.allTSBtn_CheckStateChanged);
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
            this.plansLV.SelectedIndexChanged += new System.EventHandler(this.plansLV_SelectedIndexChanged);
            this.plansLV.DoubleClick += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
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
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.toolStrip2);
            this.groupBox1.Controls.Add(this.contentTV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Содержание";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addItemTSBtn,
            this.editItemTSBtn,
            this.deleteItemTSBtn});
            this.toolStrip2.Location = new System.Drawing.Point(3, 383);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(246, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // addItemTSBtn
            // 
            this.addItemTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addItemTSBtn.Image = global::AuditHelper.Properties.Resources.Add_16;
            this.addItemTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addItemTSBtn.Name = "addItemTSBtn";
            this.addItemTSBtn.Size = new System.Drawing.Size(23, 22);
            this.addItemTSBtn.Text = "toolStripButton1";
            this.addItemTSBtn.ToolTipText = "Добавить раздел";
            // 
            // editItemTSBtn
            // 
            this.editItemTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editItemTSBtn.Image = global::AuditHelper.Properties.Resources.Edit_16;
            this.editItemTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editItemTSBtn.Name = "editItemTSBtn";
            this.editItemTSBtn.Size = new System.Drawing.Size(23, 22);
            this.editItemTSBtn.Text = "toolStripButton2";
            this.editItemTSBtn.ToolTipText = "Редактировать раздел";
            // 
            // deleteItemTSBtn
            // 
            this.deleteItemTSBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteItemTSBtn.Image = global::AuditHelper.Properties.Resources.Delete_16;
            this.deleteItemTSBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteItemTSBtn.Name = "deleteItemTSBtn";
            this.deleteItemTSBtn.Size = new System.Drawing.Size(23, 22);
            this.deleteItemTSBtn.Text = "toolStripButton3";
            this.deleteItemTSBtn.ToolTipText = "Удалить раздел";
            // 
            // contentTV
            // 
            this.contentTV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentTV.Location = new System.Drawing.Point(3, 16);
            this.contentTV.Name = "contentTV";
            this.contentTV.Size = new System.Drawing.Size(246, 364);
            this.contentTV.TabIndex = 2;
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
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton addPlanTSBtn;
        private System.Windows.Forms.ToolStripButton editPlanTSBtn;
        private System.Windows.Forms.ToolStripButton deletePalnTSBtn;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton addItemTSBtn;
        private System.Windows.Forms.ToolStripButton editItemTSBtn;
        private System.Windows.Forms.ToolStripButton deleteItemTSBtn;
        private System.Windows.Forms.ToolStripButton prev50TSBtn;
        private System.Windows.Forms.ToolStripButton next50TSBtn;
        private System.Windows.Forms.ToolStripButton allTSBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripStatusLabel pageSSL;
    }
}

