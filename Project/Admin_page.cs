using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Admin_page : Form
    {
        public Admin_page(User user)
        {
            InitializeComponent();

            this.userInfoName.Text = user.FirstName + " " + user.LastName;

            container.Controls.Clear();
            Admin_Pages.New_motorbike new_Motorbike = new Admin_Pages.New_motorbike();
            new_Motorbike.TopLevel = false;
            container.Controls.Add(new_Motorbike);
            new_Motorbike.FormBorderStyle = FormBorderStyle.None;
            new_Motorbike.Dock = DockStyle.Fill;
            new_Motorbike.Show();
            this.indicator.Location = new Point(this.objednavka_btn.Location.X, this.objednavka_btn.Location.Y);
        }

        private void objednavka_btn_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            Admin_Pages.New_motorbike new_Motorbike = new Admin_Pages.New_motorbike();
            new_Motorbike.TopLevel = false;
            container.Controls.Add(new_Motorbike);
            new_Motorbike.FormBorderStyle = FormBorderStyle.None;
            new_Motorbike.Dock = DockStyle.Fill;
            new_Motorbike.Show();
            this.indicator.Location = new Point(this.objednavka_btn.Location.X, this.objednavka_btn.Location.Y);
        }

        private void reservation_button_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            Admin_Pages.ServisManagement servisManagement = new Admin_Pages.ServisManagement();
            servisManagement.TopLevel = false;
            container.Controls.Add(servisManagement);
            servisManagement.FormBorderStyle = FormBorderStyle.None;
            servisManagement.Dock = DockStyle.Fill;
            servisManagement.Show();
            this.indicator.Location = new Point(this.servis_manage_Button.Location.X, this.servis_manage_Button.Location.Y);
        }
        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
