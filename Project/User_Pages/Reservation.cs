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
    public partial class Reservation : Form
    {
        public BindingList<Motorbike> motorbikes = new BindingList<Motorbike>();

        public List<DateTime> dates = new List<DateTime>();

        User user = new User();
        
        public Reservation(User user)
        {
            this.user = user;
            
            InitializeComponent();
            
            motorbikes = Database.select<Motorbike>();

            this.motorbike_combobox.DataSource = motorbikes;

            this.motorbike_combobox.DisplayMember = "Name";

            this.motorbike_combobox.SelectAll();
        }


        private void UpdateCalendarDates(int motorbikeID)
        {
            BindingList<Reservations> reservations = Database.SpecificSelect<Reservations>($"MotorbikeID = {motorbikeID}");

            foreach (Reservations reservation in reservations)
            {
                DateTime from = DateTime.Parse(reservation.From_Date);
                DateTime to = DateTime.Parse(reservation.To_Date);

                for (DateTime date = from; date <= to; date = date.AddDays(1))
                {
                    dates.Add(date);
                }
                calendar.BoldedDates = dates.ToArray();
            }
        }

        private void motorbike_combobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dates.RemoveAll(x => true);
            calendar.BoldedDates = dates.ToArray();
            
            ComboBox senderComboBox = (ComboBox)sender;
            
            var motorbike = senderComboBox.SelectedItem as Motorbike;
            UpdateCalendarDates(motorbike.Id);

            try
            {
                this.motorbike_preview_image.LoadAsync(motorbike.Image);
                this.price.Text = motorbike.Price.ToString();
                this.motorbike_description.Text = motorbike.Description.ToString();
            }
            catch (InvalidOperationException)
            {
                this.motorbike_preview_image.LoadAsync("https://developers.google.cn/maps/documentation/streetview/images/error-image-generic.png");
            }
        }

        private float getTotalPrice(int days, int Price)
        {
            return days * Price;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Motorbike selectedMotorbike = new Motorbike();

            selectedMotorbike = (Motorbike)this.motorbike_combobox.SelectedItem;

            int days = (int)(calendar.SelectionEnd - calendar.SelectionStart).TotalDays + 1;

            float price = getTotalPrice(days, selectedMotorbike.Price);


            if (calendar.SelectionStart.Date.CompareTo(calendar.SelectionEnd.Date) == 0)
            {
                if (dates.Contains(calendar.SelectionStart.Date))
                {
                    MessageBox.Show("The selected date is already booked", "Cannot Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                for (DateTime date = calendar.SelectionStart.Date; date <= calendar.SelectionEnd.Date; date = date.AddDays(1))
                {
                    if (dates.Contains(date))
                    {
                        MessageBox.Show("The selected date is already booked", "Cannot Book", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            Reservations newReservation = new Reservations(user.Id, selectedMotorbike.Id, this.calendar.SelectionStart.ToString(), this.calendar.SelectionEnd.ToString(), "Reserved");
            Database.insert<Reservations>(newReservation);

            Orders order = new Orders(user.Id, selectedMotorbike.Name, "Reservation", price, 0);
            Database.insert<Orders>(order);

            MessageBox.Show("Reservation Successful", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
