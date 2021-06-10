
namespace LacosteC868Task
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.SearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddStudentButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.TodayLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ReportsButton = new System.Windows.Forms.Button();
            this.AdminButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalStudents = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ServedStudents = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PercStudents = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EditStudentButton = new System.Windows.Forms.Button();
            this.DeleteStudentButton = new System.Windows.Forms.Button();
            this.AddAppointmentButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "Dashboard";
            // 
            // SearchTextBox
            // 
            this.SearchTextBox.Location = new System.Drawing.Point(12, 68);
            this.SearchTextBox.Name = "SearchTextBox";
            this.SearchTextBox.Size = new System.Drawing.Size(452, 23);
            this.SearchTextBox.TabIndex = 1;
            this.SearchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(499, 68);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(52, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(538, 365);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // AddStudentButton
            // 
            this.AddStudentButton.Location = new System.Drawing.Point(13, 468);
            this.AddStudentButton.Name = "AddStudentButton";
            this.AddStudentButton.Size = new System.Drawing.Size(127, 23);
            this.AddStudentButton.TabIndex = 5;
            this.AddStudentButton.Text = "Add Student";
            this.AddStudentButton.UseVisualStyleBackColor = true;
            this.AddStudentButton.Click += new System.EventHandler(this.AddStudent_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(645, 526);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(127, 23);
            this.ExitButton.TabIndex = 11;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(545, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "Logged in as:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(601, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(599, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Time:";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.Location = new System.Drawing.Point(652, 10);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(51, 20);
            this.UserNameLabel.TabIndex = 14;
            this.UserNameLabel.Text = "label5";
            // 
            // TodayLabel
            // 
            this.TodayLabel.AutoSize = true;
            this.TodayLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TodayLabel.Location = new System.Drawing.Point(652, 38);
            this.TodayLabel.Name = "TodayLabel";
            this.TodayLabel.Size = new System.Drawing.Size(49, 20);
            this.TodayLabel.TabIndex = 15;
            this.TodayLabel.Text = "Today";
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(652, 68);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(42, 20);
            this.TimeLabel.TabIndex = 16;
            this.TimeLabel.Text = "Time";
            // 
            // ReportsButton
            // 
            this.ReportsButton.Location = new System.Drawing.Point(645, 497);
            this.ReportsButton.Name = "ReportsButton";
            this.ReportsButton.Size = new System.Drawing.Size(127, 23);
            this.ReportsButton.TabIndex = 10;
            this.ReportsButton.Text = "Reports";
            this.ReportsButton.UseVisualStyleBackColor = true;
            this.ReportsButton.Click += new System.EventHandler(this.ReportsButton_Click);
            // 
            // AdminButton
            // 
            this.AdminButton.Location = new System.Drawing.Point(645, 468);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(127, 23);
            this.AdminButton.TabIndex = 9;
            this.AdminButton.Text = "Admin";
            this.AdminButton.UseVisualStyleBackColor = true;
            this.AdminButton.Click += new System.EventHandler(this.AdminButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(567, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Students in Project:";
            // 
            // TotalStudents
            // 
            this.TotalStudents.AutoSize = true;
            this.TotalStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalStudents.Location = new System.Drawing.Point(719, 128);
            this.TotalStudents.Name = "TotalStudents";
            this.TotalStudents.Size = new System.Drawing.Size(19, 21);
            this.TotalStudents.TabIndex = 20;
            this.TotalStudents.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(584, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 21);
            this.label7.TabIndex = 21;
            this.label7.Text = "Students Served:";
            // 
            // ServedStudents
            // 
            this.ServedStudents.AutoSize = true;
            this.ServedStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServedStudents.Location = new System.Drawing.Point(719, 177);
            this.ServedStudents.Name = "ServedStudents";
            this.ServedStudents.Size = new System.Drawing.Size(19, 21);
            this.ServedStudents.TabIndex = 22;
            this.ServedStudents.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(568, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Percentage Served:";
            // 
            // PercStudents
            // 
            this.PercStudents.AutoSize = true;
            this.PercStudents.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PercStudents.Location = new System.Drawing.Point(719, 226);
            this.PercStudents.Name = "PercStudents";
            this.PercStudents.Size = new System.Drawing.Size(19, 21);
            this.PercStudents.TabIndex = 24;
            this.PercStudents.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // EditStudentButton
            // 
            this.EditStudentButton.Enabled = false;
            this.EditStudentButton.Location = new System.Drawing.Point(424, 498);
            this.EditStudentButton.Name = "EditStudentButton";
            this.EditStudentButton.Size = new System.Drawing.Size(127, 23);
            this.EditStudentButton.TabIndex = 7;
            this.EditStudentButton.Text = "Edit Student";
            this.EditStudentButton.UseVisualStyleBackColor = true;
            this.EditStudentButton.Click += new System.EventHandler(this.EditStudentButton_Click);
            // 
            // DeleteStudentButton
            // 
            this.DeleteStudentButton.Enabled = false;
            this.DeleteStudentButton.Location = new System.Drawing.Point(424, 526);
            this.DeleteStudentButton.Name = "DeleteStudentButton";
            this.DeleteStudentButton.Size = new System.Drawing.Size(127, 23);
            this.DeleteStudentButton.TabIndex = 8;
            this.DeleteStudentButton.Text = "Delete Student";
            this.DeleteStudentButton.UseVisualStyleBackColor = true;
            this.DeleteStudentButton.Click += new System.EventHandler(this.DeleteStudentButton_Click);
            // 
            // AddAppointmentButton
            // 
            this.AddAppointmentButton.Enabled = false;
            this.AddAppointmentButton.Location = new System.Drawing.Point(424, 468);
            this.AddAppointmentButton.Name = "AddAppointmentButton";
            this.AddAppointmentButton.Size = new System.Drawing.Size(127, 23);
            this.AddAppointmentButton.TabIndex = 6;
            this.AddAppointmentButton.Text = "Add Appointment";
            this.AddAppointmentButton.UseVisualStyleBackColor = true;
            this.AddAppointmentButton.Click += new System.EventHandler(this.AddAppointmentButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Location = new System.Drawing.Point(473, 69);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(20, 23);
            this.ResetButton.TabIndex = 2;
            this.ResetButton.Text = "X";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.AddAppointmentButton);
            this.Controls.Add(this.DeleteStudentButton);
            this.Controls.Add(this.EditStudentButton);
            this.Controls.Add(this.PercStudents);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ServedStudents);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TotalStudents);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdminButton);
            this.Controls.Add(this.ReportsButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TodayLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.AddStudentButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddStudentButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label TodayLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Button ReportsButton;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TotalStudents;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ServedStudents;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label PercStudents;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button EditStudentButton;
        private System.Windows.Forms.Button DeleteStudentButton;
        private System.Windows.Forms.Button AddAppointmentButton;
        private System.Windows.Forms.Button ResetButton;
    }
}