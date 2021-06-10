
namespace LacosteC868Task
{
    partial class AppointmentView
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
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.ReasonComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TodayLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SchoolComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.UpdatedDate = new System.Windows.Forms.DateTimePicker();
            this.UpdatedBy = new System.Windows.Forms.Label();
            this.CreatedBy = new System.Windows.Forms.Label();
            this.CreateDate = new System.Windows.Forms.DateTimePicker();
            this.CounselorComboBox = new System.Windows.Forms.ComboBox();
            this.StudentName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.CancelButton1 = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EndTime
            // 
            this.EndTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTime.Location = new System.Drawing.Point(125, 265);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(147, 23);
            this.EndTime.TabIndex = 6;
            this.EndTime.Value = new System.DateTime(2021, 6, 3, 15, 48, 40, 0);
            // 
            // StartTime
            // 
            this.StartTime.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTime.Location = new System.Drawing.Point(123, 236);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(149, 23);
            this.StartTime.TabIndex = 5;
            this.StartTime.Value = new System.DateTime(2021, 6, 3, 15, 48, 40, 0);
            // 
            // ReasonComboBox
            // 
            this.ReasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReasonComboBox.FormattingEnabled = true;
            this.ReasonComboBox.Items.AddRange(new object[] {
            "Counseling",
            "Tutoring"});
            this.ReasonComboBox.Location = new System.Drawing.Point(471, 36);
            this.ReasonComboBox.Name = "ReasonComboBox";
            this.ReasonComboBox.Size = new System.Drawing.Size(250, 23);
            this.ReasonComboBox.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(31, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 21);
            this.label9.TabIndex = 4;
            this.label9.Text = "Description";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(34, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Start Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(381, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Counselor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(48, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Location:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(8, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "Student Name:";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(649, 526);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(127, 23);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(649, 526);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 23);
            this.SaveButton.TabIndex = 48;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TodayLabel
            // 
            this.TodayLabel.AutoSize = true;
            this.TodayLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TodayLabel.Location = new System.Drawing.Point(649, 40);
            this.TodayLabel.Name = "TodayLabel";
            this.TodayLabel.Size = new System.Drawing.Size(49, 20);
            this.TodayLabel.TabIndex = 45;
            this.TodayLabel.Text = "Today";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.Location = new System.Drawing.Point(649, 12);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(51, 20);
            this.UserNameLabel.TabIndex = 44;
            this.UserNameLabel.Text = "label5";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(42, 266);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 21);
            this.label18.TabIndex = 13;
            this.label18.Text = "End Time:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(401, 38);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(64, 21);
            this.label17.TabIndex = 12;
            this.label17.Text = "Reason:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(598, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 42;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(542, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 41;
            this.label2.Text = "Logged in as:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 45);
            this.label1.TabIndex = 39;
            this.label1.Text = "Appointment View";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(9, 319);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 21);
            this.label10.TabIndex = 5;
            this.label10.Text = "Creation Date:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SchoolComboBox);
            this.panel1.Controls.Add(this.DescriptionTextBox);
            this.panel1.Controls.Add(this.UpdatedDate);
            this.panel1.Controls.Add(this.UpdatedBy);
            this.panel1.Controls.Add(this.CreatedBy);
            this.panel1.Controls.Add(this.CreateDate);
            this.panel1.Controls.Add(this.CounselorComboBox);
            this.panel1.Controls.Add(this.StudentName);
            this.panel1.Controls.Add(this.EndTime);
            this.panel1.Controls.Add(this.StartTime);
            this.panel1.Controls.Add(this.ReasonComboBox);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(9, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 376);
            this.panel1.TabIndex = 47;
            // 
            // SchoolComboBox
            // 
            this.SchoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SchoolComboBox.Enabled = false;
            this.SchoolComboBox.FormattingEnabled = true;
            this.SchoolComboBox.Location = new System.Drawing.Point(130, 40);
            this.SchoolComboBox.Name = "SchoolComboBox";
            this.SchoolComboBox.Size = new System.Drawing.Size(142, 23);
            this.SchoolComboBox.TabIndex = 2;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(29, 115);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(703, 115);
            this.DescriptionTextBox.TabIndex = 4;
            // 
            // UpdatedDate
            // 
            this.UpdatedDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.UpdatedDate.Enabled = false;
            this.UpdatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.UpdatedDate.Location = new System.Drawing.Point(506, 317);
            this.UpdatedDate.Name = "UpdatedDate";
            this.UpdatedDate.Size = new System.Drawing.Size(149, 23);
            this.UpdatedDate.TabIndex = 8;
            this.UpdatedDate.Value = new System.DateTime(2021, 6, 3, 15, 48, 40, 0);
            // 
            // UpdatedBy
            // 
            this.UpdatedBy.AutoSize = true;
            this.UpdatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UpdatedBy.Location = new System.Drawing.Point(506, 341);
            this.UpdatedBy.Name = "UpdatedBy";
            this.UpdatedBy.Size = new System.Drawing.Size(62, 21);
            this.UpdatedBy.TabIndex = 36;
            this.UpdatedBy.Text = "JJONES";
            // 
            // CreatedBy
            // 
            this.CreatedBy.AutoSize = true;
            this.CreatedBy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreatedBy.Location = new System.Drawing.Point(123, 341);
            this.CreatedBy.Name = "CreatedBy";
            this.CreatedBy.Size = new System.Drawing.Size(62, 21);
            this.CreatedBy.TabIndex = 35;
            this.CreatedBy.Text = "JJONES";
            // 
            // CreateDate
            // 
            this.CreateDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            this.CreateDate.Enabled = false;
            this.CreateDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CreateDate.Location = new System.Drawing.Point(123, 318);
            this.CreateDate.Name = "CreateDate";
            this.CreateDate.Size = new System.Drawing.Size(149, 23);
            this.CreateDate.TabIndex = 7;
            this.CreateDate.Value = new System.DateTime(2021, 6, 3, 15, 48, 40, 0);
            // 
            // CounselorComboBox
            // 
            this.CounselorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CounselorComboBox.FormattingEnabled = true;
            this.CounselorComboBox.Items.AddRange(new object[] {
            "Counseling",
            "Tutoring"});
            this.CounselorComboBox.Location = new System.Drawing.Point(471, 5);
            this.CounselorComboBox.Name = "CounselorComboBox";
            this.CounselorComboBox.Size = new System.Drawing.Size(250, 23);
            this.CounselorComboBox.TabIndex = 1;
            // 
            // StudentName
            // 
            this.StudentName.AutoSize = true;
            this.StudentName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StudentName.Location = new System.Drawing.Point(130, 5);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(106, 21);
            this.StudentName.TabIndex = 31;
            this.StudentName.Text = "Smith, John L.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(407, 341);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 21);
            this.label13.TabIndex = 8;
            this.label13.Text = "Updated By:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(396, 318);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Last Updated:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(29, 341);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 21);
            this.label11.TabIndex = 6;
            this.label11.Text = "Created By:";
            // 
            // CancelButton1
            // 
            this.CancelButton1.Location = new System.Drawing.Point(516, 526);
            this.CancelButton1.Name = "CancelButton1";
            this.CancelButton1.Size = new System.Drawing.Size(127, 23);
            this.CancelButton1.TabIndex = 10;
            this.CancelButton1.Text = "Cancel";
            this.CancelButton1.UseVisualStyleBackColor = true;
            this.CancelButton1.Click += new System.EventHandler(this.CancelButton1_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 526);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(127, 23);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete Appointment";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AppointmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TodayLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AppointmentView";
            this.Text = "AppointmentView";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.ComboBox ReasonComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label TodayLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CancelButton1;
        private System.Windows.Forms.ComboBox CounselorComboBox;
        private System.Windows.Forms.Label StudentName;
        private System.Windows.Forms.Label CreatedBy;
        private System.Windows.Forms.DateTimePicker CreateDate;
        private System.Windows.Forms.DateTimePicker UpdatedDate;
        private System.Windows.Forms.Label UpdatedBy;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.ComboBox SchoolComboBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}