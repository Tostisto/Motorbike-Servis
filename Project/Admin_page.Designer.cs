namespace Project
{
    partial class Admin_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_page));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userInfoName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.indicator = new System.Windows.Forms.Panel();
            this.logout_button = new System.Windows.Forms.Button();
            this.servis_button = new System.Windows.Forms.Button();
            this.reservation_button = new System.Windows.Forms.Button();
            this.objednavka_btn = new System.Windows.Forms.Button();
            this.container = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1086, 49);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.35025F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.64975F));
            this.tableLayoutPanel1.Controls.Add(this.userInfoName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(889, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(197, 49);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // userInfoName
            // 
            this.userInfoName.AutoSize = true;
            this.userInfoName.BackColor = System.Drawing.SystemColors.Window;
            this.userInfoName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userInfoName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userInfoName.Location = new System.Drawing.Point(48, 0);
            this.userInfoName.Name = "userInfoName";
            this.userInfoName.Padding = new System.Windows.Forms.Padding(3);
            this.userInfoName.Size = new System.Drawing.Size(146, 49);
            this.userInfoName.TabIndex = 1;
            this.userInfoName.Text = "Jakub Czepiec";
            this.userInfoName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 43);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.indicator);
            this.panel2.Controls.Add(this.logout_button);
            this.panel2.Controls.Add(this.servis_button);
            this.panel2.Controls.Add(this.reservation_button);
            this.panel2.Controls.Add(this.objednavka_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 542);
            this.panel2.TabIndex = 9;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.SystemColors.WindowText;
            this.indicator.Location = new System.Drawing.Point(-100, -100);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(5, 60);
            this.indicator.TabIndex = 0;
            // 
            // logout_button
            // 
            this.logout_button.BackColor = System.Drawing.SystemColors.Window;
            this.logout_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logout_button.FlatAppearance.BorderSize = 0;
            this.logout_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logout_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.logout_button.Location = new System.Drawing.Point(0, 482);
            this.logout_button.Name = "logout_button";
            this.logout_button.Size = new System.Drawing.Size(250, 60);
            this.logout_button.TabIndex = 3;
            this.logout_button.Text = "Log out";
            this.logout_button.UseVisualStyleBackColor = false;
            // 
            // servis_button
            // 
            this.servis_button.BackColor = System.Drawing.SystemColors.Window;
            this.servis_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servis_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.servis_button.FlatAppearance.BorderSize = 0;
            this.servis_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.servis_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.servis_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.servis_button.Location = new System.Drawing.Point(0, 120);
            this.servis_button.Name = "servis_button";
            this.servis_button.Size = new System.Drawing.Size(250, 60);
            this.servis_button.TabIndex = 2;
            this.servis_button.Text = "Servis";
            this.servis_button.UseVisualStyleBackColor = false;
            // 
            // reservation_button
            // 
            this.reservation_button.BackColor = System.Drawing.SystemColors.Window;
            this.reservation_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reservation_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.reservation_button.FlatAppearance.BorderSize = 0;
            this.reservation_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservation_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.reservation_button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reservation_button.Location = new System.Drawing.Point(0, 60);
            this.reservation_button.Name = "reservation_button";
            this.reservation_button.Size = new System.Drawing.Size(250, 60);
            this.reservation_button.TabIndex = 1;
            this.reservation_button.Text = "Nová rezervace";
            this.reservation_button.UseVisualStyleBackColor = false;
            // 
            // objednavka_btn
            // 
            this.objednavka_btn.BackColor = System.Drawing.SystemColors.Window;
            this.objednavka_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.objednavka_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.objednavka_btn.FlatAppearance.BorderSize = 0;
            this.objednavka_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.objednavka_btn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.objednavka_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.objednavka_btn.Location = new System.Drawing.Point(0, 0);
            this.objednavka_btn.Name = "objednavka_btn";
            this.objednavka_btn.Size = new System.Drawing.Size(250, 60);
            this.objednavka_btn.TabIndex = 0;
            this.objednavka_btn.Text = "New motorbike";
            this.objednavka_btn.UseVisualStyleBackColor = false;
            this.objednavka_btn.Click += new System.EventHandler(this.objednavka_btn_Click);
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.SystemColors.Window;
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(250, 49);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(836, 542);
            this.container.TabIndex = 10;
            // 
            // Admin_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 591);
            this.Controls.Add(this.container);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin_page";
            this.Text = "Admin_page";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label userInfoName;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel indicator;
        private Button logout_button;
        private Button servis_button;
        private Button reservation_button;
        private Button objednavka_btn;
        private Panel container;
    }
}