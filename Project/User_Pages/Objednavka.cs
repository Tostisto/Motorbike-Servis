using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Project.Class;

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

        private void GeneratePDF()
        {
            var doc = new Document(PageSize.A4, 50, 50, 50, 50);
            PdfWriter.GetInstance(doc, new FileStream(filePath, FileMode.Create));
            doc.Open();


            doc.AddTitle("This is Title");

            doc.Add(new Paragraph("\n"));

            var table = new PdfPTable(4);
            table.WidthPercentage = 100;
            table.SetWidths(new float[] { 1, 3, 1, 1 });

            var cell = new PdfPCell(new Phrase("ID objednávky"));
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Product"));
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Typ servisu"));
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);

            cell = new PdfPCell(new Phrase("Cena"));
            cell.HorizontalAlignment = 1;
            table.AddCell(cell);

            foreach (var order in user_orders)
            {
                table.AddCell(order.Id.ToString());
                table.AddCell(order.Service);
                table.AddCell(order.Product);
                table.AddCell(order.Price.ToString());
            }

            doc.Add(table);

            doc.Add(new Paragraph("\n"));
            doc.Add(new Paragraph("\n"));

            doc.Add(new Paragraph("Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum."));

            doc.Close();
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
