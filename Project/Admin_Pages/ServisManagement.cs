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

namespace Project.Admin_Pages
{
    public partial class ServisManagement : Form
    {
        public static BindingList<Services> list_services = new BindingList<Services>()
        {
            new Services(0, "BMW", "Test", 2000, "JDKS32JKD", "Brno", "Some random text", false),
            new Services(1, "BMW", "Test", 1998, "WE32DSDS", "Brno", "Some random text", false),
            new Services(2, "BMW", "Test", 2005, "32DSD32D", "Praha", "Some random text", false),
            new Services(3, "BMW", "Test", 2012, "JDKS32JKD", "Ostrava", "Some random text", false),
            new Services(4, "BMW", "Test", 2008, "JDKS32JKD", "olomouc", "Some random text", false)
        };

        public ServisManagement()
        {
            InitializeComponent();

            this.servicesManage.AutoGenerateColumns = false;
            this.servicesManage.DataSource = list_services;

            this.servicesManage.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Brand",
                DataPropertyName = nameof(Services.Brand)
            });

            this.servicesManage.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Model",
                DataPropertyName = nameof(Services.Model)
            });

            this.servicesManage.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Year",
                DataPropertyName = nameof(Services.Year)
            });


            DataGridViewButtonColumn dismissBTN = new DataGridViewButtonColumn()
            {
                Text = "Dismiss",
                HeaderText = "Dismiss",
                Name = "dismissBTN",
                UseColumnTextForButtonValue = true,
            };
            dismissBTN.FlatStyle = FlatStyle.Flat;
            dismissBTN.DefaultCellStyle.BackColor = Color.Red;
            this.servicesManage.Columns.Add(dismissBTN);


            DataGridViewButtonColumn aceptBTN = new DataGridViewButtonColumn()
            {
                Text = "Accept",
                HeaderText = "Accept",
                Name = "acceptBTN",
                UseColumnTextForButtonValue = true
            };
            aceptBTN.FlatStyle = FlatStyle.Flat;
            aceptBTN.DefaultCellStyle.BackColor = Color.Green;
            this.servicesManage.Columns.Add(aceptBTN);


            this.servicesManage.Columns.Add(new DataGridViewButtonColumn()
            {
                Text = "Details",
                HeaderText = "Detail",
                Name = "detailBTN",
                UseColumnTextForButtonValue = true
            });


        }

        private void servicesManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var column = this.servicesManage.Columns[e.ColumnIndex];
            var row = this.servicesManage.Rows[e.RowIndex];

            if (column == null)
            {
                return;
            }
            else if (column.Name == "detailBTN")
            {
                servisDetail detail = new servisDetail();
                detail.ShowDialog();
            }
            else if (column.Name == "dismissBTN")
            {
                // TODO
            }
            else if(column.Name == "acceptBTN")
            {
                // TODO
            }
        }
    }
}
