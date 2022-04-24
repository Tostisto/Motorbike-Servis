using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Project
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            // Password textbox
            this.registerPasswordEntry.Text = "";
            this.registerPasswordEntry.PasswordChar = '*';
        }

        private void confirmChange(object sender, EventArgs e)
        {
            if (this.confirm.Checked)
            {
                this.registerBTN.Enabled = true;
            }
            else
            {
                this.registerBTN.Enabled = false;
            }
        }

        private void registerEmailEntry_Validating(object sender, CancelEventArgs e)
        {
            Regex regex = new Regex(@"^[a-z0-9]+@[a-z0-9]+\.[a-z]{2,6}$");

            if (regex.IsMatch(this.registerEmailEntry.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(this.registerEmailEntry, "");
            }
            else
            {
                e.Cancel = true;
                this.registerEmailEntry.Focus();
                this.errorProvider.SetError(this.registerEmailEntry, "Wrong format of the specified email.");
            }

        }

        private void registerPasswordEntry_Validating(object sender, CancelEventArgs e)
        {
            //Regex regexExpr = new Regex(@"^[a-zA-Z0-9]{6,10}");

            Regex regex = new Regex(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{6,}$");

            if (regex.IsMatch(this.registerPasswordEntry.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(this.registerPasswordEntry, "");
            }
            else
            {
                e.Cancel = true;
                this.registerEmailEntry.Focus();
                this.errorProvider.SetError(this.registerPasswordEntry, "The password is not valid. Your password must contain at least 6 characters with at least one uppercase letter and number.");
            }
        }

        private async void registerBTN_Click(object sender, EventArgs e)
        {
            
            if(this.registerFNameEntry.Text == "" || this.registerLNameEntry.Text == "" || this.registerEmailEntry.Text == "" || this.registerPasswordEntry.Text == "")
            {
                MessageBox.Show("Please enter all information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                User newUser = new User(
                    0,
                    this.registerFNameEntry.Text,
                    this.registerLNameEntry.Text,
                    this.registerEmailEntry.Text,
                    this.registerPasswordEntry.Text,
                    DateOnly.FromDateTime(this.registerDateTimePicker.Value.Date).ToString(),
                    "user"
                    );

                await Database.insert<User>(newUser);

                DialogResult result = MessageBox.Show("Register Completed");


                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                    await Email.RegisterEmail(newUser);
                }
            }
        }
    }
}
