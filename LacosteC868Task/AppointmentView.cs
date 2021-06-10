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
    public partial class AppointmentView : Form
    {
        readonly int UserID;
        readonly string Username;
        readonly DateTime Today = DateTime.Now;
        readonly BindingList<Counselor> AllCounselors = new();
        readonly BindingList<Counselor> NotNullCounselors = new();
        readonly BindingList<School> AllSchools = new();
        readonly BindingList<Student> AllStudents = new();
        readonly BindingList<Appointment> AllAppointments = new();
        readonly StacsDB stacs = new();
        readonly Appointment transfer;
        Student stu1;
        public AppointmentView()
        {
            InitializeComponent();
        }
        public AppointmentView(int userid, string username, Student chosen)
        {
            InitializeComponent();
            stacs.FillStudents(AllStudents);
            stacs.FillSchools(AllSchools);
            stacs.FillCounselors(AllCounselors);
            stacs.FillAppointments(AllAppointments);
            UserID = userid;
            Username = username;
            UserNameLabel.Text = Username;
            stu1 = chosen;
            TodayLabel.Text = Today.ToShortDateString();
            CounselorSelect(AllCounselors, NotNullCounselors);
            FillCounselorBox(CounselorComboBox, NotNullCounselors);
            FillSchoolBox(SchoolComboBox, AllSchools);
            PopulateAppointment();
            UpdateButton.Visible = false;
            UpdateButton.Enabled = false;
            SaveButton.Visible = true;
            SaveButton.Enabled = true;
            DeleteButton.Enabled = false;
            

        }
        public AppointmentView(int userid, string username, Appointment exists)
        {
            InitializeComponent();
            stacs.FillStudents(AllStudents);
            stacs.FillSchools(AllSchools);
            stacs.FillCounselors(AllCounselors);
            stacs.FillAppointments(AllAppointments);
            UserID = userid;
            Username = username;
            UserNameLabel.Text = Username;
            TodayLabel.Text = Today.ToShortDateString();
            CounselorSelect(AllCounselors, NotNullCounselors);
            FillCounselorBox(CounselorComboBox, NotNullCounselors);
            FillSchoolBox(SchoolComboBox, AllSchools);
            transfer = exists;
            PopulateAppointment(transfer);
            UpdateButton.Visible = true;
            UpdateButton.Enabled = true;
            SaveButton.Visible = false;
            SaveButton.Enabled = false;
            DeleteButton.Enabled = true;
        }

        private void PopulateAppointment()
        {
            StudentName.Text = $"{stu1.LastName}, {stu1.FirstName}";
            SchoolComboBox.SelectedValue = stu1.SchoolID;
            CreateDate.Value = DateTime.Now;
            CreatedBy.Text = Username;
            StartTime.Value = DateTime.Now;
            EndTime.Value = DateTime.Now;
            UpdatedDate.Value = DateTime.Now;
            UpdatedBy.Text = Username;
        }
        private void PopulateAppointment(Appointment transfer)
        {

            foreach (Student student in AllStudents)
            {
                if (student.ID == transfer.StudentID)
                {
                    stu1 = student;
                }
            }
            StudentName.Text = $"{stu1.LastName}, {stu1.FirstName}";
            SchoolComboBox.SelectedValue = stu1.SchoolID;
            CounselorComboBox.SelectedValue = transfer.CounselorID;
            ReasonComboBox.SelectedItem = transfer.Reason;
            DescriptionTextBox.Text = transfer.Description;
            StartTime.Value = transfer.Start;
            EndTime.Value = transfer.End;
            CreateDate.Value = transfer.CreateDate;
            CreatedBy.Text = transfer.CreatedBy;
            UpdatedDate.Value = transfer.Updated;
            UpdatedBy.Text = transfer.UpdateBy;
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

        private static void CounselorSelect(BindingList<Counselor> all, BindingList<Counselor> notnull)
        {
            foreach (Counselor counselor in all)
            {
                if (counselor.LastName != "NULL")
                {
                    notnull.Add(counselor);
                }
            }
        }
        private void CancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Dashboard Dash = new(UserID, Username);
            Dash.Show();
        }
        private void AppointmentCheck(DateTime Start, DateTime End, int CounselID, int studentID)
        {
            foreach (Appointment appointment in AllAppointments)
            {
                if (appointment.CounselorID == CounselID)
                {
                    if (Start.Day == appointment.Start.Day &&
                        Start.Hour >= appointment.Start.Hour &&
                        Start.Minute >= appointment.Start.Minute &&
                        Start.TimeOfDay < appointment.End.TimeOfDay)
                    {
                        throw new InvalidAppointmentOverlap("Counselor");
                    }
                    else if (End.Day == appointment.Start.Day &&
                             End.Hour >= appointment.Start.Hour &&
                             End.Minute >= appointment.Start.Minute &&
                             End.TimeOfDay < appointment.End.TimeOfDay)
                    {
                        throw new InvalidAppointmentOverlap("Counselor");
                    }
                            
                }
                else if (appointment.StudentID == studentID)
                {
                    if (Start.Day == appointment.Start.Day &&
                        Start.Hour >= appointment.Start.Hour &&
                        Start.Minute >= appointment.Start.Minute &&
                        Start.TimeOfDay < appointment.End.TimeOfDay)
                    {
                        throw new InvalidAppointmentOverlap("Student");
                    }
                    else if (End.Day == appointment.Start.Day &&
                             End.Hour >= appointment.Start.Hour &&
                             End.Minute >= appointment.Start.Minute &&
                             End.TimeOfDay < appointment.End.TimeOfDay)
                    {
                        throw new InvalidAppointmentOverlap("Student");
                    }
                }
            }

        }
        private void AppointmentCheck(DateTime Start, DateTime End, int CounselID, int studentID, int appointmentID)
        {
            foreach (Appointment appointment in AllAppointments)
            {
                if (appointment.CounselorID == CounselID)
                {
                    if (Start.Day == appointment.Start.Day &&
                    Start.Hour >= appointment.Start.Hour &&
                    Start.Minute >= appointment.Start.Minute &&
                    Start.TimeOfDay < appointment.End.TimeOfDay &&
                    appointment.ID != appointmentID)
                    {
                        throw new InvalidAppointmentOverlap("Counselor");
                    }
                    else if (End.Day == appointment.Start.Day &&
                                End.Hour >= appointment.Start.Hour &&
                                End.Minute >= appointment.Start.Minute &&
                                End.TimeOfDay < appointment.End.TimeOfDay &&
                                appointment.ID != appointmentID)
                    {
                        throw new InvalidAppointmentOverlap("Counselor");
                    }
                }
                else if (appointment.StudentID == studentID)
                {
                    if (Start.Day == appointment.Start.Day &&
                         Start.Hour >= appointment.Start.Hour &&
                         Start.Minute >= appointment.Start.Minute &&
                         Start.TimeOfDay < appointment.End.TimeOfDay &&
                         appointment.ID != appointmentID)
                    {
                        throw new InvalidAppointmentOverlap("Student");
                    }
                    else if (End.Day == appointment.Start.Day &&
                             End.Hour >= appointment.Start.Hour &&
                             End.Minute >= appointment.Start.Minute &&
                             End.TimeOfDay < appointment.End.TimeOfDay &&
                             appointment.ID != appointmentID)
                    {
                        throw new InvalidAppointmentOverlap("Student");
                    }

                }
                
            }

        }
        private static void StartEndValidate(DateTime Start, DateTime End)
        {
            if (Start > End)
            {
                throw new StartAfterEndTimeException();
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CounselorComboBox.Text == "")
            {
                MessageBox.Show("Counselor cannot be blank.");
                return;
            }
            else if (ReasonComboBox.Text == "")
            {
                MessageBox.Show("Reason for appointment cannot be blank.");
                return;
            }
            else
            {
                try
                {
                    StartEndValidate(StartTime.Value, EndTime.Value);
                }
                catch (StartAfterEndTimeException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                try
                {
                    AppointmentCheck(StartTime.Value, EndTime.Value, (int)CounselorComboBox.SelectedValue, stu1.ID);
                }
                catch (InvalidAppointmentOverlap ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            {
                Appointment appointment = new (
                    0,
                    (int)CounselorComboBox.SelectedValue,
                    stu1.ID,
                    ReasonComboBox.Text,
                    stu1.SchoolID,
                    DescriptionTextBox.Text,
                    StartTime.Value,
                    EndTime.Value,
                    DateTime.Now,
                    Username,
                    DateTime.Now,
                    Username
                    );
                try
                {
                    stacs.AddAppointment(appointment);
                    this.Close();
                    Dashboard Dash = new(UserID, Username);
                    Dash.Show();
            }
                catch
            {
                MessageBox.Show("The appointment could not be added.");
                return;
            }
        }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CounselorComboBox.Text == "")
            {
                MessageBox.Show("Counselor cannot be blank.");
                return;
            }
            else if (ReasonComboBox.Text == "")
            {
                MessageBox.Show("Reason for appointment cannot be blank.");
                return;
            }
            else
            {
                try
                {
                    StartEndValidate(StartTime.Value, EndTime.Value);
                }
                catch (StartAfterEndTimeException ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                try
                {
                    AppointmentCheck(StartTime.Value, EndTime.Value, (int)CounselorComboBox.SelectedValue, transfer.StudentID, transfer.ID);
                }
                catch (InvalidAppointmentOverlap ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                
                Appointment appointment = new (
                    transfer.ID, 
                    (int)CounselorComboBox.SelectedValue, 
                    transfer.StudentID, 
                    ReasonComboBox.Text, 
                    transfer.SchoolID, 
                    DescriptionTextBox.Text, 
                    StartTime.Value, 
                    EndTime.Value, 
                    transfer.CreateDate, 
                    transfer.CreatedBy.ToString(), 
                    DateTime.Now, 
                    Username
                    );
                try
                {
                    stacs.UpdateAppointment(appointment);
                    this.Close();
                    Dashboard Dash = new(UserID, Username);
                    Dash.Show();
                }
                catch
                {
                    MessageBox.Show("The appointment could not be updated.");
                    return;
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"This will delete this appointment from the database! Are you sure?",
       "Delete Appointment", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    stacs.DeleteAppointment(transfer);
                    this.Close();
                    Dashboard Dash = new(UserID, Username);
                    Dash.Show();
                }
                catch
                {
                    MessageBox.Show("Could not delete appointment.");
                }

            }
        }
    }
}
