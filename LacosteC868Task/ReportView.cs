using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LacosteC868Task.Classes;

namespace LacosteC868Task
{
    public partial class ReportView : Form
    {
        readonly int UserID;
        readonly string Username;
        readonly DateTime Today = DateTime.Now;
        readonly StacsDB stacs = new();
        readonly BindingList<Appointment> AllAppointments = new();
        readonly BindingList<Student> AllStudents = new();
        readonly BindingList<Counselor> AllCounselors = new();
        readonly BindingList<School> AllSchools = new();
        readonly BindingList<Appointment> SelectedAppointments = new();
        Appointment CurrentAppointment;

        public ReportView()
        {
            InitializeComponent();
        }
        public ReportView(int id, string username)
        {
            InitializeComponent();
            UserID = id;
            Username = username;
            UserNameLabel.Text = Username;
            TodayLabel.Text = Today.ToShortDateString();
            try
            {
                stacs.FillAppointments(AllAppointments);
                stacs.FillCounselors(AllCounselors);
                stacs.FillStudents(AllStudents);
                stacs.FillSchools(AllSchools);
            }
            catch
            {
                MessageBox.Show("Unable to load data.");
            }
            dataGridView1.DataSource = AllAppointments;
            FillCounselorBox(CounselorComboBox, AllCounselors);
            FillSchoolBox(SchoolComboBox, AllSchools);
            FormatDGV(dataGridView1);

        }

        private static void FillCounselorBox(ComboBox combo, BindingList<Counselor> counselors)
        {
            combo.DataSource = counselors;
            combo.DisplayMember = "FullName";
            combo.ValueMember = "ID";
        }
        private static void FillSchoolBox(ComboBox combo, BindingList<School> schools)
        {
            combo.DataSource = schools;
            combo.DisplayMember = "Name";
            combo.ValueMember = "ID";
        }

        private void DataGridView1_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("SchoolID"))
            {
                int? SchoolID = e.Value as int?;

                foreach (School school in AllSchools)
                {
                    if (SchoolID == school.ID)
                    {
                        e.Value = $"{school.Name}";
                    }
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("CounselorID"))
            {
                int? CounselorID = e.Value as int?;
                foreach(Counselor counselor in AllCounselors)
                {
                    if (CounselorID == counselor.ID)
                    {
                        e.Value = $"{counselor.FullName}";
                    }
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name.Equals("StudentID"))
            {
                int? StudentID = e.Value as int?;
                foreach(Student student in AllStudents)
                {
                    if(StudentID == student.ID)
                    {
                        e.Value = $"{student.FullName}";
                    }
                }
            }
        }
        private static void FormatDGV(DataGridView dgv)
        {
            dgv.Columns["ID"].Visible = false;
            dgv.Columns["CounselorID"].Visible = true;
            dgv.Columns["StudentID"].Visible = true;
            dgv.Columns["Reason"].Visible = true;
            dgv.Columns["SchoolID"].Visible = true;
            dgv.Columns["Description"].Visible = false;
            dgv.Columns["Start"].Visible = true;
            dgv.Columns["CreateDate"].Visible = false;
            dgv.Columns["CreatedBy"].Visible = false;
            dgv.Columns["Updated"].Visible = false;
            dgv.Columns["UpdateBy"].Visible = false;
            dgv.Columns["CounselorID"].HeaderText = "Counselor";
            dgv.Columns["StudentID"].HeaderText = "Student";
            dgv.Columns["SchoolID"].HeaderText = "School";
            dgv.Columns["Start"].HeaderText = "Date";
            dgv.Columns["Start"].DisplayIndex = 0;
            dgv.Columns["StudentID"].DisplayIndex = 1;
            dgv.Columns["SchoolID"].DisplayIndex = 2;
            dgv.Columns["Reason"].DisplayIndex = 3;
            dgv.Columns["CounselorID"].DisplayIndex = 4;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            string time = "";
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            TimeLabel.Text = time;
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard Dash = new(UserID, Username);
            Dash.Show();
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            else
            {
                foreach (Appointment appointment in AllAppointments)
                {
                    if (appointment.ID.ToString() == dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        CurrentAppointment = appointment;
                        this.Hide();
                        AppointmentView AView = new(UserID, Username, CurrentAppointment);
                        AView.Show();
                    }
                }
            }
        }

        private void RadioCounselor_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioSchool_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void RadioAllAppointments_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (radioAllAppts.Checked == true)
            {
                SelectedAppointments.Clear();
                ReportTitle.Text = "REPORT: All Appointments";
                dataGridView1.DataSource = AllAppointments;
            }
            else if (RadioCounselor.Checked == true)
            {
                SelectedAppointments.Clear();
                foreach(Appointment appointment in AllAppointments)
                {
                    if (appointment.CounselorID == (int)CounselorComboBox.SelectedValue)
                    {
                        SelectedAppointments.Add(appointment);
                    }
                }
                dataGridView1.DataSource = SelectedAppointments;
                ReportTitle.Text = $"REPORT: Appointments for {CounselorComboBox.Text}";
            }
            else if (RadioSchool.Checked == true)
            {
                SelectedAppointments.Clear();
                foreach(Appointment appointment in AllAppointments)
                {
                    if (appointment.SchoolID == (int)SchoolComboBox.SelectedValue)
                    {
                        SelectedAppointments.Add(appointment);
                    }
                }
                dataGridView1.DataSource = SelectedAppointments;
                ReportTitle.Text = $"REPORT: Appointments for {SchoolComboBox.Text}";

            }
        }

    }
}
