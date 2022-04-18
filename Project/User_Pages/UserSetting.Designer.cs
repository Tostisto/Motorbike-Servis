namespace Project.User_Pages
{
    partial class UserSetting
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
            this.label1 = new System.Windows.Forms.Label();
            this.newEmail = new System.Windows.Forms.TextBox();
            this.newPassword = new System.Windows.Forms.TextBox();
            this.update_email = new System.Windows.Forms.Button();
            this.oldPassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.update_password = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Email_group = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.Email_group.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Email:";
            // 
            // newEmail
            // 
            this.newEmail.Location = new System.Drawing.Point(130, 42);
            this.newEmail.Name = "newEmail";
            this.newEmail.Size = new System.Drawing.Size(125, 27);
            this.newEmail.TabIndex = 2;
            // 
            // newPassword
            // 
            this.newPassword.Location = new System.Drawing.Point(130, 74);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(125, 27);
            this.newPassword.TabIndex = 3;
            // 
            // update_email
            // 
            this.update_email.Location = new System.Drawing.Point(261, 40);
            this.update_email.Name = "update_email";
            this.update_email.Size = new System.Drawing.Size(94, 29);
            this.update_email.TabIndex = 4;
            this.update_email.Text = "Update Email";
            this.update_email.UseVisualStyleBackColor = true;
            this.update_email.Click += new System.EventHandler(this.update_email_Click);
            // 
            // oldPassword
            // 
            this.oldPassword.Location = new System.Drawing.Point(130, 41);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(125, 27);
            this.oldPassword.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.update_password);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.oldPassword);
            this.groupBox1.Controls.Add(this.newPassword);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 118);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Password";
            // 
            // update_password
            // 
            this.update_password.Location = new System.Drawing.Point(261, 74);
            this.update_password.Name = "update_password";
            this.update_password.Size = new System.Drawing.Size(94, 29);
            this.update_password.TabIndex = 8;
            this.update_password.Text = "Update";
            this.update_password.UseVisualStyleBackColor = true;
            this.update_password.Click += new System.EventHandler(this.update_password_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Old Password:";
            // 
            // Email_group
            // 
            this.Email_group.Controls.Add(this.label1);
            this.Email_group.Controls.Add(this.newEmail);
            this.Email_group.Controls.Add(this.update_email);
            this.Email_group.Dock = System.Windows.Forms.DockStyle.Top;
            this.Email_group.Location = new System.Drawing.Point(0, 118);
            this.Email_group.Name = "Email_group";
            this.Email_group.Size = new System.Drawing.Size(800, 100);
            this.Email_group.TabIndex = 7;
            this.Email_group.TabStop = false;
            this.Email_group.Text = "Email";
            // 
            // UserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Email_group);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserSetting";
            this.Text = "UserSetting";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Email_group.ResumeLayout(false);
            this.Email_group.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox newEmail;
        private TextBox newPassword;
        private Button update_email;
        private TextBox oldPassword;
        private GroupBox groupBox1;
        private GroupBox Email_group;
        private Button update_password;
        private Label label3;
        private Label label2;
    }
}