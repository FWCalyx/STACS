
namespace LacosteC868Task
{
    partial class ReportView
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.SchoolComboBox = new System.Windows.Forms.ComboBox();
            this.CounselorComboBox = new System.Windows.Forms.ComboBox();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.radioAllAppts = new System.Windows.Forms.RadioButton();
            this.RadioCounselor = new System.Windows.Forms.RadioButton();
            this.RadioSchool = new System.Windows.Forms.RadioButton();
            this.ReportTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DashboardButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(652, 69);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(42, 20);
            this.TimeLabel.TabIndex = 31;
            this.TimeLabel.Text = "Time";
            // 
            // TodayLabel
            // 
            this.TodayLabel.AutoSize = true;
            this.TodayLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TodayLabel.Location = new System.Drawing.Point(652, 39);
            this.TodayLabel.Name = "TodayLabel";
            this.TodayLabel.Size = new System.Drawing.Size(49, 20);
            this.TodayLabel.TabIndex = 30;
            this.TodayLabel.Text = "Today";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UserNameLabel.Location = new System.Drawing.Point(652, 11);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(51, 20);
            this.UserNameLabel.TabIndex = 29;
            this.UserNameLabel.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(599, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(601, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(545, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "Logged in as:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 45);
            this.label1.TabIndex = 25;
            this.label1.Text = "Report View";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(13, 92);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.SchoolComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.CounselorComboBox);
            this.splitContainer1.Panel1.Controls.Add(this.GenerateButton);
            this.splitContainer1.Panel1.Controls.Add(this.radioAllAppts);
            this.splitContainer1.Panel1.Controls.Add(this.RadioCounselor);
            this.splitContainer1.Panel1.Controls.Add(this.RadioSchool);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ReportTitle);
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(759, 421);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 32;
            // 
            // SchoolComboBox
            // 
            this.SchoolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SchoolComboBox.FormattingEnabled = true;
            this.SchoolComboBox.Location = new System.Drawing.Point(30, 154);
            this.SchoolComboBox.Name = "SchoolComboBox";
            this.SchoolComboBox.Size = new System.Drawing.Size(173, 23);
            this.SchoolComboBox.TabIndex = 5;
            // 
            // CounselorComboBox
            // 
            this.CounselorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CounselorComboBox.FormattingEnabled = true;
            this.CounselorComboBox.Location = new System.Drawing.Point(30, 89);
            this.CounselorComboBox.Name = "CounselorComboBox";
            this.CounselorComboBox.Size = new System.Drawing.Size(173, 23);
            this.CounselorComboBox.TabIndex = 3;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(21, 380);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(127, 23);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Generate Report";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // radioAllAppts
            // 
            this.radioAllAppts.AutoSize = true;
            this.radioAllAppts.Checked = true;
            this.radioAllAppts.Location = new System.Drawing.Point(30, 38);
            this.radioAllAppts.Name = "radioAllAppts";
            this.radioAllAppts.Size = new System.Drawing.Size(118, 19);
            this.radioAllAppts.TabIndex = 1;
            this.radioAllAppts.TabStop = true;
            this.radioAllAppts.Text = "All Appointments";
            this.radioAllAppts.UseVisualStyleBackColor = true;
            // 
            // RadioCounselor
            // 
            this.RadioCounselor.AutoSize = true;
            this.RadioCounselor.Location = new System.Drawing.Point(30, 63);
            this.RadioCounselor.Name = "RadioCounselor";
            this.RadioCounselor.Size = new System.Drawing.Size(95, 19);
            this.RadioCounselor.TabIndex = 2;
            this.RadioCounselor.Text = "By Counselor";
            this.RadioCounselor.UseVisualStyleBackColor = true;
            this.RadioCounselor.CheckedChanged += new System.EventHandler(this.RadioCounselor_CheckedChanged);
            // 
            // RadioSchool
            // 
            this.RadioSchool.AutoSize = true;
            this.RadioSchool.Location = new System.Drawing.Point(30, 129);
            this.RadioSchool.Name = "RadioSchool";
            this.RadioSchool.Size = new System.Drawing.Size(77, 19);
            this.RadioSchool.TabIndex = 4;
            this.RadioSchool.Text = "By School";
            this.RadioSchool.UseVisualStyleBackColor = true;
            // 
            // ReportTitle
            // 
            this.ReportTitle.AutoSize = true;
            this.ReportTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReportTitle.Location = new System.Drawing.Point(14, 5);
            this.ReportTitle.Name = "ReportTitle";
            this.ReportTitle.Size = new System.Drawing.Size(177, 30);
            this.ReportTitle.TabIndex = 1;
            this.ReportTitle.Text = "Appointment List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(469, 365);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView1_CellFormatting);
            // 
            // DashboardButton
            // 
            this.DashboardButton.Location = new System.Drawing.Point(645, 526);
            this.DashboardButton.Name = "DashboardButton";
            this.DashboardButton.Size = new System.Drawing.Size(127, 23);
            this.DashboardButton.TabIndex = 7;
            this.DashboardButton.Text = "Dashboard";
            this.DashboardButton.UseVisualStyleBackColor = true;
            this.DashboardButton.Click += new System.EventHandler(this.DashboardButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Clock_Tick);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.DashboardButton);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.TodayLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button DashboardButton;
        private System.Windows.Forms.Label ReportTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton RadioCounselor;
        private System.Windows.Forms.RadioButton RadioSchool;
        private System.Windows.Forms.RadioButton radioAllAppts;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.ComboBox SchoolComboBox;
        private System.Windows.Forms.ComboBox CounselorComboBox;
    }
}