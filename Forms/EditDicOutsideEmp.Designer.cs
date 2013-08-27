namespace AuditHelper.Forms
{
    partial class EditDicOutsideEmp
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.middleNameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.postNameTB = new System.Windows.Forms.TextBox();
            this.orgIDCmB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(269, 213);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.saveBtn.Location = new System.Drawing.Point(12, 213);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Фамилия";
            // 
            // lastNameTB
            // 
            this.lastNameTB.Location = new System.Drawing.Point(12, 25);
            this.lastNameTB.Name = "lastNameTB";
            this.lastNameTB.Size = new System.Drawing.Size(332, 20);
            this.lastNameTB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Имя";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(12, 64);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(332, 20);
            this.nameTB.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Отчество";
            // 
            // middleNameTB
            // 
            this.middleNameTB.Location = new System.Drawing.Point(12, 103);
            this.middleNameTB.Name = "middleNameTB";
            this.middleNameTB.Size = new System.Drawing.Size(332, 20);
            this.middleNameTB.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Организация";
            // 
            // postNameTB
            // 
            this.postNameTB.Location = new System.Drawing.Point(12, 142);
            this.postNameTB.Name = "postNameTB";
            this.postNameTB.Size = new System.Drawing.Size(332, 20);
            this.postNameTB.TabIndex = 12;
            // 
            // orgIDCmB
            // 
            this.orgIDCmB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.orgIDCmB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.orgIDCmB.FormattingEnabled = true;
            this.orgIDCmB.Location = new System.Drawing.Point(12, 181);
            this.orgIDCmB.Name = "orgIDCmB";
            this.orgIDCmB.Size = new System.Drawing.Size(332, 21);
            this.orgIDCmB.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Должность";
            // 
            // EditDicOutsideEmp
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(356, 248);
            this.Controls.Add(this.orgIDCmB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.postNameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.middleNameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lastNameTB);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditDicOutsideEmp";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор";
            this.Shown += new System.EventHandler(this.EditDicOutsideEmp_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox middleNameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox postNameTB;
        private System.Windows.Forms.ComboBox orgIDCmB;
        private System.Windows.Forms.Label label5;
    }
}