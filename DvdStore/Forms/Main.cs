using DvdStore.Forms;
using System.Windows.Forms;

namespace DvdStore
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void TsbCustomer_Click(object sender, System.EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();            
            customerForm.ShowDialog();
        }

        private void TsbRental_Click(object sender, System.EventArgs e)
        {
            RentalForm rentalForm = new RentalForm();
            rentalForm.ShowDialog();
        }

        private void TsbDvd_Click(object sender, System.EventArgs e)
        {
            DvdForm dvdForm = new DvdForm();
            dvdForm.ShowDialog();
        }
    }
}
