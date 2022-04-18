namespace Project
{
    public partial class Admin_page : Form
    {
        User user = new User();
        
        public Admin_page(User user)
        {
            InitializeComponent();

            this.user = user;

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
