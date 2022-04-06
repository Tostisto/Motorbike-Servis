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

        BindingList<Orders> user_orders = new BindingList<Orders>();

        User user = new User();

        public Objednavka(User user)
        {
            this.user = user;
            
            InitializeComponent();

            user_orders = Database.SpecificSelect<Orders>($"UserID = {user.Id}");

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
    }
}
