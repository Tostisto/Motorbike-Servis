using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Class;

using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.Drawing;
using Syncfusion.Pdf.Grid;

namespace Project.User_Pages
{
    public partial class Objednavka : Form
    {

        BindingList<Orders> user_orders = new BindingList<Orders>();

        float totalPrice = 0;

        User user = new User();

        static string filePath;

        public Objednavka(User user)
        {
            this.user = user;
            
            InitializeComponent();

            user_orders = Database.SpecificSelect<Orders>($"UserID = {user.Id} and Status = 0");

            if (user_orders.Count == 0)
            {
                this.invoiceBTN.Enabled = false;
            }
            else
            {
                this.invoiceBTN.Enabled = true;
            }

            this.orders_datagrid.AutoGenerateColumns = false;
            this.orders_datagrid.DataSource = user_orders;

            this.orders_datagrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Order ID",
                DataPropertyName = nameof(Orders.Id)
            });

            this.orders_datagrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                MinimumWidth = 300,
                HeaderText = "Motorbike",
                DataPropertyName = nameof(Orders.Product)
            });

            this.orders_datagrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Width = 150,
                HeaderText = "Service Type",
                DataPropertyName = nameof(Orders.Service)
            });

            this.orders_datagrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Width = 150,
                HeaderText = "Price",
                DataPropertyName = nameof(Orders.Price)
            });

             totalPrice = user_orders.Select(x => x.Price).Sum();

            this.total_price.Text = totalPrice.ToString();
        }


        public void GeneratePDF()
        {
            using (PdfDocument document = new PdfDocument())
            {
                PdfPage page = document.Pages.Add();
                PdfGraphics graphics = page.Graphics;

                PdfFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 16);
                graphics.DrawString("Objednavka", font, PdfBrushes.Black, new PointF(0, 20));


                PdfFont smallfont = new PdfStandardFont(PdfFontFamily.Helvetica, 10);
                graphics.DrawString($"Even though using lorem ipsum often arouses curiosity due to its resemblance to classical Latin", smallfont, PdfBrushes.Black, new PointF(0, 40));

                graphics.DrawString($"Jmeno: {user.FirstName} {user.LastName}", smallfont, PdfBrushes.Black, new PointF(0, 60));
                graphics.DrawString($"Email: {user.Email}", smallfont, PdfBrushes.Black, new PointF(0, 80));
                graphics.DrawString($"Datum: {DateTime.Now}", smallfont, PdfBrushes.Black, new PointF(0, 100));

                PdfGrid pdfGrid = new PdfGrid();
                DataTable dataTable = new DataTable();
                
                dataTable.Columns.Add("ID");
                dataTable.Columns.Add("Product");
                dataTable.Columns.Add("Service");
                dataTable.Columns.Add("Price");
                
                foreach(Orders or in user_orders)
                {
                    dataTable.Rows.Add(or.Id, or.Product, or.Service, or.Price + " Kč");
                }


                pdfGrid.DataSource = dataTable;
                pdfGrid.Draw(page, new PointF(10, 140));

                document.Save(filePath);
            }
        }


        public async Task UpdateOrders()
        {
            foreach (var order in user_orders)
            {
                order.Status = 1;
                Thread thread = new Thread(() => Database.Update<Orders>(order));
                thread.Start();
            }
        }

        private void invoiceBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save an Image File";
            save.Filter = "PDF File|*.pdf";
            save.ShowDialog();
            filePath = save.FileName;

            GeneratePDF();

            Task.WaitAll(UpdateOrders());

            this.user_orders.Clear();

            MessageBox.Show("Thanks for your order!");
        }
    }
}
