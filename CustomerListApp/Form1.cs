using System.ComponentModel;

namespace CustomerListApp
{
    public partial class Form1 : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public List<Customer> Customers { get; set; }

        public Form1()
        {
            InitializeComponent();
            Customers = new List<Customer>();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            // fire code to create a new customer form

            var test = "test data";

            var newCustomerForm = new CustomerForm(test);
            newCustomerForm.ShowDialog();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            // fire code to edit the selected customer form
        }
    }
}
