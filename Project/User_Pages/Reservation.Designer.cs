namespace Project.User_Pages
{
    partial class Reservation
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
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.motorbikeBrand = new System.Windows.Forms.Label();
            this.motorbike_combobox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.motorbike_preview_image = new System.Windows.Forms.PictureBox();
            this.motorbike_description = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motorbike_preview_image)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Project.User);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 585);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.calendar);
            this.panel2.Controls.Add(this.motorbikeBrand);
            this.panel2.Controls.Add(this.motorbike_combobox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(471, 579);
            this.panel2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(285, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rental Dates:";
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(187, 87);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 2;
            this.calendar.TitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            // 
            // motorbikeBrand
            // 
            this.motorbikeBrand.AutoSize = true;
            this.motorbikeBrand.Location = new System.Drawing.Point(100, 50);
            this.motorbikeBrand.Name = "motorbikeBrand";
            this.motorbikeBrand.Size = new System.Drawing.Size(81, 20);
            this.motorbikeBrand.TabIndex = 0;
            this.motorbikeBrand.Text = "Motorbike:";
            // 
            // motorbike_combobox
            // 
            this.motorbike_combobox.DataSource = this.userBindingSource;
            this.motorbike_combobox.FormattingEnabled = true;
            this.motorbike_combobox.Location = new System.Drawing.Point(187, 47);
            this.motorbike_combobox.Name = "motorbike_combobox";
            this.motorbike_combobox.Size = new System.Drawing.Size(192, 28);
            this.motorbike_combobox.TabIndex = 1;
            this.motorbike_combobox.SelectedIndexChanged += new System.EventHandler(this.motorbike_combobox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(480, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(471, 579);
            this.panel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.motorbike_preview_image, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.motorbike_description, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.69048F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.30952F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 338F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(471, 579);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // motorbike_preview_image
            // 
            this.motorbike_preview_image.BackColor = System.Drawing.SystemColors.Window;
            this.motorbike_preview_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motorbike_preview_image.Location = new System.Drawing.Point(3, 3);
            this.motorbike_preview_image.Name = "motorbike_preview_image";
            this.motorbike_preview_image.Size = new System.Drawing.Size(465, 147);
            this.motorbike_preview_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.motorbike_preview_image.TabIndex = 3;
            this.motorbike_preview_image.TabStop = false;
            // 
            // motorbike_description
            // 
            this.motorbike_description.BackColor = System.Drawing.SystemColors.Window;
            this.motorbike_description.Dock = System.Windows.Forms.DockStyle.Fill;
            this.motorbike_description.Location = new System.Drawing.Point(3, 243);
            this.motorbike_description.Multiline = true;
            this.motorbike_description.Name = "motorbike_description";
            this.motorbike_description.ReadOnly = true;
            this.motorbike_description.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.motorbike_description.Size = new System.Drawing.Size(465, 333);
            this.motorbike_description.TabIndex = 5;
            this.motorbike_description.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.price);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 156);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(465, 81);
            this.panel3.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Kč";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(68, 13);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(39, 20);
            this.price.TabIndex = 1;
            this.price.Text = "-----";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Price:";
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.motorbike_preview_image)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource userBindingSource;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Button button1;
        private Label label2;
        private MonthCalendar calendar;
        private Label motorbikeBrand;
        private ComboBox motorbike_combobox;
        private Panel panel1;
        private TextBox motorbike_description;
        private PictureBox motorbike_preview_image;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Label label5;
        private Label label6;
        private Label price;
    }
}