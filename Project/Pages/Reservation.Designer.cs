namespace Project.Pages
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
            this.motorbikeBrand = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.brand_combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // motorbikeBrand
            // 
            this.motorbikeBrand.AutoSize = true;
            this.motorbikeBrand.Location = new System.Drawing.Point(124, 41);
            this.motorbikeBrand.Name = "motorbikeBrand";
            this.motorbikeBrand.Size = new System.Drawing.Size(121, 20);
            this.motorbikeBrand.TabIndex = 0;
            this.motorbikeBrand.Text = "Motorbike Brand";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Project.User);
            // 
            // brand_combobox
            // 
            this.brand_combobox.DataSource = this.userBindingSource;
            this.brand_combobox.FormattingEnabled = true;
            this.brand_combobox.Location = new System.Drawing.Point(251, 38);
            this.brand_combobox.Name = "brand_combobox";
            this.brand_combobox.Size = new System.Drawing.Size(151, 28);
            this.brand_combobox.TabIndex = 1;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.brand_combobox);
            this.Controls.Add(this.motorbikeBrand);
            this.Name = "Reservation";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label motorbikeBrand;
        private BindingSource userBindingSource;
        private ComboBox brand_combobox;
    }
}