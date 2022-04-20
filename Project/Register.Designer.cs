namespace Project
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.registerFName = new System.Windows.Forms.Label();
            this.registerLName = new System.Windows.Forms.Label();
            this.registerEmail = new System.Windows.Forms.Label();
            this.registerPassword = new System.Windows.Forms.Label();
            this.registerDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.registerDate = new System.Windows.Forms.Label();
            this.confirm = new System.Windows.Forms.CheckBox();
            this.registerBTN = new System.Windows.Forms.Button();
            this.registerFNameEntry = new System.Windows.Forms.TextBox();
            this.registerLNameEntry = new System.Windows.Forms.TextBox();
            this.registerEmailEntry = new System.Windows.Forms.TextBox();
            this.registerPasswordEntry = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // registerFName
            // 
            this.registerFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerFName.AutoSize = true;
            this.registerFName.Location = new System.Drawing.Point(244, 83);
            this.registerFName.Name = "registerFName";
            this.registerFName.Size = new System.Drawing.Size(80, 20);
            this.registerFName.TabIndex = 0;
            this.registerFName.Text = "First Name";
            // 
            // registerLName
            // 
            this.registerLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerLName.AutoSize = true;
            this.registerLName.Location = new System.Drawing.Point(244, 116);
            this.registerLName.Name = "registerLName";
            this.registerLName.Size = new System.Drawing.Size(79, 20);
            this.registerLName.TabIndex = 1;
            this.registerLName.Text = "Last Name";
            // 
            // registerEmail
            // 
            this.registerEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerEmail.AutoSize = true;
            this.registerEmail.Location = new System.Drawing.Point(271, 149);
            this.registerEmail.Name = "registerEmail";
            this.registerEmail.Size = new System.Drawing.Size(52, 20);
            this.registerEmail.TabIndex = 2;
            this.registerEmail.Text = "E-mail";
            // 
            // registerPassword
            // 
            this.registerPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerPassword.AutoSize = true;
            this.registerPassword.Location = new System.Drawing.Point(253, 186);
            this.registerPassword.Name = "registerPassword";
            this.registerPassword.Size = new System.Drawing.Size(70, 20);
            this.registerPassword.TabIndex = 3;
            this.registerPassword.Text = "Password";
            // 
            // registerDateTimePicker
            // 
            this.registerDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.registerDateTimePicker.Location = new System.Drawing.Point(329, 212);
            this.registerDateTimePicker.Name = "registerDateTimePicker";
            this.registerDateTimePicker.Size = new System.Drawing.Size(198, 27);
            this.registerDateTimePicker.TabIndex = 5;
            // 
            // registerDate
            // 
            this.registerDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerDate.AutoSize = true;
            this.registerDate.Location = new System.Drawing.Point(229, 217);
            this.registerDate.Name = "registerDate";
            this.registerDate.Size = new System.Drawing.Size(94, 20);
            this.registerDate.TabIndex = 5;
            this.registerDate.Text = "Date of Birth";
            // 
            // confirm
            // 
            this.confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirm.AutoSize = true;
            this.confirm.Location = new System.Drawing.Point(429, 262);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(90, 24);
            this.confirm.TabIndex = 6;
            this.confirm.Text = "I agree ...";
            this.toolTip1.SetToolTip(this.confirm, "I agree to the Our Terms and Conditions.");
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.CheckStateChanged += new System.EventHandler(this.confirmChange);
            // 
            // registerBTN
            // 
            this.registerBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerBTN.Enabled = false;
            this.registerBTN.Location = new System.Drawing.Point(329, 259);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(94, 29);
            this.registerBTN.TabIndex = 7;
            this.registerBTN.Text = "Register";
            this.registerBTN.UseVisualStyleBackColor = true;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // registerFNameEntry
            // 
            this.registerFNameEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerFNameEntry.Location = new System.Drawing.Point(329, 80);
            this.registerFNameEntry.Name = "registerFNameEntry";
            this.registerFNameEntry.Size = new System.Drawing.Size(198, 27);
            this.registerFNameEntry.TabIndex = 1;
            // 
            // registerLNameEntry
            // 
            this.registerLNameEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerLNameEntry.Location = new System.Drawing.Point(329, 113);
            this.registerLNameEntry.Name = "registerLNameEntry";
            this.registerLNameEntry.Size = new System.Drawing.Size(198, 27);
            this.registerLNameEntry.TabIndex = 2;
            // 
            // registerEmailEntry
            // 
            this.registerEmailEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerEmailEntry.Location = new System.Drawing.Point(329, 146);
            this.registerEmailEntry.Name = "registerEmailEntry";
            this.registerEmailEntry.Size = new System.Drawing.Size(198, 27);
            this.registerEmailEntry.TabIndex = 3;
            this.registerEmailEntry.Validating += new System.ComponentModel.CancelEventHandler(this.registerEmailEntry_Validating);
            // 
            // registerPasswordEntry
            // 
            this.registerPasswordEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerPasswordEntry.Location = new System.Drawing.Point(329, 179);
            this.registerPasswordEntry.Name = "registerPasswordEntry";
            this.registerPasswordEntry.Size = new System.Drawing.Size(198, 27);
            this.registerPasswordEntry.TabIndex = 4;
            this.registerPasswordEntry.Validating += new System.ComponentModel.CancelEventHandler(this.registerPasswordEntry_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registerPasswordEntry);
            this.Controls.Add(this.registerEmailEntry);
            this.Controls.Add(this.registerLNameEntry);
            this.Controls.Add(this.registerFNameEntry);
            this.Controls.Add(this.registerBTN);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.registerDate);
            this.Controls.Add(this.registerDateTimePicker);
            this.Controls.Add(this.registerPassword);
            this.Controls.Add(this.registerEmail);
            this.Controls.Add(this.registerLName);
            this.Controls.Add(this.registerFName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label registerFName;
        private Label registerLName;
        private Label registerEmail;
        private Label registerPassword;
        private DateTimePicker registerDateTimePicker;
        private Label registerDate;
        private CheckBox confirm;
        private Button registerBTN;
        private TextBox registerFNameEntry;
        private TextBox registerLNameEntry;
        private TextBox registerEmailEntry;
        private TextBox registerPasswordEntry;
        private ErrorProvider errorProvider;
        private ToolTip toolTip1;
    }
}