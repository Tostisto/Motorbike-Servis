﻿using System.ComponentModel;
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
            Regex regexExpr = new Regex(@"^[a-z0-9]+@[a-z0-9]+\.[a-z]{2,6}$");

            if (regexExpr.IsMatch(this.registerEmailEntry.Text))
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
            Regex regexExpr = new Regex(@"^[a-zA-Z0-9]{6,10}");

            if (regexExpr.IsMatch(this.registerPasswordEntry.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(this.registerPasswordEntry, "");
            }
            else
            {
                e.Cancel = true;
                this.registerEmailEntry.Focus();
                this.errorProvider.SetError(this.registerPasswordEntry, "The password must have at least 6 characters, of which at least one number and one uppercase character");
            }
        }

        private async void registerBTN_Click(object sender, EventArgs e)
        {
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

                Database.insert<User>(newUser);

                DialogResult result = MessageBox.Show("Register Completed");

                await Email.RegisterEmail(newUser);

                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
