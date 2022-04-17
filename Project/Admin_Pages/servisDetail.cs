using Project.Class;

namespace Project.Admin_Pages
{
    public partial class servisDetail : Form
    {
        Services servis = new Services();

        User user = new User();

        public servisDetail(Services servis)
        {
            this.servis = servis;

            InitializeComponent();

            user = Database.SpecificSelect<User>($"Id = {servis.UserID}").FirstOrDefault();

            this.userName.Text = $"{user.FirstName} {user.LastName}";
            this.brand_textbox.Text = servis.Brand;
            this.model_textbox.Text = servis.Model;
            this.year_textbox.Text = servis.Year.ToString();
            this.spz_textbox.Text = servis.SPZ;
            this.show_textbox.Text = servis.Shop;
            this.description_textbox.Text = servis.Description;
        }

        private async void acceptBTN_Click(object sender, EventArgs e)
        {
            this.servis.Status = "Accepted";
            Database.Update<Services>(this.servis);

            await Email.ServisEmail(user, "schválená", servis);

            this.Close();
        }

        private async void dismissBTN_Click(object sender, EventArgs e)
        {
            this.servis.Status = "Dismissed";
            Database.Update<Services>(this.servis);
            
            await Email.ServisEmail(user, "zamitnuta", servis);

            this.Close();
        }
    }
}
