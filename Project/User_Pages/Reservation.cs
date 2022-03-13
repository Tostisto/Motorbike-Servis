using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.User_Pages
{
    public partial class Reservation : Form
    {

        public List<Motorbike> motorbikes = new List<Motorbike>()
        {
            new Motorbike("fdasfa_32dsjk", "Harley-Davidson Low Rider", 1200, "free", "The Low Rider FXS1200 was a big game changer for Harley, allowing the factory custom bikes to come out in full force; chopper bolt-ons, lowered rear-end and so much CHROME! This created a whole new direction for Harley and the custom gang.Today the Low Rider is a highly collectable item and very rarely will you see one up for auction.", "https://www.devittinsurance.com/wp-content/uploads/2016/02/Harley-Davidson-Low-Rider-credit-total-motorcycle.jpg"),
            new Motorbike("dsajkldsa", "Ducati Pantah 500SL", 2500, "free", "This 1979 model is argued to be the first ‘modern’ Ducati motorcycle ever, although it may be overshadowed by the 900SS and the 916 – the Pantah has a worthy place in our top 80 motorcycles! The machine was the first ever belt rather than bevel driven Duke which became the basis of the 951, 916 and many more models.", "https://www.devittinsurance.com/wp-content/uploads/2016/02/Ducati-Pantah-500SL-credit-topspeed.jpg"),
            new Motorbike("djskahio_32dnsjkl", "Ducati 350 Desmo", 3000, "free", "The Desmo created Ducati history in 1968 and that’s why you’ve voted in as one of the top 80 motorcycles ever. The first desmodromic production motorcycle ever created by Ducati whch produced just 22bhp meaning the machine was light and playful. Since then Ducati have produced a whole range of motorcycles, 250, 450 and off-roaders from the Desmo!", "https://www.devittinsurance.com/wp-content/uploads/2016/02/Ducati-350-Desmo-credit-Topspeed.jpg")
        };

        public Reservation()
        {
            InitializeComponent();

            this.motorbike_combobox.DataSource = motorbikes;

            this.motorbike_combobox.DisplayMember = "Name";
            this.motorbike_combobox.SelectAll();

        }

        private void motorbike_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox senderComboBox = (ComboBox)sender;

            var motorbike = senderComboBox.SelectedItem as Motorbike;

            try
            {
                this.motorbike_preview_image.Load(motorbike.Image_link);
                this.price.Text = motorbike.Price.ToString();
                this.motorbike_description.Text = motorbike.Description.ToString();
            }
            catch (InvalidOperationException)
            {
                this.motorbike_preview_image.Load("https://developers.google.cn/maps/documentation/streetview/images/error-image-generic.png");
            }
        }
    }
}
