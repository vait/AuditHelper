namespace AuditHelper
{
    partial class frmTestEnvironment
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbState = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 247);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.BackColor = System.Drawing.Color.Transparent;
            this.lbState.Location = new System.Drawing.Point(12, 231);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(0, 13);
            this.lbState.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btnDownload);
            this.panel1.Controls.Add(this.btnInstall);
            this.panel1.Location = new System.Drawing.Point(12, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 87);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(27, 17);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(322, 36);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Нед доступа к движку базы данных Acceess. Возможно он не установлен.";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(274, 59);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(75, 23);
            this.btnDownload.TabIndex = 1;
            this.btnDownload.Text = "Скачать";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(27, 59);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 0;
            this.btnInstall.Text = "Установить";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(12, 141);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(376, 87);
            this.panel2.TabIndex = 3;
            this.panel2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(27, 17);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(322, 36);
            this.textBox2.TabIndex = 2;
            this.textBox2.Text = "Файл базы не найден!";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(148, 59);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmTestEnvironment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::AuditHelper.Properties.Resources.startup_icon;
            this.ClientSize = new System.Drawing.Size(400, 300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTestEnvironment";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TestEnvironment";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTestEnvironment_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnClose;
    }
}