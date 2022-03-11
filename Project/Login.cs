namespace Project
{
    public partial class Login : Form
    {

        public User testUser = new User("dskjlab32bjk_32BJ32", "jakub", "czepiec", "kuba@kuba", "kuba", new DateOnly(100, 10, 10));


        public Login()
        {
            InitializeComponent();

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
            User_Window user_Window = new User_Window(testUser);
            user_Window.ShowDialog();
            this.Show();
        }
    }
}