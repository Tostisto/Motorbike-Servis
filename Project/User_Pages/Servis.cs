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

        private async void add_servis_Click(object sender, EventArgs e)
        {
            try
            {
                Services newServis = new Services(user.Id, brand_textBox.Text, model_textBox.Text, (int)year_input.Value, spz_textbox.Text, place.SelectedItem.ToString(), message_textBox.Text, "new");

                await Database.insert<Services>(newServis);

                MessageBox.Show("Servis byl úspěšně přidán", "Přidání servisu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.brand_textBox.Text = "";
            this.model_textBox.Text = "";

            this.spz_textbox.Text = "";
            this.message_textBox.Text = "";
        }

        private void brand_textBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(brand_textBox.Text))
            {
                e.Cancel = true;
                brand_textBox.Focus();
                servirErrorProvider.SetError(brand_textBox, "Brand should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                servirErrorProvider.SetError(brand_textBox, "");
            }
        }

        private void model_textBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(model_textBox.Text))
            {
                e.Cancel = true;
                model_textBox.Focus();
                servirErrorProvider.SetError(model_textBox, "Model should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                servirErrorProvider.SetError(model_textBox, "");
            }
        }

        private void spz_textbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(spz_textbox.Text))
            {
                e.Cancel = true;
                spz_textbox.Focus();
                servirErrorProvider.SetError(spz_textbox, "SPZ should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                servirErrorProvider.SetError(spz_textbox, "");
            }
        }

        private void message_textBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(message_textBox.Text))
            {
                e.Cancel = true;
                message_textBox.Focus();
                servirErrorProvider.SetError(message_textBox, "Message should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                servirErrorProvider.SetError(message_textBox, "");
            }
        }
    }
}
