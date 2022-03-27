namespace Project.Admin_Pages
{
    partial class ServisManagement
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
            this.servicesManage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.servicesManage)).BeginInit();
            this.SuspendLayout();
            // 
            // servicesManage
            // 
            this.servicesManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.servicesManage.Location = new System.Drawing.Point(0, 0);
            this.servicesManage.Name = "servicesManage";
            this.servicesManage.RowHeadersWidth = 51;
            this.servicesManage.RowTemplate.Height = 29;
            this.servicesManage.Size = new System.Drawing.Size(800, 450);
            this.servicesManage.TabIndex = 0;
            this.servicesManage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.servicesManage_CellClick);
            // 
            // ServisManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.servicesManage);
            this.Name = "ServisManagement";
            this.Text = "ServisManagement";
            ((System.ComponentModel.ISupportInitialize)(this.servicesManage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView servicesManage;
    }
}