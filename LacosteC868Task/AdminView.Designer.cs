
namespace LacosteC868Task
{
    partial class AdminView
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
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TodayLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.UserBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CounselorBox = new System.Windows.Forms.ComboBox();
            this.SchoolBox = new System.Windows.Forms.ComboBox();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.DeleteCounselorButton = new System.Windows.Forms.Button();
            this.EditCounselorButton = new System.Windows.Forms.Button();
            this.AddCounselorButton = new System.Windows.Forms.Button();
            this.DeleteSchoolButton = new System.Windows.Forms.Button();
            this.EditSchoolButton = new System.Windows.Forms.Button();
            this.AddSchoolButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(652, 69);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(42, 20);
            this.TimeLabel.TabIndex = 24;
            this.TimeLabel.Text = "Time";
            // 
            // TodayLabel
            // 
            this.TodayLabel.AutoSize = true;
            this.TodayLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TodayLabel.Location = new System.Drawing.Point(652, 39);
            this.TodayLabel.Name = "TodayLabel";
            this.TodayLabel.Size = new System.Drawing.Size(49, 20);
            this.TodayLabel.TabIndex = 23;
            this.TodayLabel.Text = "Today";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.Location = new System.Drawing.Point(652, 11);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(51, 20);
            this.UserNameLabel.TabIndex = 22;
            this.UserNameLabel.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(599, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(601, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(545, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "Logged in as:";
            // 
            // DashboardButton
            // 
            this.DashboardButton.Location = new System.Drawing.Point(645, 527);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(127, 23);
            this.DashboardButton.TabIndex = 13;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 45);
            this.label1.TabIndex = 17;
            this.label1.Text = "Administration";
            // 
            // UserBox
            // 
            this.UserBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.UserBox.FormattingEnabled = true;
            this.UserBox.Location = new System.Drawing.Point(29, 147);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(165, 255);
            this.UserBox.TabIndex = 1;
            this.UserBox.SelectedIndexChanged += new System.EventHandler(this.UserBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(78, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.TabIndex = 26;
            this.label5.Text = "Users";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(332, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 30);
            this.label6.TabIndex = 27;
            this.label6.Text = "Counselors";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(627, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 30);
            this.label7.TabIndex = 28;
            this.label7.Text = "Schools";
            // 
            // CounselorBox
            // 
            this.CounselorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.CounselorBox.FormattingEnabled = true;
            this.CounselorBox.Location = new System.Drawing.Point(309, 147);
            this.CounselorBox.Name = "CounselorBox";
            this.CounselorBox.Size = new System.Drawing.Size(165, 255);
            this.CounselorBox.TabIndex = 5;
            this.CounselorBox.SelectedIndexChanged += new System.EventHandler(this.CounselorBox_SelectedIndexChanged);
            // 
            // SchoolBox
            // 
            this.SchoolBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.SchoolBox.FormattingEnabled = true;
            this.SchoolBox.Location = new System.Drawing.Point(588, 147);
            this.SchoolBox.Name = "SchoolBox";
            this.SchoolBox.Size = new System.Drawing.Size(165, 255);
            this.SchoolBox.Sorted = true;
            this.SchoolBox.TabIndex = 9;
            this.SchoolBox.SelectedIndexChanged += new System.EventHandler(this.SchoolBox_SelectedIndexChanged);
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(50, 408);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(127, 23);
            this.AddUserButton.TabIndex = 2;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // EditUserButton
            // 
            this.EditUserButton.Enabled = false;
            this.EditUserButton.Location = new System.Drawing.Point(50, 437);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(127, 23);
            this.EditUserButton.TabIndex = 3;
            this.EditUserButton.Text = "Edit User";
            this.EditUserButton.UseVisualStyleBackColor = true;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Enabled = false;
            this.DeleteUserButton.Location = new System.Drawing.Point(50, 466);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(127, 23);
            this.DeleteUserButton.TabIndex = 4;
            this.DeleteUserButton.Text = "Delete User";
            this.DeleteUserButton.UseVisualStyleBackColor = true;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // DeleteCounselorButton
            // 
            this.DeleteCounselorButton.Enabled = false;
            this.DeleteCounselorButton.Location = new System.Drawing.Point(325, 466);
            this.DeleteCounselorButton.Name = "DeleteCounselorButton";
            this.DeleteCounselorButton.Size = new System.Drawing.Size(127, 23);
            this.DeleteCounselorButton.TabIndex = 8;
            this.DeleteCounselorButton.Text = "Delete Counselor";
            this.DeleteCounselorButton.UseVisualStyleBackColor = true;
            this.DeleteCounselorButton.Click += new System.EventHandler(this.DeleteCounselorButton_Click);
            // 
            // EditCounselorButton
            // 
            this.EditCounselorButton.Enabled = false;
            this.EditCounselorButton.Location = new System.Drawing.Point(325, 437);
            this.EditCounselorButton.Name = "EditCounselorButton";
            this.EditCounselorButton.Size = new System.Drawing.Size(127, 23);
            this.EditCounselorButton.TabIndex = 7;
            this.EditCounselorButton.Text = "Edit Counselor";
            this.EditCounselorButton.UseVisualStyleBackColor = true;
            this.EditCounselorButton.Click += new System.EventHandler(this.EditCounselorButton_Click);
            // 
            // AddCounselorButton
            // 
            this.AddCounselorButton.Location = new System.Drawing.Point(325, 408);
            this.AddCounselorButton.Name = "AddCounselorButton";
            this.AddCounselorButton.Size = new System.Drawing.Size(127, 23);
            this.AddCounselorButton.TabIndex = 6;
            this.AddCounselorButton.Text = "Add Counselor";
            this.AddCounselorButton.UseVisualStyleBackColor = true;
            this.AddCounselorButton.Click += new System.EventHandler(this.AddCounselorButton_Click);
            // 
            // DeleteSchoolButton
            // 
            this.DeleteSchoolButton.Enabled = false;
            this.DeleteSchoolButton.Location = new System.Drawing.Point(610, 466);
            this.DeleteSchoolButton.Name = "DeleteSchoolButton";
            this.DeleteSchoolButton.Size = new System.Drawing.Size(127, 23);
            this.DeleteSchoolButton.TabIndex = 12;
            this.DeleteSchoolButton.Text = "Delete School";
            this.DeleteSchoolButton.UseVisualStyleBackColor = true;
            this.DeleteSchoolButton.Click += new System.EventHandler(this.DeleteSchoolButton_Click);
            // 
            // EditSchoolButton
            // 
            this.EditSchoolButton.Enabled = false;
            this.EditSchoolButton.Location = new System.Drawing.Point(610, 437);
            this.EditSchoolButton.Name = "EditSchoolButton";
            this.EditSchoolButton.Size = new System.Drawing.Size(127, 23);
            this.EditSchoolButton.TabIndex = 11;
            this.EditSchoolButton.Text = "Edit School";
            this.EditSchoolButton.UseVisualStyleBackColor = true;
            this.EditSchoolButton.Click += new System.EventHandler(this.EditSchoolButton_Click);
            // 
            // AddSchoolButton
            // 
            this.AddSchoolButton.Location = new System.Drawing.Point(610, 408);
            this.AddSchoolButton.Name = "AddSchoolButton";
            this.AddSchoolButton.Size = new System.Drawing.Size(127, 23);
            this.AddSchoolButton.TabIndex = 10;
            this.AddSchoolButton.Text = "Add School";
            this.AddSchoolButton.UseVisualStyleBackColor = true;
            this.AddSchoolButton.Click += new System.EventHandler(this.AddSchoolButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.SchoolBox);
            this.Controls.Add(this.DeleteSchoolButton);
            this.Controls.Add(this.EditSchoolButton);
            this.Controls.Add(this.AddSchoolButton);
            this.Controls.Add(this.DeleteCounselorButton);
            this.Controls.Add(this.EditCounselorButton);
            this.Controls.Add(this.AddCounselorButton);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.CounselorBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserBox);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TodayLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label TodayLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox UserBox;
        private System.Windows.Forms.ComboBox CounselorBox;
        private System.Windows.Forms.ComboBox SchoolBox;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button DeleteCounselorButton;
        private System.Windows.Forms.Button EditCounselorButton;
        private System.Windows.Forms.Button AddCounselorButton;
        private System.Windows.Forms.Button DeleteSchoolButton;
        private System.Windows.Forms.Button EditSchoolButton;
        private System.Windows.Forms.Button AddSchoolButton;
        private System.Windows.Forms.Timer timer1;
    }
}