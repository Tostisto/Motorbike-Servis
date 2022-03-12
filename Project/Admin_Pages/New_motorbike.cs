using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            this.new_motorbike_image.Load(link);
        }
    }
}
