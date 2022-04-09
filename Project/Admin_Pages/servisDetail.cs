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
    public partial class servisDetail : Form
    {
        Services servis = new Services();
        
        public servisDetail(Services servis)
        {
            this.servis = servis;

            InitializeComponent();

            User user = Database.SpecificSelect<User>($"Id = {servis.UserID}").FirstOrDefault();

            this.userName.Text = $"{user.FirstName} {user.LastName}";
            this.brand_textbox.Text = servis.Brand;
            this.model_textbox.Text = servis.Model;
            this.year_textbox.Text = servis.Year.ToString();
            this.spz_textbox.Text = servis.SPZ;
            this.show_textbox.Text = servis.Shop;
            this.description_textbox.Text = servis.Description;
        }

        private void acceptBTN_Click(object sender, EventArgs e)
        {

            this.servis.Status = "Accepted";
            Database.Update<Services>(this.servis);
            this.Close();
        }

        private void dismissBTN_Click(object sender, EventArgs e)
        {
            this.servis.Status = "Dismissed";
            Database.Update<Services>(this.servis);
            this.Close();
        }
    }
}
