using System.ComponentModel;

namespace Project
{
    public partial class Login : Form
    {

        BindingList<User> all_users = new BindingList<User>();

        public Login()
        {

            all_users = Database.select<User>();

            InitializeComponent();


            if (!File.Exists("MotoServis.db"))
            {
                Task.WhenAll(Database.initDatabase());
            }

            // Password textbox
            this.loginPasswordEntry.Text = "";
            this.loginPasswordEntry.PasswordChar = '*';
        }

        private void registerBTN_Click(object sender, EventArgs e)
        {
            Register newRegister = new Register();
            newRegister.ShowDialog();
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            string inputEmail = this.loginEmailEntry.Text;
            string inputPassword = this.loginPasswordEntry.Text;

            //if (inputEmail == testUser.Email && inputPassword == testUser.Password)
            //{
            //    this.Hide();
            //    User_Window user_Window = new User_Window(testUser);
            //    user_Window.ShowDialog();
            //    this.Show();
            //}
            //else
            //{
            //    DialogResult result = MessageBox.Show("Faild Login");
            //}

            this.Hide();
            User_Window user_Window = new User_Window(all_users[0]);
            user_Window.ShowDialog();
            this.Show();

            this.Hide();
            Admin_page admin = new Admin_page(all_users[0]);
            admin.ShowDialog();
            this.Show();

        }
    }
}