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
    public partial class SchoolView : Form
    {
        readonly int UserID;
        readonly string Username;
        readonly School transfer;
        readonly StacsDB stacs = new();
        public SchoolView()
        {
            InitializeComponent();
        }

        public SchoolView(int userid, string username)
        {
            InitializeComponent();
            UserID = userid;
            Username = username;
            UpdateButton.Enabled = false;
            UpdateButton.Visible = false;
            SaveButton.Enabled = true;
            SaveButton.Visible = true;
        }

        public SchoolView(int userid, string username, School school)
        {
            InitializeComponent();
            UserID = userid;
            Username = username;
            transfer = school;
            PopulateSchool(transfer);
            SaveButton.Enabled = false;
            SaveButton.Visible = false;
            UpdateButton.Enabled = true;
            UpdateButton.Visible = true;
        }

        private void PopulateSchool(School school)
        {
            NameTextBox.Text = school.Name;
            AddressTextBox.Text = school.Address;
            Address2TextBox.Text = school.Address2;
            CityTextBox.Text = school.City;
            StateTextBox.Text = school.State;
            ZipCodeTextBox.Text = school.Zipcode;
            ContactTextBox.Text = school.Contact;
            PhoneTextBox.Text = school.Phone;
            EmailTextBox.Text = school.Email;
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("School name cannot be blank.");
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
            else if (ContactTextBox.Text == "")
            {
                MessageBox.Show("Contact cannot be blank.");
                return;
            }
            else if (PhoneTextBox.Text == "")
            {
                MessageBox.Show("Phone cannot be blank.");
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
            else
            {
                School newSchool = new(

                    transfer.ID,
                    NameTextBox.Text,
                    AddressTextBox.Text,
                    Address2TextBox.Text,
                    CityTextBox.Text,
                    StateTextBox.Text,
                    ZipCodeTextBox.Text,
                    ContactTextBox.Text,
                    PhoneTextBox.Text,
                    EmailTextBox.Text);
                try
                {
                    stacs.UpdateSchool(newSchool);
                    this.Close();
                    AdminView AView = new(UserID, Username);
                    AView.Show();
                }
                catch
                {
                    MessageBox.Show("Could not update the school.");
                    return;
                }
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (NameTextBox.Text == "")
            {
                MessageBox.Show("School name cannot be blank.");
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
            else if (ContactTextBox.Text == "")
            {
                MessageBox.Show("Contact cannot be blank.");
                return;
            }
            else if (PhoneTextBox.Text == "")
            {
                MessageBox.Show("Phone cannot be blank.");
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
            else
            {
                School newSchool = new(

                    0,
                    NameTextBox.Text,
                    AddressTextBox.Text,
                    Address2TextBox.Text,
                    CityTextBox.Text,
                    StateTextBox.Text,
                    ZipCodeTextBox.Text,
                    ContactTextBox.Text,
                    PhoneTextBox.Text,
                    EmailTextBox.Text);
                try
                {
                    stacs.AddSchool(newSchool);
                    this.Close();
                    AdminView AView = new(UserID, Username);
                    AView.Show();
                }
                catch
                {
                    MessageBox.Show("School could not be added.");
                }
        }

        }

        private void CancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminView AView = new(UserID, Username);
            AView.Show();
        }

        private void PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46 && ch != 45 && ch != 40 && ch != 41)
            {
                e.Handled = true;
            }
        }

    }
}
