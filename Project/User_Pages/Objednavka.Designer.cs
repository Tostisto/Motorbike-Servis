namespace Project.User_Pages
{
    partial class Objednavka
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
            this.orders_datagrid = new System.Windows.Forms.DataGridView();
            this.bottom_panel = new System.Windows.Forms.Panel();
            this.invoiceBTN = new System.Windows.Forms.Button();
            this.total_price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.orders_datagrid)).BeginInit();
            this.bottom_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orders_datagrid
            // 
            this.orders_datagrid.AllowUserToAddRows = false;
            this.orders_datagrid.AllowUserToDeleteRows = false;
            this.orders_datagrid.AllowUserToResizeColumns = false;
            this.orders_datagrid.AllowUserToResizeRows = false;
            this.orders_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orders_datagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orders_datagrid.GridColor = System.Drawing.SystemColors.Control;
            this.orders_datagrid.Location = new System.Drawing.Point(0, 0);
            this.orders_datagrid.Name = "orders_datagrid";
            this.orders_datagrid.RowHeadersWidth = 51;
            this.orders_datagrid.RowTemplate.Height = 29;
            this.orders_datagrid.Size = new System.Drawing.Size(800, 313);
            this.orders_datagrid.TabIndex = 0;
            // 
            // bottom_panel
            // 
            this.bottom_panel.BackColor = System.Drawing.SystemColors.Window;
            this.bottom_panel.Controls.Add(this.invoiceBTN);
            this.bottom_panel.Controls.Add(this.total_price);
            this.bottom_panel.Controls.Add(this.label2);
            this.bottom_panel.Controls.Add(this.label1);
            this.bottom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottom_panel.Location = new System.Drawing.Point(0, 313);
            this.bottom_panel.Name = "bottom_panel";
            this.bottom_panel.Size = new System.Drawing.Size(800, 137);
            this.bottom_panel.TabIndex = 1;
            // 
            // invoiceBTN
            // 
            this.invoiceBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.invoiceBTN.Location = new System.Drawing.Point(626, 70);
            this.invoiceBTN.Name = "invoiceBTN";
            this.invoiceBTN.Size = new System.Drawing.Size(134, 29);
            this.invoiceBTN.TabIndex = 4;
            this.invoiceBTN.Text = "Make an invoice";
            this.invoiceBTN.UseVisualStyleBackColor = true;
            this.invoiceBTN.Click += new System.EventHandler(this.invoiceBTN_Click);
            // 
            // total_price
            // 
            this.total_price.AutoSize = true;
            this.total_price.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.total_price.Location = new System.Drawing.Point(149, 70);
            this.total_price.Name = "total_price";
            this.total_price.Size = new System.Drawing.Size(62, 25);
            this.total_price.TabIndex = 2;
            this.total_price.Text = "32000";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total sum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(152, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Payment";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.orders_datagrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 313);
            this.panel1.TabIndex = 2;
            // 
            // Objednavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bottom_panel);
            this.Name = "Objednavka";
            this.Text = "Objednavka";
            ((System.ComponentModel.ISupportInitialize)(this.orders_datagrid)).EndInit();
            this.bottom_panel.ResumeLayout(false);
            this.bottom_panel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView orders_datagrid;
        private Panel bottom_panel;
        private Label total_price;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Button invoiceBTN;
    }
}