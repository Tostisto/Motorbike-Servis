namespace Project.User_Pages
{
    partial class Servis
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.brand_textBox = new System.Windows.Forms.TextBox();
            this.model_textBox = new System.Windows.Forms.TextBox();
            this.message_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.place = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.year_input = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.spz_textbox = new System.Windows.Forms.TextBox();
            this.add_servis = new System.Windows.Forms.Button();
            this.servirErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.year_input)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servirErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Brand";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // brand_textBox
            // 
            this.brand_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.brand_textBox.Location = new System.Drawing.Point(198, 22);
            this.brand_textBox.Name = "brand_textBox";
            this.brand_textBox.Size = new System.Drawing.Size(191, 27);
            this.brand_textBox.TabIndex = 2;
            this.brand_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.brand_textBox_Validating);
            // 
            // model_textBox
            // 
            this.model_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.model_textBox.Location = new System.Drawing.Point(198, 59);
            this.model_textBox.Name = "model_textBox";
            this.model_textBox.Size = new System.Drawing.Size(191, 27);
            this.model_textBox.TabIndex = 3;
            this.model_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.model_textBox_Validating);
            // 
            // message_textBox
            // 
            this.message_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.message_textBox.Location = new System.Drawing.Point(196, 191);
            this.message_textBox.Multiline = true;
            this.message_textBox.Name = "message_textBox";
            this.message_textBox.Size = new System.Drawing.Size(547, 167);
            this.message_textBox.TabIndex = 4;
            this.message_textBox.Validating += new System.ComponentModel.CancelEventHandler(this.message_textBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pobočka";
            // 
            // place
            // 
            this.place.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.place.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.place.FormattingEnabled = true;
            this.place.Items.AddRange(new object[] {
            "Praha",
            "Brno",
            "Ostrava",
            "Znojmo",
            "Pardubice"});
            this.place.Location = new System.Drawing.Point(198, 146);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(191, 28);
            this.place.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Model Year";
            // 
            // year_input
            // 
            this.year_input.Location = new System.Drawing.Point(196, 104);
            this.year_input.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.year_input.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.year_input.Name = "year_input";
            this.year_input.Size = new System.Drawing.Size(56, 27);
            this.year_input.TabIndex = 10;
            this.year_input.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "SPZ";
            // 
            // spz_textbox
            // 
            this.spz_textbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spz_textbox.Location = new System.Drawing.Point(298, 104);
            this.spz_textbox.Name = "spz_textbox";
            this.spz_textbox.Size = new System.Drawing.Size(89, 27);
            this.spz_textbox.TabIndex = 12;
            this.spz_textbox.Validating += new System.ComponentModel.CancelEventHandler(this.spz_textbox_Validating);
            // 
            // add_servis
            // 
            this.add_servis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.add_servis.Location = new System.Drawing.Point(198, 388);
            this.add_servis.Name = "add_servis";
            this.add_servis.Size = new System.Drawing.Size(119, 29);
            this.add_servis.TabIndex = 13;
            this.add_servis.Text = "Add request";
            this.add_servis.UseVisualStyleBackColor = true;
            this.add_servis.Click += new System.EventHandler(this.add_servis_Click);
            // 
            // servirErrorProvider
            // 
            this.servirErrorProvider.ContainerControl = this;
            // 
            // Servis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.add_servis);
            this.Controls.Add(this.spz_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.year_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.place);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.message_textBox);
            this.Controls.Add(this.model_textBox);
            this.Controls.Add(this.brand_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Servis";
            this.Text = "Servis";
            ((System.ComponentModel.ISupportInitialize)(this.year_input)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servirErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox brand_textBox;
        private TextBox model_textBox;
        private TextBox message_textBox;
        private Label label3;
        private Label label4;
        private ComboBox place;
        private Label label5;
        private NumericUpDown year_input;
        private Label label6;
        private TextBox spz_textbox;
        private Button add_servis;
        private ErrorProvider servirErrorProvider;
    }
}