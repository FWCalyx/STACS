
namespace LacosteC868Task
{
    partial class UserView
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
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.RepeatPasswordBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ResetPassButton = new System.Windows.Forms.Button();
            this.AdminCheckBox = new System.Windows.Forms.CheckBox();
            this.CounselorComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(84, 497);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(127, 23);
            this.UpdateButton.TabIndex = 56;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(84, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 45);
            this.label1.TabIndex = 50;
            this.label1.Text = "User View";
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(84, 526);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(127, 23);
            this.CancelButton1.TabIndex = 8;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.RepeatPasswordBox);
            this.panel1.Controls.Add(this.UserNameTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PasswordBox);
            this.panel1.Controls.Add(this.ResetPassButton);
            this.panel1.Controls.Add(this.AdminCheckBox);
            this.panel1.Controls.Add(this.CounselorComboBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(16, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 376);
            this.panel1.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(32, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "Repeat New Password:";
            // 
            // RepeatPasswordBox
            // 
            this.RepeatPasswordBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepeatPasswordBox.Location = new System.Drawing.Point(32, 296);
            this.RepeatPasswordBox.MaxLength = 10;
            this.RepeatPasswordBox.Name = "RepeatPasswordBox";
            this.RepeatPasswordBox.Size = new System.Drawing.Size(187, 32);
            this.RepeatPasswordBox.TabIndex = 5;
            this.RepeatPasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordBox_KeyPress);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UserNameTextBox.Location = new System.Drawing.Point(122, 26);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(160, 32);
            this.UserNameTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(32, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 60;
            this.label2.Text = "Enter New Password:";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.Location = new System.Drawing.Point(32, 229);
            this.PasswordBox.MaxLength = 10;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(187, 32);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PasswordBox_KeyPress);
            // 
            // ResetPassButton
            // 
            this.ResetPassButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetPassButton.Location = new System.Drawing.Point(32, 334);
            this.ResetPassButton.Name = "ResetPassButton";
            this.ResetPassButton.Size = new System.Drawing.Size(187, 34);
            this.ResetPassButton.TabIndex = 6;
            this.ResetPassButton.Text = "Change Password";
            this.ResetPassButton.UseVisualStyleBackColor = true;
            this.ResetPassButton.Click += new System.EventHandler(this.ResetPassButton_Click);
            // 
            // AdminCheckBox
            // 
            this.AdminCheckBox.AutoSize = true;
            this.AdminCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdminCheckBox.Location = new System.Drawing.Point(32, 82);
            this.AdminCheckBox.Name = "AdminCheckBox";
            this.AdminCheckBox.Size = new System.Drawing.Size(146, 25);
            this.AdminCheckBox.TabIndex = 2;
            this.AdminCheckBox.Text = "Admin Privileges";
            this.AdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // CounselorComboBox
            // 
            this.CounselorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CounselorComboBox.FormattingEnabled = true;
            this.CounselorComboBox.Location = new System.Drawing.Point(32, 162);
            this.CounselorComboBox.Name = "CounselorComboBox";
            this.CounselorComboBox.Size = new System.Drawing.Size(250, 23);
            this.CounselorComboBox.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(32, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Counselor Assigned";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(32, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username:";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(84, 497);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 23);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // UserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 561);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CancelButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserView";
            this.Text = "UserView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox CounselorComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ResetPassButton;
        private System.Windows.Forms.CheckBox AdminCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox RepeatPasswordBox;
    }
}