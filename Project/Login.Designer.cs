namespace Project
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel = new System.Windows.Forms.Panel();
            this.loginBTN = new System.Windows.Forms.Button();
            this.registerBTN = new System.Windows.Forms.Button();
            this.loginPasswordEntry = new System.Windows.Forms.TextBox();
            this.loginEmailEntry = new System.Windows.Forms.TextBox();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginEmailLabel = new System.Windows.Forms.Label();
            this.loginPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.AutoScroll = true;
            this.loginPanel.BackColor = System.Drawing.Color.AliceBlue;
            this.loginPanel.Controls.Add(this.loginBTN);
            this.loginPanel.Controls.Add(this.registerBTN);
            this.loginPanel.Controls.Add(this.loginPasswordEntry);
            this.loginPanel.Controls.Add(this.loginEmailEntry);
            this.loginPanel.Controls.Add(this.loginPasswordLabel);
            this.loginPanel.Controls.Add(this.loginEmailLabel);
            this.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPanel.Location = new System.Drawing.Point(0, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(800, 450);
            this.loginPanel.TabIndex = 6;
            // 
            // loginBTN
            // 
            this.loginBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginBTN.Location = new System.Drawing.Point(405, 233);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(94, 29);
            this.loginBTN.TabIndex = 11;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = true;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // registerBTN
            // 
            this.registerBTN.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.registerBTN.Location = new System.Drawing.Point(305, 233);
            this.registerBTN.Name = "registerBTN";
            this.registerBTN.Size = new System.Drawing.Size(94, 29);
            this.registerBTN.TabIndex = 10;
            this.registerBTN.Text = "Register";
            this.registerBTN.UseVisualStyleBackColor = true;
            this.registerBTN.Click += new System.EventHandler(this.registerBTN_Click);
            // 
            // loginPasswordEntry
            // 
            this.loginPasswordEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPasswordEntry.Location = new System.Drawing.Point(361, 185);
            this.loginPasswordEntry.Name = "loginPasswordEntry";
            this.loginPasswordEntry.Size = new System.Drawing.Size(150, 27);
            this.loginPasswordEntry.TabIndex = 9;
            // 
            // loginEmailEntry
            // 
            this.loginEmailEntry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginEmailEntry.Location = new System.Drawing.Point(361, 152);
            this.loginEmailEntry.Name = "loginEmailEntry";
            this.loginEmailEntry.Size = new System.Drawing.Size(150, 27);
            this.loginEmailEntry.TabIndex = 8;
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Location = new System.Drawing.Point(287, 188);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(70, 20);
            this.loginPasswordLabel.TabIndex = 7;
            this.loginPasswordLabel.Text = "Password";
            // 
            // loginEmailLabel
            // 
            this.loginEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginEmailLabel.AutoSize = true;
            this.loginEmailLabel.Location = new System.Drawing.Point(305, 155);
            this.loginEmailLabel.Name = "loginEmailLabel";
            this.loginEmailLabel.Size = new System.Drawing.Size(52, 20);
            this.loginEmailLabel.TabIndex = 6;
            this.loginEmailLabel.Text = "E-mail";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loginPanel);
            this.Name = "Login";
            this.Text = "Login";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel loginPanel;
        private Button loginBTN;
        private Button registerBTN;
        private TextBox loginPasswordEntry;
        private TextBox loginEmailEntry;
        private Label loginPasswordLabel;
        private Label loginEmailLabel;
    }
}