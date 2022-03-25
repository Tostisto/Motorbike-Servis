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

namespace Project.User_Pages
{
    public partial class Objednavka : Form
    {

        BindingList<Order> user_orders = new BindingList<Order>()
        {
            new Order(0, "BMW R1200GS", "loan", 1200, true),
            new Order(1, "KTM 1190", "servis", 4500, false),
            new Order(2, "KTM 1190", "servis", 5600, false)
        };

        public Objednavka()
        {
            InitializeComponent();
            
            this.orders_datagrid.AutoGenerateColumns = false;
            this.orders_datagrid.DataSource = user_orders;

            this.orders_datagrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Order ID",
                DataPropertyName = nameof(Order.Id)
            });

            this.orders_datagrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                MinimumWidth = 300,
                HeaderText = "Motorbike",
                DataPropertyName = nameof(Order.Produc)
            });

            this.orders_datagrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Width = 150,
                HeaderText = "Service Type",
                DataPropertyName = nameof(Order.Service)
            });

            this.orders_datagrid.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Width = 150,
                HeaderText = "Price",
                DataPropertyName = nameof(Order.Price)
            });
        }
    }
}
