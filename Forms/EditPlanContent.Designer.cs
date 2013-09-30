namespace AuditHelper.Forms
{
    partial class EditPlanContent
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
            this.label4 = new System.Windows.Forms.Label();
            this.empIDCmB = new System.Windows.Forms.ComboBox();
            this.riskIDCmB = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contentStatusIDCmB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.parentIDCmB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numberTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.recomendationTB = new System.Windows.Forms.TextBox();
            this.correctActionTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.expiredDTP = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.commentsTB = new System.Windows.Forms.TextBox();
            this.editNameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(450, 359);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 11;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.saveBtn.Location = new System.Drawing.Point(193, 359);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "Сохранить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Дата выполнения*";
            // 
            // empIDCmB
            // 
            this.empIDCmB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.empIDCmB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.empIDCmB.FormattingEnabled = true;
            this.empIDCmB.Location = new System.Drawing.Point(12, 113);
            this.empIDCmB.Name = "empIDCmB";
            this.empIDCmB.Size = new System.Drawing.Size(332, 21);
            this.empIDCmB.TabIndex = 3;
            // 
            // riskIDCmB
            // 
            this.riskIDCmB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.riskIDCmB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.riskIDCmB.FormattingEnabled = true;
            this.riskIDCmB.Location = new System.Drawing.Point(13, 200);
            this.riskIDCmB.Name = "riskIDCmB";
            this.riskIDCmB.Size = new System.Drawing.Size(332, 21);
            this.riskIDCmB.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Уровень риска*";
            // 
            // contentStatusIDCmB
            // 
            this.contentStatusIDCmB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.contentStatusIDCmB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.contentStatusIDCmB.FormattingEnabled = true;
            this.contentStatusIDCmB.Location = new System.Drawing.Point(13, 244);
            this.contentStatusIDCmB.Name = "contentStatusIDCmB";
            this.contentStatusIDCmB.Size = new System.Drawing.Size(332, 21);
            this.contentStatusIDCmB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Статус";
            // 
            // parentIDCmB
            // 
            this.parentIDCmB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.parentIDCmB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.parentIDCmB.FormattingEnabled = true;
            this.parentIDCmB.Location = new System.Drawing.Point(13, 26);
            this.parentIDCmB.Name = "parentIDCmB";
            this.parentIDCmB.Size = new System.Drawing.Size(332, 21);
            this.parentIDCmB.TabIndex = 0;
            this.parentIDCmB.SelectedIndexChanged += new System.EventHandler(this.parentIDCmB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Родитель*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Номер";
            // 
            // numberTB
            // 
            this.numberTB.Enabled = false;
            this.numberTB.Location = new System.Drawing.Point(13, 70);
            this.numberTB.Name = "numberTB";
            this.numberTB.Size = new System.Drawing.Size(296, 20);
            this.numberTB.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(374, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Рекомендации";
            // 
            // recomendationTB
            // 
            this.recomendationTB.Location = new System.Drawing.Point(374, 24);
            this.recomendationTB.Multiline = true;
            this.recomendationTB.Name = "recomendationTB";
            this.recomendationTB.Size = new System.Drawing.Size(331, 112);
            this.recomendationTB.TabIndex = 7;
            // 
            // correctActionTB
            // 
            this.correctActionTB.Location = new System.Drawing.Point(374, 155);
            this.correctActionTB.Multiline = true;
            this.correctActionTB.Name = "correctActionTB";
            this.correctActionTB.Size = new System.Drawing.Size(331, 112);
            this.correctActionTB.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(374, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Корректирующие действия";
            // 
            // expiredDTP
            // 
            this.expiredDTP.Location = new System.Drawing.Point(13, 157);
            this.expiredDTP.Name = "expiredDTP";
            this.expiredDTP.Size = new System.Drawing.Size(331, 20);
            this.expiredDTP.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ответственный*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Комментарии";
            // 
            // commentsTB
            // 
            this.commentsTB.Location = new System.Drawing.Point(12, 286);
            this.commentsTB.Multiline = true;
            this.commentsTB.Name = "commentsTB";
            this.commentsTB.Size = new System.Drawing.Size(693, 67);
            this.commentsTB.TabIndex = 9;
            // 
            // editNameBtn
            // 
            this.editNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editNameBtn.Image = global::AuditHelper.Properties.Resources.Edit_16;
            this.editNameBtn.Location = new System.Drawing.Point(315, 70);
            this.editNameBtn.Name = "editNameBtn";
            this.editNameBtn.Size = new System.Drawing.Size(29, 23);
            this.editNameBtn.TabIndex = 2;
            this.editNameBtn.UseVisualStyleBackColor = true;
            this.editNameBtn.Click += new System.EventHandler(this.editNameBtn_Click);
            // 
            // EditPlanContent
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(717, 395);
            this.Controls.Add(this.editNameBtn);
            this.Controls.Add(this.expiredDTP);
            this.Controls.Add(this.commentsTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.correctActionTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.recomendationTB);
            this.Controls.Add(this.numberTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.parentIDCmB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.contentStatusIDCmB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.riskIDCmB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.empIDCmB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPlanContent";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редактор записи";
            this.Shown += new System.EventHandler(this.EditContent_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox empIDCmB;
        private System.Windows.Forms.ComboBox riskIDCmB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox contentStatusIDCmB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox parentIDCmB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox recomendationTB;
        private System.Windows.Forms.TextBox correctActionTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker expiredDTP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox commentsTB;
        private System.Windows.Forms.Button editNameBtn;
    }
}