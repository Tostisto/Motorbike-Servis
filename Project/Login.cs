using System.ComponentModel;

namespace Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();


            if (!File.Exists("MotoServis.db"))
            {
                Task.WhenAll(Database.initDatabase());
            }

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
                    Admin_page admin = new Admin_page(loginUser);
                    admin.ShowDialog();
                    this.Show();
                }
                else if (loginUser.Role == "user")
                {
                    this.Hide();
                    User_Window user_Window = new User_Window(loginUser);
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