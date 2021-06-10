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
    public partial class Dashboard : Form
    {
        readonly int UserID;
        readonly int Serviced;
        readonly string Username;
        readonly DateTime Today = DateTime.Now;
        readonly StacsDB stacs = new();
        readonly BindingList<Student> AllStudents= new();
        readonly BindingList<Student> SelectedStudents = new();
        readonly BindingList<Appointment> AllAppointments = new();
        readonly BindingList<User> AllUsers = new();
        readonly BindingList<School> AllSchools = new();
        Student CurrentStudent;

        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(int userID, string username)
        {
            InitializeComponent();
            EditStudentButton.Enabled = false;
            DeleteStudentButton.Enabled = false;
            AdminButton.Enabled = false;
            UserID = userID;
            Username = username;
            UserNameLabel.Text = Username;
            TodayLabel.Text = Today.ToShortDateString();
            try
            {
                stacs.FillStudents(AllStudents);
                stacs.FillAppointments(AllAppointments);
                stacs.FillUsers(AllUsers);
                stacs.FillSchools(AllSchools);
            }
            catch
            {
                MessageBox.Show("Could not load data.");
            }
            dataGridView1.DataSource = AllStudents;
            TotalStudents.Text = AllStudents.Count.ToString();
            FormatDGV(dataGridView1);
            Serviced = ServiceCheck(AllStudents, AllAppointments);
            ServedStudents.Text = Serviced.ToString();
            PercStudents.Text = $"{PercentCalc(AllStudents.Count, Serviced)}%";
            AdminCheck(UserID);
        }
        private void AdminCheck (int userid)
        {
            foreach (User user in AllUsers)
            {
                if (user.ID == userid)
                {
                    if (user.Admin == true)
                    {
                        AdminButton.Enabled = true;
                    }
                }
            }
        }

        public static decimal PercentCalc(int count, int serviced)
        {
            if (count > 0)
            {
                decimal Perc = (serviced * 100) / count;
                return Perc;
            }
            else
            {
                return 0;
            }
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static int ServiceCheck(BindingList<Student> AllStudents, BindingList<Appointment> AllAppointments)
        {
            int countStudents = 0;
            foreach (Student student in AllStudents)
            {
                int counter = 0;
                foreach (Appointment appointment in AllAppointments)
                {
                    if (appointment.StudentID == student.ID && appointment.Start < DateTime.Now)
                    {
                        counter += 1;
                    }
                }
                if (counter > 0)
                {
                    countStudents += 1;
                }
            }
            return countStudents;
        }
        private void AddStudent_Click(object sender, EventArgs e)
        {
            this.Close();
            StudentView SView = new(UserID, Username);
            SView.Show();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string SearchString = SearchTextBox.Text.ToUpper();
            if(SearchString == "")
            {
                dataGridView1.DataSource = AllStudents;
                return;
            }
            else
            {
                StudentSearch(SearchString);
                dataGridView1.DataSource = SelectedStudents;
            }
        }

        private void StudentSearch(string search)
        {
            SelectedStudents.Clear();
            foreach (Student student in AllStudents)
            {
                if (student.LastName.ToUpper().Contains(search) || student.FirstName.ToUpper().Contains(search))
                {
                    SelectedStudents.Add(student);
                }
            }
            if (SelectedStudents.Count == 0)
            {
                MessageBox.Show("No students found.");
                return;
            }
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
        }
        private static void FormatDGV(DataGridView dgv)
        {

            dgv.Columns["LastName"].Visible = true;
            dgv.Columns["FirstName"].Visible = true;
            dgv.Columns["MiddleInitial"].Visible = true;
            dgv.Columns["SchoolID"].Visible = true;
            dgv.Columns["Eligibility"].Visible = true;
            dgv.Columns["Email"].Visible = true;
            dgv.Columns["Phone"].Visible = true;
            dgv.Columns["ID"].Visible = false;
            dgv.Columns["DOB"].Visible = false;
            dgv.Columns["Address"].Visible = false;
            dgv.Columns["Address2"].Visible = false;
            dgv.Columns["City"].Visible = false;
            dgv.Columns["State"].Visible = false;
            dgv.Columns["Zipcode"].Visible = false;
            dgv.Columns["SchoolID"].Visible = true;
            dgv.Columns["DateOfEntry"].Visible = false;
            dgv.Columns["FullName"].Visible = false;
            dgv.Columns["LastName"].HeaderText = "Last Name";
            dgv.Columns["FirstName"].HeaderText = "First Name";
            dgv.Columns["MiddleInitial"].HeaderText = "MI";
            dgv.Columns["SchoolID"].HeaderText = "School";
            dgv.Columns["MiddleInitial"].Width = 30;
            dgv.Columns["LastName"].DisplayIndex = 0;
            dgv.Columns["FirstName"].DisplayIndex = 1;
            dgv.Columns["MiddleInitial"].DisplayIndex = 2;
            dgv.Columns["SchoolID"].DisplayIndex = 3;
        }
        

        private void AdminButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminView AView = new(UserID, Username);
            AView.Show();
        }

        private void EditStudentButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StudentView SView = new(UserID, Username, CurrentStudent);
            SView.Show();
        }

        private void DeleteStudentButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"This will delete {CurrentStudent.FirstName} {CurrentStudent.LastName} and all associated appointments from the database! Are you sure?",
                   "Delete Student",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    stacs.DeleteStudent(CurrentStudent);
                    this.Close();
                    Dashboard Dash = new(UserID, Username);
                    Dash.Show();
                }
                catch
                {
                    MessageBox.Show("Could not delete the student.");
                    return;
                }
                
        }

        private void ReportsButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ReportView RView = new(UserID, Username);
            RView.Show();
        }



        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            else
            {
                foreach (Student student in AllStudents)
                {
                    if (student.ID.ToString() == dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString())
                    {
                        CurrentStudent = student;
                    }
                }
                AddAppointmentButton.Enabled = true;
                EditStudentButton.Enabled = true;
                DeleteStudentButton.Enabled = true;
            }
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

        private void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentView Appt = new(UserID, Username, CurrentStudent);
            Appt.Show();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            SelectedStudents.Clear();
            dataGridView1.DataSource = AllStudents;
            SearchTextBox.Text = "";
            return;
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string SearchString = SearchTextBox.Text.ToUpper();
                if (SearchString == "")
                {
                    dataGridView1.DataSource = AllStudents;
                    return;
                }
                else
                {
                    StudentSearch(SearchString);
                    dataGridView1.DataSource = SelectedStudents;
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                SelectedStudents.Clear();
                dataGridView1.DataSource = AllStudents;
                SearchTextBox.Text = "";
                return;
            }
        }
    }
}
