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
    public partial class UserView : Form
    {
        readonly int UserID;
        readonly string Username;
        readonly BindingList<Counselor> AllCounselors = new();
        readonly BindingList<User> AllUsers = new();
        readonly User transfer;
        readonly StacsDB stacs = new();

        public UserView()
        {
            InitializeComponent();
        }

        public UserView(int userID, string username)
        {
            InitializeComponent();
            UserID = userID;
            Username = username;
            stacs.FillCounselors(AllCounselors);
            stacs.FillUsers(AllUsers);
            AdminCheckBox.Checked = false;
            PasswordBox.Enabled = false;
            RepeatPasswordBox.Enabled = false;
            ResetPassButton.Enabled = false;
            UpdateButton.Visible = false;
            FillComboBox(CounselorComboBox, AllCounselors);
        }

        public UserView(int userID, string username, User user)
        {
            InitializeComponent();
            UserID = userID;
            Username = username;
            transfer = user;
            stacs.FillCounselors(AllCounselors);
            stacs.FillUsers(AllUsers);
            UserNameTextBox.Text = transfer.UserName;
            if (transfer.IntAdmin == 1)
            {
                AdminCheckBox.Checked = true;
            }
            else
            {
                AdminCheckBox.Checked = false;
            }
            FillComboBox(CounselorComboBox, AllCounselors);
            CounselorComboBox.SelectedValue = transfer.CounselorID;
            ResetPassButton.Enabled = true;
            SaveButton.Visible = false;

        }
        private static void FillComboBox(ComboBox combo, BindingList<Counselor> counselors)
        {
            combo.DataSource = counselors;
            combo.DisplayMember = "FullName";
            combo.ValueMember = "ID";
        }

        private int NameCheck(string name)
        {

            foreach(User user in AllUsers)
            {
                if (user.UserName == name)
                {
                    return 1;
                }
            }
            return 0;
        }

        private int NameCheck(string name, int userID)
        {

            foreach (User user in AllUsers)
            {
                if (user.UserName == name && user.ID != userID)
                {
                    return 1;
                }
            }
            return 0;
        }
        private void CancelButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminView AView = new(UserID, Username);
            AView.Show();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (transfer.ID == UserID)
            {
                MessageBox.Show("You cannot alter the username or privileges of the current user.");
                return;
            }
            else if (UserNameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be blank.");
                return;
            }
            else if (NameCheck(UserNameTextBox.Text, transfer.ID) == 1)
            {
                MessageBox.Show("This username is already in use.");
                return;
            }
            else
            {
                int admin = 0;
                int CounselorID = (int)CounselorComboBox.SelectedValue;
                if (AdminCheckBox.Checked == true)
                {
                    admin = 1;
                }
                if (CounselorComboBox.SelectedItem == null)
                {
                    CounselorID = -1;
                }
                User user = new(transfer.ID, UserNameTextBox.Text, admin, CounselorID);
                //try
                //{
                    stacs.UpdateUser(user);
                    this.Close();
                    AdminView AView = new(UserID, Username);
                    AView.Show();
                //}
                //catch
                //{
                //    MessageBox.Show("User update failed.");
                //}
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(UserNameTextBox.Text == "")
            {
                MessageBox.Show("Username cannot be blank.");
                return;
            }
            else if (NameCheck(UserNameTextBox.Text) == 1)
            {
                MessageBox.Show("This username is already in use.");
                return;
            }
            else
            {
                int admin = 0;
                int CounselorID = (int)CounselorComboBox.SelectedValue;
                if (AdminCheckBox.Checked == true)
                {
                    admin = 1;
                }
                if (CounselorComboBox.SelectedItem == null)
                {
                    CounselorID = -1;
                }
                User user = new(0, UserNameTextBox.Text, admin, CounselorID);
                try
                {
                    stacs.AddUser(user);
                    this.Close();
                    AdminView AView = new(UserID, Username);
                    AView.Show();
                }
                catch
                {
                    MessageBox.Show("User add failed.");
                }
            }

        }

        private void ResetPassButton_Click(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                MessageBox.Show("Password cannot be blank.");
                return;
            }
            else if (PasswordBox.Text.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long and contain only letters and numbers.");
                return;
            }
            else if (PasswordBox.Text != RepeatPasswordBox.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }
            else 
            {
                //try
                //{
                    stacs.PasswordChange(transfer, PasswordBox.Text);
                    MessageBox.Show("Password successfully changed.");
                    this.Close();
                    AdminView AView = new(UserID, Username);
                    AView.Show();
                //}
                //catch
                //{
                //    MessageBox.Show("Could not change the password.");
                //    return;
                //}
            }
        }

        private void PasswordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '\b')                 
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
