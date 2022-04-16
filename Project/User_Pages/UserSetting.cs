using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Project.User_Pages
{
    public partial class UserSetting : Form
    {
        User userSetting = new User();

        public UserSetting(User user)
        {
            this.userSetting = user;
            InitializeComponent();

            this.oldPassword.Text = "";
            this.oldPassword.PasswordChar = '*';
            this.newPassword.Text = "";
            this.newPassword.PasswordChar = '*';
        }

        private void update_email_Click(object sender, EventArgs e)
        {

            Regex regexExpr = new Regex(@"^[a-z0-9]+@[a-z0-9]+\.[a-z]{2,6}$");

            if (regexExpr.IsMatch(this.newEmail.Text))
            {
                userSetting.Email = newEmail.Text;
                Database.Update<User>(userSetting);
                MessageBox.Show("Email updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faild Update Email. Email is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update_password_Click(object sender, EventArgs e)
        {
            Regex regexExpr = new Regex(@"^[a-zA-Z0-9]{6,10}");

            if (this.oldPassword.Text == userSetting.Password && regexExpr.IsMatch(this.newPassword.Text))
            {
                userSetting.Password = this.newPassword.Text;
                Database.Update<User>(userSetting);
                MessageBox.Show("Password updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Fuild update Password. Password. You may have entered the wrong old password or the new password is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
