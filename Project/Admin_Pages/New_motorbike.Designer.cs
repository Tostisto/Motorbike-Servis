namespace Project.Admin_Pages
{
    partial class New_motorbike
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(New_motorbike));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_motorbike_BTN = new System.Windows.Forms.Button();
            this.test_link_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.image_link = new System.Windows.Forms.TextBox();
            this.admin_add_motorbike_description = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.currency = new System.Windows.Forms.Label();
            this.admin_add_motorbike_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.new_motorbike_image = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.admin_add_motorbike_price = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.new_motorbike_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_add_motorbike_price)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 402F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.new_motorbike_image, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.admin_add_motorbike_price);
            this.panel1.Controls.Add(this.add_motorbike_BTN);
            this.panel1.Controls.Add(this.test_link_button);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.image_link);
            this.panel1.Controls.Add(this.admin_add_motorbike_description);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.currency);
            this.panel1.Controls.Add(this.admin_add_motorbike_name);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(392, 444);
            this.panel1.TabIndex = 0;
            // 
            // add_motorbike_BTN
            // 
            this.add_motorbike_BTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_motorbike_BTN.BackColor = System.Drawing.SystemColors.Window;
            this.add_motorbike_BTN.Location = new System.Drawing.Point(246, 390);
            this.add_motorbike_BTN.Name = "add_motorbike_BTN";
            this.add_motorbike_BTN.Size = new System.Drawing.Size(94, 29);
            this.add_motorbike_BTN.TabIndex = 21;
            this.add_motorbike_BTN.Text = "Add Motorbike";
            this.add_motorbike_BTN.UseVisualStyleBackColor = false;
            this.add_motorbike_BTN.Click += new System.EventHandler(this.add_motorbike_BTN_Click);
            // 
            // test_link_button
            // 
            this.test_link_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.test_link_button.BackColor = System.Drawing.SystemColors.Window;
            this.test_link_button.Location = new System.Drawing.Point(246, 355);
            this.test_link_button.Name = "test_link_button";
            this.test_link_button.Size = new System.Drawing.Size(94, 29);
            this.test_link_button.TabIndex = 20;
            this.test_link_button.Text = "Test Link";
            this.test_link_button.UseVisualStyleBackColor = false;
            this.test_link_button.Click += new System.EventHandler(this.test_link_button_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(48, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Image Link:";
            // 
            // image_link
            // 
            this.image_link.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.image_link.BackColor = System.Drawing.SystemColors.Window;
            this.image_link.Location = new System.Drawing.Point(135, 322);
            this.image_link.Name = "image_link";
            this.image_link.Size = new System.Drawing.Size(205, 27);
            this.image_link.TabIndex = 18;
            // 
            // admin_add_motorbike_description
            // 
            this.admin_add_motorbike_description.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.admin_add_motorbike_description.BackColor = System.Drawing.SystemColors.Window;
            this.admin_add_motorbike_description.Location = new System.Drawing.Point(135, 108);
            this.admin_add_motorbike_description.Multiline = true;
            this.admin_add_motorbike_description.Name = "admin_add_motorbike_description";
            this.admin_add_motorbike_description.Size = new System.Drawing.Size(205, 192);
            this.admin_add_motorbike_description.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(44, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Description:";
            // 
            // currency
            // 
            this.currency.AutoSize = true;
            this.currency.BackColor = System.Drawing.SystemColors.Menu;
            this.currency.Location = new System.Drawing.Point(315, 78);
            this.currency.Name = "currency";
            this.currency.Size = new System.Drawing.Size(25, 20);
            this.currency.TabIndex = 15;
            this.currency.Text = "Kč";
            // 
            // admin_add_motorbike_name
            // 
            this.admin_add_motorbike_name.BackColor = System.Drawing.SystemColors.Window;
            this.admin_add_motorbike_name.Location = new System.Drawing.Point(135, 39);
            this.admin_add_motorbike_name.Name = "admin_add_motorbike_name";
            this.admin_add_motorbike_name.Size = new System.Drawing.Size(180, 27);
            this.admin_add_motorbike_name.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(88, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(80, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Name:";
            // 
            // new_motorbike_image
            // 
            this.new_motorbike_image.BackColor = System.Drawing.SystemColors.Window;
            this.new_motorbike_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.new_motorbike_image.Image = ((System.Drawing.Image)(resources.GetObject("new_motorbike_image.Image")));
            this.new_motorbike_image.Location = new System.Drawing.Point(401, 3);
            this.new_motorbike_image.Name = "new_motorbike_image";
            this.new_motorbike_image.Size = new System.Drawing.Size(396, 444);
            this.new_motorbike_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.new_motorbike_image.TabIndex = 1;
            this.new_motorbike_image.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // admin_add_motorbike_price
            // 
            this.admin_add_motorbike_price.Location = new System.Drawing.Point(135, 72);
            this.admin_add_motorbike_price.Name = "admin_add_motorbike_price";
            this.admin_add_motorbike_price.Size = new System.Drawing.Size(180, 27);
            this.admin_add_motorbike_price.TabIndex = 22;
            // 
            // New_motorbike
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "New_motorbike";
            this.Text = "New_motorbike";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.new_motorbike_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_add_motorbike_price)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Button add_motorbike_BTN;
        private Button test_link_button;
        private Label label5;
        private TextBox image_link;
        private TextBox admin_add_motorbike_description;
        private Label label4;
        private Label label3;
        private TextBox admin_add_motorbike_name;
        private Label label2;
        private Label label1;
        private PictureBox new_motorbike_image;
        private ErrorProvider errorProvider1;
        private Label currency;
        private NumericUpDown admin_add_motorbike_price;
    }
}