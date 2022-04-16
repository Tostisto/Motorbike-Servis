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
            User_Pages.Reservation reservation = new User_Pages.Reservation(user);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            User_Pages.UserSetting userSetting = new User_Pages.UserSetting(user);
            userSetting.TopLevel = false;
            container.Controls.Add(userSetting);
            userSetting.FormBorderStyle = FormBorderStyle.None;
            userSetting.Dock = DockStyle.Fill;
            userSetting.Show();
        }

        private void userInfoName_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            User_Pages.UserSetting userSetting = new User_Pages.UserSetting(user);
            userSetting.TopLevel = false;
            container.Controls.Add(userSetting);
            userSetting.FormBorderStyle = FormBorderStyle.None;
            userSetting.Dock = DockStyle.Fill;
            userSetting.Show();
        }
    }
}
