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
            var newCustomerForm = new CustomerForm();
            newCustomerForm.ShowDialog();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            // fire code to edit the selected customer form
            var customerForm = new CustomerForm();
            
            // add customer data (this is temporary)
            customerForm.LoadCustomer(new Customer { 
                FirstName = "Jesse",
                LastName = "Harlan",
                Email = "jesse.harlan@centralia.edu",
                Phone = "555-555-5555"
            });

            customerForm.ShowDialog();
        }
    }
}
