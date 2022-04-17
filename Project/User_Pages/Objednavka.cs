using PdfSharpCore.Drawing;
using PdfSharpCore.Pdf;
using Project.Class;
using System.ComponentModel;
using System.Data;

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
                this.total_price.Text = "All orders are paid";
            }
            else
            {
                this.invoiceBTN.Enabled = true;
                totalPrice = user_orders.Select(x => x.Price).Sum();

                this.total_price.Text = totalPrice.ToString() + " Kč";
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


        }


        public void GeneratePDF()
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Created with PDFsharp";

            PdfPage page = document.AddPage();

            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont font = new XFont("Arial", 20, XFontStyle.Bold);
            gfx.DrawString("Objednávka", font, XBrushes.Black, new XRect(0, 30, page.Width, page.Height), XStringFormats.TopCenter);

            XFont font2 = new XFont("Arial", 12, XFontStyle.Regular);
            gfx.DrawString($"Jmeno: {user.FirstName} {user.LastName}", font2, XBrushes.Black, new XRect(50, 100, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Email: {user.Email}", font2, XBrushes.Black, new XRect(50, 120, page.Width, page.Height), XStringFormats.TopLeft);
            gfx.DrawString($"Datum: {DateTime.Now}", font2, XBrushes.Black, new XRect(50, 140, page.Width, page.Height), XStringFormats.TopLeft);


            XFont font3 = new XFont("Arial", 10, XFontStyle.Regular);

            XRect tableRect = new XRect(-150, 200, page.Width, page.Height);
            gfx.DrawString("Objednávka", font3, XBrushes.Black, tableRect, XStringFormats.TopCenter);
            XRect tableRect2 = new XRect(-50, 200, page.Width, page.Height);
            gfx.DrawString("Motorbike", font3, XBrushes.Black, tableRect2, XStringFormats.TopCenter);
            XRect tableRect3 = new XRect(50, 200, page.Width, page.Height);
            gfx.DrawString("Service Type", font3, XBrushes.Black, tableRect3, XStringFormats.TopCenter);
            XRect tableRect4 = new XRect(150, 200, page.Width, page.Height);
            gfx.DrawString("Price", font3, XBrushes.Black, tableRect4, XStringFormats.TopCenter);

            XPen pen = new XPen(XColors.Black, 1);
            gfx.DrawLine(pen, new XPoint(100, 215), new XPoint(page.Width - 100, 215));

            int i = 0;

            foreach (Orders order in user_orders)
            {
                XRect tableRect5 = new XRect(-150, 220 + i, page.Width, page.Height);
                gfx.DrawString(order.Id.ToString(), font3, XBrushes.Black, tableRect5, XStringFormats.TopCenter);

                XRect tableRect6 = new XRect(-50, 220 + i, page.Width, page.Height);
                gfx.DrawString(order.Product, font3, XBrushes.Black, tableRect6, XStringFormats.TopCenter);

                XRect tableRect7 = new XRect(50, 220 + i, page.Width, page.Height);
                gfx.DrawString(order.Service, font3, XBrushes.Black, tableRect7, XStringFormats.TopCenter);

                XRect tableRect8 = new XRect(150, 220 + i, page.Width, page.Height);
                gfx.DrawString(order.Price.ToString(), font3, XBrushes.Black, tableRect8, XStringFormats.TopCenter);

                i += 20;
            }

            XRect tableRect9 = new XRect(50, 260 + i, page.Width, page.Height);
            gfx.DrawString($"Celková cena: {totalPrice}", font3, XBrushes.Black, tableRect9, XStringFormats.TopLeft);

            document.Save(filePath);
        }


        public void UpdateOrders()
        {
            foreach (var order in user_orders)
            {
                order.Status = 1;
                Thread thread = new Thread(() => Database.Update<Orders>(order));
                thread.Start();
            }
        }

        private async void invoiceBTN_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save an Image File";
            save.Filter = "PDF File|*.pdf";
            save.ShowDialog();
            filePath = save.FileName;

            Thread thread = new Thread(GeneratePDF);
            thread.Start();

            Thread thread2 = new Thread(UpdateOrders);
            thread2.Start();

            thread.Join();
            thread2.Join();
            this.user_orders.Clear();
            this.total_price.Text = "All orders are paid";

            MessageBox.Show("Thanks for your order!");

            await Email.OrderEmail(user, totalPrice);
        }
    }
}
