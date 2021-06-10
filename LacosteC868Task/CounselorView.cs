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
    public partial class CounselorView : Form
    {
        readonly int UserID;
        readonly string Username;
        readonly DateTime Today = DateTime.Now;
        readonly StacsDB stacs = new();
        readonly Counselor transfer;
        Appointment CurrentAppointment;
        readonly TimeSpan Barrier = new(7667, 0, 0, 0);
        readonly BindingList<Appointment> AllAppointments = new();
        readonly BindingList<Appointment> PastAppointments = new();
        readonly BindingList<Appointment> FutureAppointments = new();
        public CounselorView()
        {
            InitializeComponent();
        }

        public CounselorView(int userid, string username)
        {
            InitializeComponent();
            UserID = userid;
            Username = username;
            UserNameLabel.Text = Username;
            TodayLabel.Text = Today.ToShortDateString();
            UpdateButton.Enabled = false;
            UpdateButton.Visible = false;
            SaveButton.Enabled = true;
            SaveButton.Visible = true;
        }
        public CounselorView(int userid, string username, Counselor exists)
        {
            InitializeComponent();
            UserID = userid;
            Username = username;
            UserNameLabel.Text = Username;
            TodayLabel.Text = Today.ToShortDateString();
            transfer = exists;
            try
            {
                stacs.FillAppointments(AllAppointments);
            }
            catch
            {
                MessageBox.Show("Could not load appointments.");
            }
            CounselorPopulate(transfer);
            UpdateButton.Enabled = true;
            UpdateButton.Visible = true;
            SaveButton.Enabled = false;
            SaveButton.Visible = false;
        }
        private void CounselorPopulate(Counselor transfer)
        {
            LastNameTextBox.Text = transfer.LastName;
            FirstNameTextBox.Text = transfer.FirstName;
            MiddleInitialTextBox.Text = transfer.MiddleInitial;
            DOBPicker.Value = transfer.DOB.Date;
            TitleComboBox.SelectedItem = transfer.Title;
            AddressTextBox.Text = transfer.Address;
            Address2TextBox.Text = transfer.Address2;
            CityTextBox.Text = transfer.City;
            StateTextBox.Text = transfer.State;
            ZipCodeTextBox.Text = transfer.Zipcode;
            EmailTextBox.Text = transfer.Email;
            PhoneTextBox.Text = transfer.Phone;
            DOHPicker.Value = transfer.DateOfHire.Date;
            foreach (Appointment appt in AllAppointments)
            {
                if (appt.CounselorID == transfer.ID && appt.Start < DateTime.Now)
                {
                    PastAppointments.Add(appt);
                }
                else if (appt.CounselorID == transfer.ID && appt.Start > DateTime.Now)
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
                MessageBox.Show("Counselor must be at least 21 years old.");
                return;
            }
            else if (TitleComboBox.Text == "")
            {
                MessageBox.Show("Title must be selected.");
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
            else if (DOHPicker.Value > DateTime.Now)
            {
                MessageBox.Show("Hire date must be in the past.");
                return;
            }
            else
            {
                Counselor NewCounselor = new(
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
                       TitleComboBox.Text,
                       DOHPicker.Value.Date);
                try
                {
                    stacs.UpdateCounselor(NewCounselor);
                    this.Close();
                    AdminView AView = new(UserID, Username);
                    AView.Show();

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
                MessageBox.Show("Counselor must be at least 21 years old.");
                return;
            }
            else if (TitleComboBox.Text == "")
            {
                MessageBox.Show("Title must be selected.");
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
            else if (DOHPicker.Value > DateTime.Now)
            {
                MessageBox.Show("Hire date must be in the past.");
                return;
            }
            else
            {
                Counselor NewCounselor = new(
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
                       TitleComboBox.Text,
                       DOHPicker.Value.Date);
                try
                {
                    stacs.AddCounselor(NewCounselor);
                    this.Close();
                    AdminView AView = new(UserID, Username);
                    AView.Show();

                }
                catch
                {
                    MessageBox.Show("Unable to add counselor.");
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

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminView AView = new(UserID, Username);
            AView.Show();
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
    }


}
