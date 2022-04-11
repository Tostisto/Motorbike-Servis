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

            if (inputEmail == "" || inputPassword == "")
            {
                MessageBox.Show("Please fill in all fields!");
                return;
            }

            User loginUser = new User();
            loginUser = Database.SpecificSelect<User>($"email = '{inputEmail}' and password = '{inputPassword}'").FirstOrDefault();

            if (loginUser != null)
            {
                if(loginUser.Role == "admin")
                {
                    this.Hide();
                    Admin_page admin = new Admin_page(all_users[0]);
                    admin.ShowDialog();
                    this.Show();
                }
                else
                {
                    this.Hide();
                    User_Window user_Window = new User_Window(all_users[0]);
                    user_Window.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Wrong email or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}