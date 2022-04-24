using System.Text.RegularExpressions;

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

        private async void update_email_Click(object sender, EventArgs e)
        {

            Regex regex = new Regex(@"^[a-z0-9]+@[a-z0-9]+\.[a-z]{2,6}$");

            if (regex.IsMatch(this.newEmail.Text))
            {
                userSetting.Email = newEmail.Text;
                await Database.Update<User>(userSetting);
                MessageBox.Show("Email updated successfully.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Faild Update Email. Email is not valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void update_password_Click(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{6,}$");

            if (this.oldPassword.Text == userSetting.Password && regex.IsMatch(this.newPassword.Text))
            {
                userSetting.Password = this.newPassword.Text;
                await Database.Update<User>(userSetting);
                MessageBox.Show("Password updated.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Fuild update Password. Password. You may have entered the wrong old password or the new password is not valid. Your password must contain at least 6 characters with at least one uppercase letter and number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
