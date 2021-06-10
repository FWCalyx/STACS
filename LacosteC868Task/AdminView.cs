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
    public partial class AdminView : Form
    {
        readonly BindingList<Student> AllStudents = new();
        readonly BindingList<Appointment> AllAppointments = new();
        readonly BindingList<Counselor> AllCounselors = new();
        readonly BindingList<Counselor> NotNullCounselors = new();
        readonly BindingList<School> AllSchools = new();
        readonly BindingList<School> NotNullSchools = new();
        readonly BindingList<User> AllUsers = new();
        readonly StacsDB stacs = new();
        Counselor CurrentCounselor;
        School CurrentSchool;
        User CurrentUser;
        readonly int UserID;
        readonly string Username;
        readonly DateTime Today = DateTime.Now;

        public AdminView()
        {
            InitializeComponent();
        }
        public AdminView(int userID, string username)
        {
            InitializeComponent();
            stacs.FillCounselors(AllCounselors);
            stacs.FillUsers(AllUsers);
            stacs.FillSchools(AllSchools);
            stacs.FillAppointments(AllAppointments);
            FillUserBox(UserBox, AllUsers);
            FillCounselorBox(CounselorBox, AllCounselors, NotNullCounselors);
            FillSchoolBox(SchoolBox, AllSchools, NotNullSchools);
            UserID = userID;
            Username = username;
            UserNameLabel.Text = Username;
            TodayLabel.Text = Today.ToShortDateString();

        }

        private static void FillUserBox(ComboBox combo, BindingList<User> users)
        {
            combo.DataSource = users;
            combo.DisplayMember = "username";
            combo.ValueMember = "ID";
        }

        private static void FillCounselorBox(ComboBox combo, BindingList<Counselor> all, BindingList<Counselor> notnull)
        {
            foreach (Counselor counselor in all)
            {
                if (counselor.LastName != "NULL")
                {
                    notnull.Add(counselor);
                }
            }
            combo.DataSource = notnull;
            combo.DisplayMember = "FullName";
            combo.ValueMember = "ID";
        }

        private static void FillSchoolBox(ComboBox combo, BindingList<School> all, BindingList<School> notnull)
        {
            foreach(School school in all)
            {
                if (school.Name != "NULL")
                {
                    notnull.Add(school);
                }
            }
            combo.DataSource = notnull;
            combo.DisplayMember = "Name";
            combo.ValueMember = "ID";
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard Dash = new(UserID, Username);
            Dash.Show();
        }

        private void SchoolBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (School school in NotNullSchools)
            {
                if (school.ID.ToString() == SchoolBox.SelectedValue.ToString())
                {
                    CurrentSchool = school;
                    EditSchoolButton.Enabled = true;
                    DeleteSchoolButton.Enabled = true;
                }
            }
        }

        private void CounselorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Counselor counselor in NotNullCounselors)
            {
                if (counselor.ID.ToString() == CounselorBox.SelectedValue.ToString())
                {
                    CurrentCounselor = counselor;
                    EditCounselorButton.Enabled = true;
                    DeleteCounselorButton.Enabled = true;
                }
            }
        }

        private void UserBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (User user in AllUsers)
            {
                if (user.ID.ToString() == UserBox.SelectedValue.ToString())
                {
                    CurrentUser = user;
                    EditUserButton.Enabled = true;
                    DeleteUserButton.Enabled = true;
                }
            }
        }

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
            UserView UView = new(UserID, Username);
            UView.Show();
        }

        private void AddCounselorButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CounselorView CView = new(UserID, Username);
            CView.Show();
        }

        private void EditCounselorButton_Click(object sender, EventArgs e)
        {
            this.Close();
            CounselorView CView = new(UserID, Username, CurrentCounselor);
            CView.Show();
        }
        private void DeleteCounselorButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"This will delete {CurrentCounselor.FirstName} {CurrentCounselor.LastName} from the database and reassign all attached appointments to NULL! Are you sure?",
                   "Delete Counselor",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    foreach (Appointment appointment in AllAppointments)
                    {
                        if (appointment.CounselorID == CurrentCounselor.ID)
                        {
                            appointment.CounselorID = -1;
                            stacs.UpdateAppointment(appointment);
                        }
                    }
                    stacs.DeleteCounselor(CurrentCounselor);
                    this.Close();
                    AdminView AView = new(UserID, Username);
                    AView.Show();
                }
                catch
                {
                    MessageBox.Show("Could not delete the counselor.");
                    return;
                }
            }
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            this.Close();
            UserView UView = new(UserID, Username, CurrentUser);
            UView.Show();
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

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"This will delete {CurrentUser.UserName} from the database! Are you sure?",
                   "Delete User",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (CurrentUser.ID == UserID)
                {
                    MessageBox.Show("Cannot delete username while in use.");
                    return;
                }
                else
                {
                    try
                    {
                        stacs.DeleteUser(CurrentUser);
                        this.Close();
                        AdminView AView = new(UserID, Username);
                        AView.Show();
                    }
                    catch
                    {
                        MessageBox.Show("Could not delete the user.");
                        return;
                    }
                }
            } 
        }

        private void AddSchoolButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SchoolView SView = new(UserID, Username);
            SView.Show();
        }

        private void EditSchoolButton_Click(object sender, EventArgs e)
        {
            this.Close();
            SchoolView SView = new(UserID, Username, CurrentSchool);
            SView.Show();
        }

        private void DeleteSchoolButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"This will delete {CurrentSchool.Name} from the database and set school for all its students to NULL! Are you sure?",
                   "Delete School",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
            try
            {
                    foreach(Student student in AllStudents)
                    {
                        if (student.SchoolID == CurrentSchool.ID)
                        {
                            student.SchoolID = -1;
                            stacs.UpdateStudent(student);
                        }
                    }
                    foreach (Appointment appointment in AllAppointments)
                    {
                        if (appointment.SchoolID == CurrentSchool.ID)
                        {
                            appointment.SchoolID = -1;
                            stacs.UpdateAppointment(appointment);
                        }
                    }
                    stacs.DeleteSchool(CurrentSchool);
                    this.Close();
                    AdminView AView = new(UserID, Username);
                    AView.Show();
            }
            catch
            {
                MessageBox.Show("Could not delete the school.");
                return;
            }
        }
        }
    }
}
