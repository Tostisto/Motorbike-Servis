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

namespace Project.User_Pages
{
    public partial class Servis : Form
    {
        User user = new User();
        
        public Servis(User user)
        {
            this.user = user;

            InitializeComponent();
        }

        private void add_servis_Click(object sender, EventArgs e)
        {
            try
            {
                Services newServis = new Services(user.Id, brand_textBox.Text, model_textBox.Text, (int)year_input.Value, spz_textbox.Text, place.SelectedText.ToString(), message_textBox.Text, "new");

                Database.insert<Services>(newServis);

                MessageBox.Show("Servis byl úspěšně přidán", "Přidání servisu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
