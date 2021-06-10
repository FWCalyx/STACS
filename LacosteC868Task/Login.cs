using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LacosteC868Task
{
    public partial class Login : Form
    {
        readonly StacsDB stacs = new();
        int UserID;
        public Login()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text == "" || PasswordTextBox.Text == "")
            {
                MessageBox.Show("Neither username nor password may be blank.");
                return;
            }
            else
            {
                UserID = stacs.UserCheck(UsernameTextBox.Text, PasswordTextBox.Text);
                if (UserID == 0)
                {
                    MessageBox.Show("Username or password is incorrect.");
                    return;
                }
                else
                {
                    this.Hide();
                    Dashboard Dash = new(UserID, UsernameTextBox.Text);
                    Dash.Show();
                }
            }
               
        }
    }
}
