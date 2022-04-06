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
    public partial class User_Window : Form
    {
        public User user = new User();
        
        public User_Window(User loginUser)
        {
            user = loginUser;

            InitializeComponent();

            this.userInfoName.Text = user.FirstName + " " + user.LastName;

            container.Controls.Clear();
            User_Pages.Objednavka objednavka = new User_Pages.Objednavka(user);
            objednavka.TopLevel = false;
            container.Controls.Add(objednavka);
            objednavka.FormBorderStyle = FormBorderStyle.None;
            objednavka.Dock = DockStyle.Fill;
            objednavka.Show();
            this.indicator.Location = new Point(this.objednavka_btn.Location.X, this.objednavka_btn.Location.Y);
        }

        private void objednavka_btn_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            User_Pages.Objednavka objednavka = new User_Pages.Objednavka(user);
            objednavka.TopLevel = false;
            container.Controls.Add(objednavka);
            objednavka.FormBorderStyle = FormBorderStyle.None;
            objednavka.Dock = DockStyle.Fill;
            objednavka.Show();
            this.indicator.Location = new Point(this.objednavka_btn.Location.X, this.objednavka_btn.Location.Y);

        }

        private void reservation_button_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            User_Pages.Reservation reservation = new User_Pages.Reservation();
            reservation.TopLevel = false;
            container.Controls.Add(reservation);
            reservation.FormBorderStyle = FormBorderStyle.None;
            reservation.Dock = DockStyle.Fill;
            reservation.Show();
            this.indicator.Location = new Point(this.reservation_button.Location.X, this.reservation_button.Location.Y);
        }

        private void servis_button_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            User_Pages.Servis servis = new User_Pages.Servis(user);
            servis.TopLevel = false;
            container.Controls.Add(servis);
            servis.FormBorderStyle = FormBorderStyle.None;
            servis.Dock = DockStyle.Fill;
            servis.Show();
            this.indicator.Location = new Point(this.servis_button.Location.X, this.servis_button.Location.Y);
        }

        private void logout_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
