using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (string.IsNullOrWhiteSpace(this.registerEmailEntry.Text))
            {
                e.Cancel = true;
                this.registerEmailEntry.Focus();
                this.errorProvider.SetError(this.registerEmailEntry, "Bad email");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(this.registerEmailEntry, "");
            }
        }

        private void registerPasswordEntry_Validating(object sender, CancelEventArgs e)
        {

            if (this.registerPasswordEntry.Text.Length < 5)
            {
                e.Cancel = true;
                this.registerPassword.Focus();
                errorProvider.SetError(this.registerPasswordEntry, $"The password must be 5 characters long.");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(this.registerPasswordEntry, "");
            }
        }
        
        private void registerBTN_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                User newUser = new User(
                    0,
                    this.registerFNameEntry.Text,
                    this.registerLNameEntry.Text,
                    this.registerEmailEntry.Text,
                    this.registerEmailEntry.Text,
                    DateOnly.FromDateTime(this.registerDateTimePicker.Value.Date).ToString(),
                    "user"
                    );

                Database.insert<User>(newUser);

                DialogResult result = MessageBox.Show("Register Completed");
                if(result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
