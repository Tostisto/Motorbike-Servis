using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;

namespace Project.Admin_Pages
{
    public partial class New_motorbike : Form
    {
        public New_motorbike()
        {
            InitializeComponent();
        }

        private void test_link_button_Click(object sender, EventArgs e)
        {
            string link = this.image_link.Text;

            try
            {
                this.new_motorbike_image.LoadAsync(link);
            }
            catch (InvalidOperationException)
            {
                this.new_motorbike_image.Load("https://developers.google.cn/maps/documentation/streetview/images/error-image-generic.png");
            }
        }

        private void add_motorbike_BTN_Click(object sender, EventArgs e)
        {
            Motorbike new_motorbike = new Motorbike(this.admin_add_motorbike_name.Text, int.Parse(this.admin_add_motorbike_price.Text), this.admin_add_motorbike_description.Text, image_link.Text);

            Database.insert<Motorbike>(new_motorbike);

            MessageBox.Show("Motorbike added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void admin_add_motorbike_price_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int.Parse(this.admin_add_motorbike_price.Text);
            }
            catch
            {
                e.Cancel = true;
                this.admin_add_motorbike_price.Focus();
                errorProvider1.SetError(this.admin_add_motorbike_price, $"Something wrong with price");
            }
            finally
            {
                e.Cancel = false;
                errorProvider1.SetError(this.admin_add_motorbike_price, "");
            }
        }
    }
}
