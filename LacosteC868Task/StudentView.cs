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
    public partial class StudentView : Form
    {
        readonly int UserID;
        readonly string Username;
        readonly DateTime Today = DateTime.Now;
        readonly Student transfer;
        Appointment CurrentAppointment;
        readonly TimeSpan Barrier = new (4748, 0, 0, 0);
        readonly StacsDB stacs = new();
        readonly BindingList<School> AllSchools = new();
        readonly BindingList<School> NotNullSchools = new();
        readonly BindingList<Appointment> AllAppointments = new();
        readonly BindingList<Appointment> PastAppointments = new();
        readonly BindingList<Appointment> FutureAppointments = new();
        public StudentView()
        {
            InitializeComponent();
        }
        public StudentView(int userID, string userName)
        {
            InitializeComponent();
            UserID = userID;
            Username = userName;
            UserNameLabel.Text = Username;
            TodayLabel.Text = Today.ToShortDateString();
            stacs.FillSchools(AllSchools);
            SchoolSelect(AllSchools, NotNullSchools);
            FillComboBox(SchoolComboBox, NotNullSchools);
            DOBPicker.Value = DateTime.Today;
            DOEPicker.Value = DateTime.Today;
            UpdateButton.Enabled = false;
            UpdateButton.Visible = false;
            SaveButton.Enabled = true;
            SaveButton.Visible = true;
            AddAppointmentButton.Enabled = false;
        }

        public StudentView(int userID, string userName, Student exists)
        {
            InitializeComponent();
            UserID = userID;
            Username = userName;
            UserNameLabel.Text = Username;
            TodayLabel.Text = Today.ToShortDateString();
            stacs.FillSchools(AllSchools);
            stacs.FillAppointments(AllAppointments);
            SchoolSelect(AllSchools, NotNullSchools);
            FillComboBox(SchoolComboBox, NotNullSchools);
            transfer = exists;
            StudentPopulate(transfer);
            UpdateButton.Enabled = true;
            UpdateButton.Visible = true;
            SaveButton.Enabled = false;
            SaveButton.Visible = false;
            AddAppointmentButton.Enabled = true;
            TooltipHandle.Enabled = false;
        }

        private static void SchoolSelect(BindingList<School> all, BindingList<School> notnull)
        {
            foreach(School school in all)
            {
                if (school.Name != "NULL")
                {
                    notnull.Add(school);
                }
            }
        }
        private void StudentPopulate(Student transfer)
        {
            LastNameTextBox.Text = transfer.LastName;
            FirstNameTextBox.Text = transfer.FirstName;
            MiddleInitialTextBox.Text = transfer.MiddleInitial;
            DOBPicker.Value = transfer.DOB.Date;
            EligComboBox.SelectedItem = transfer.Eligibility;
            AddressTextBox.Text = transfer.Address;
            Address2TextBox.Text = transfer.Address2;
            CityTextBox.Text = transfer.City;
            StateTextBox.Text = transfer.State;
            ZipCodeTextBox.Text = transfer.Zipcode;
            EmailTextBox.Text = transfer.Email;
            PhoneTextBox.Text = transfer.Phone;
            DOEPicker.Value = transfer.DateOfEntry.Date;
            SchoolComboBox.SelectedValue = transfer.SchoolID;
            foreach(Appointment appt in AllAppointments)
            {
                if (appt.StudentID == transfer.ID && appt.Start < DateTime.Now)
                {
                    PastAppointments.Add(appt);
                }
                else if (appt.StudentID == transfer.ID && appt.Start > DateTime.Now)
                {
                    FutureAppointments.Add(appt);
                }
            }
            PastApptDGV.DataSource = PastAppointments;
            FutureApptDGV.DataSource = FutureAppointments;
            FormatDGV(PastApptDGV);
            FormatDGV(FutureApptDGV);
        }

        private static void FormatDGV(DataGridView dgv)
        {
            dgv.Columns["ID"].Visible = false;
            dgv.Columns["CounselorID"].Visible = false;
            dgv.Columns["StudentID"].Visible = false;
            dgv.Columns["Reason"].Visible = true;
            dgv.Columns["SchoolID"].Visible = false;
            dgv.Columns["Description"].Visible = false;
            dgv.Columns["Start"].Visible = true;
            dgv.Columns["End"].Visible = false;
            dgv.Columns["CreateDate"].Visible = false;
            dgv.Columns["CreatedBy"].Visible = false;
            dgv.Columns["Updated"].Visible = false;
            dgv.Columns["UpdateBy"].Visible = false;
            dgv.Columns["Start"].DisplayIndex = 0;
            dgv.Columns["Start"].HeaderText = "Appointment";
            dgv.Columns["Start"].Width = 150;
            dgv.Columns["Reason"].DisplayIndex = 1;
            dgv.Columns["Reason"].HeaderText = "Reason for Meeting";
            dgv.Columns["Reason"].Width = 205;

        }

        public void AddAppointmentButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AppointmentView Appt = new(UserID, Username, transfer);
            Appt.Show();
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (LastNameTextBox.Text == "")
            {
                MessageBox.Show("Last name cannot be blank.");
                return;
            }
            else if (FirstNameTextBox.Text == "")
            {
                MessageBox.Show("First name cannot be blank.");
                return;
            }
            else if (DOBPicker.Value > (DateTime.Now - Barrier))
            {
                MessageBox.Show("Student must be at least 13 years old.");
                return;
            }
            else if (EligComboBox.Text == "")
            {
                MessageBox.Show("Eligibility must be selected.");
                return;
            }
            else if (AddressTextBox.Text == "")
            {
                MessageBox.Show("Address cannot be blank.");
                return;
            }
            else if (CityTextBox.Text == "")
            {
                MessageBox.Show("City cannot be blank.");
                return;
            }
            else if (StateTextBox.Text == "")
            {
                MessageBox.Show("State cannot be blank.");
                return;
            }
            else if (ZipCodeTextBox.Text == "")
            {
                MessageBox.Show("Zip Code cannot be blank.");
                return;
            }
            else if (EmailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be blank.");
                return;
            }
            else if (EmailCheck.IsValidEmail(EmailTextBox.Text) == false)
            {
                MessageBox.Show("Email must be valid.");
                return;
            }
            else if (PhoneTextBox.Text == "")
            {
                MessageBox.Show("Phone cannot be blank.");
                return;
            }
            else if (SchoolComboBox.Text == "")
            {
                MessageBox.Show("School cannot be blank.");
                return;
            }
            else
            {
                Student NewStudent = new(
                       transfer.ID,
                       LastNameTextBox.Text,
                       FirstNameTextBox.Text,
                       MiddleInitialTextBox.Text,
                       DOBPicker.Value.Date,
                       EmailTextBox.Text,
                       PhoneTextBox.Text,
                       AddressTextBox.Text,
                       Address2TextBox.Text,
                       CityTextBox.Text,
                       StateTextBox.Text,
                       ZipCodeTextBox.Text,
                       EligComboBox.Text,
                       (int)SchoolComboBox.SelectedValue,
                       DOEPicker.Value.Date);
                try
                {
                    stacs.UpdateStudent(NewStudent);
                    this.Close();
                    Dashboard Dash = new(UserID, Username);
                    Dash.Show();

                }
                catch
                {
                    MessageBox.Show("An error occurred. Please try again.");
                    return;
                }
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(LastNameTextBox.Text == "")
            {
                MessageBox.Show("Last name cannot be blank.");
                return;
            }
            else if (FirstNameTextBox.Text == "")
            {
                MessageBox.Show("First name cannot be blank.");
                return;
            }
            else if (DOBPicker.Value > (DateTime.Now - Barrier))
            {
                MessageBox.Show("Student must be at least 13 years old.");
                return;
            }
            else if (EligComboBox.Text == "")
            {
                MessageBox.Show("Eligibility must be selected.");
                return;
            }
            else if (AddressTextBox.Text == "")
            {
                MessageBox.Show("Address cannot be blank.");
                return;
            }
            else if (CityTextBox.Text == "")
            {
                MessageBox.Show("City cannot be blank.");
                return;
            }
            else if (StateTextBox.Text == "")
            {
                MessageBox.Show("State cannot be blank.");
                return;
            }
            else if (ZipCodeTextBox.Text == "")
            {
                MessageBox.Show("Zip Code cannot be blank.");
                return;
            }
            else if (EmailTextBox.Text == "")
            {
                MessageBox.Show("Email cannot be blank.");
                return;
            }
            else if (EmailCheck.IsValidEmail(EmailTextBox.Text) == false)
            {
                MessageBox.Show("Email must be valid.");
                return;
            }
            else if (PhoneTextBox.Text == "")
            {
                MessageBox.Show("Phone cannot be blank.");
                return;
            }
            else if (SchoolComboBox.Text == "")
            {
                MessageBox.Show("School cannot be blank.");
                return;
            }
            else
            {
                Student NewStudent = new(
                       0,
                       LastNameTextBox.Text,
                       FirstNameTextBox.Text,
                       MiddleInitialTextBox.Text,
                       DOBPicker.Value.Date,
                       EmailTextBox.Text,
                       PhoneTextBox.Text,
                       AddressTextBox.Text,
                       Address2TextBox.Text,
                       CityTextBox.Text,
                       StateTextBox.Text,
                       ZipCodeTextBox.Text,
                       EligComboBox.Text,
                       (int)SchoolComboBox.SelectedValue,
                       DOEPicker.Value.Date);
                try
                {
                    stacs.AddStudent(NewStudent);
                    this.Close();
                    Dashboard Dash = new(UserID, Username);
                    Dash.Show();

                }
                catch
                {
                    MessageBox.Show("Unable to add student.");
                    return;
                }
            }
        }
        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45 && ch != 40 && ch != 41)
            {
                e.Handled = true;
            }
        }
        private static void FillComboBox(ComboBox combo, BindingList<School> schools)
        {
                combo.DataSource = schools;
                combo.DisplayMember = "Name";
                combo.ValueMember = "ID";
        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard Dash = new (UserID, Username);
            Dash.Show();
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

        private void TooltipHandle_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(TooltipHandle, "You must add the student to the STACS database prior to adding an appointment.");
        }

        private void PastApptDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            else
            {
                foreach (Appointment appointment in PastAppointments)
                {
                    if (appointment.ID.ToString() == PastApptDGV.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        CurrentAppointment = appointment;
                        this.Hide();
                        AppointmentView AView = new(UserID, Username, CurrentAppointment);
                        AView.Show();
                    }
                }
            }
        }
        private void FutureApptDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) { return; }
            else
            {
                foreach (Appointment appointment in FutureAppointments)
                {
                    if (appointment.ID.ToString() == FutureApptDGV.Rows[e.RowIndex].Cells[0].Value.ToString())
                    {
                        CurrentAppointment = appointment;
                        this.Hide();
                        AppointmentView AView = new(UserID, Username, CurrentAppointment);
                        AView.Show();
                    }
                }
            }
        }
    }
}
