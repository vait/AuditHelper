namespace AuditHelper.Forms
{
    partial class EditDicOutsideOrg
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.fullNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(12, 25);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(332, 20);
            this.nameTB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Краткое название";
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.saveBtn.Location = new System.Drawing.Point(12, 129);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 2;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(269, 129);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Полное название";
            // 
            // fullNameTB
            // 
            this.fullNameTB.Location = new System.Drawing.Point(12, 64);
            this.fullNameTB.Multiline = true;
            this.fullNameTB.Name = "fullNameTB";
            this.fullNameTB.Size = new System.Drawing.Size(332, 59);
            this.fullNameTB.TabIndex = 1;
            // 
            // EditDicOutsideOrg
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(356, 165);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fullNameTB);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDicOutsideOrg";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор";
            this.Shown += new System.EventHandler(this.EditDicLevelOfRisk_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fullNameTB;
    }
}