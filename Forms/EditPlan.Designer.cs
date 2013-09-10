namespace AuditHelper.Forms
{
    partial class EditPlan
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emp1IDCmB = new System.Windows.Forms.ComboBox();
            this.emp2IDCmB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emp3IDCmB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.orgIDCmB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(269, 223);
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
            this.saveBtn.Location = new System.Drawing.Point(12, 223);
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
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Наименование плана";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(13, 25);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(332, 20);
            this.nameTB.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Первый согласующий";
            // 
            // emp1IDCmB
            // 
            this.emp1IDCmB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.emp1IDCmB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.emp1IDCmB.FormattingEnabled = true;
            this.emp1IDCmB.Location = new System.Drawing.Point(13, 116);
            this.emp1IDCmB.Name = "emp1IDCmB";
            this.emp1IDCmB.Size = new System.Drawing.Size(332, 21);
            this.emp1IDCmB.TabIndex = 14;
            // 
            // emp2IDCmB
            // 
            this.emp2IDCmB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.emp2IDCmB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.emp2IDCmB.FormattingEnabled = true;
            this.emp2IDCmB.Location = new System.Drawing.Point(12, 156);
            this.emp2IDCmB.Name = "emp2IDCmB";
            this.emp2IDCmB.Size = new System.Drawing.Size(332, 21);
            this.emp2IDCmB.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Второй согласующий";
            // 
            // emp3IDCmB
            // 
            this.emp3IDCmB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.emp3IDCmB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.emp3IDCmB.FormattingEnabled = true;
            this.emp3IDCmB.Location = new System.Drawing.Point(13, 196);
            this.emp3IDCmB.Name = "emp3IDCmB";
            this.emp3IDCmB.Size = new System.Drawing.Size(332, 21);
            this.emp3IDCmB.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Третий согласующий";
            // 
            // orgIDCmB
            // 
            this.orgIDCmB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.orgIDCmB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.orgIDCmB.FormattingEnabled = true;
            this.orgIDCmB.Location = new System.Drawing.Point(13, 64);
            this.orgIDCmB.Name = "orgIDCmB";
            this.orgIDCmB.Size = new System.Drawing.Size(332, 21);
            this.orgIDCmB.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Организация";
            // 
            // EditPlan
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(356, 259);
            this.Controls.Add(this.orgIDCmB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emp3IDCmB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.emp2IDCmB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.emp1IDCmB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPlan";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор плана";
            this.Shown += new System.EventHandler(this.EditPlan_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox emp1IDCmB;
        private System.Windows.Forms.ComboBox emp2IDCmB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox emp3IDCmB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox orgIDCmB;
        private System.Windows.Forms.Label label5;
    }
}