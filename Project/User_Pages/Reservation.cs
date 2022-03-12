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
            new Motorbike("fdasfa_32dsjk", "BMW R100S", 1200, "free"),
            new Motorbike("dsajkldsa", "Test test", 200, "Rented"),
            new Motorbike("dsdsdsd", "test2 test2", 3000, "free"),
        };

        public Reservation()
        {
            InitializeComponent();
        }
    }
}
