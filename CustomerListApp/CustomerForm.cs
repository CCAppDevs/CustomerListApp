using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerListApp
{
    public partial class CustomerForm : Form
    {
        public string data { get; set; }

        public CustomerForm(string test)
        {
            InitializeComponent();
            data = test;
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            label1.Text = "Customer Name:";
        }
    }
}
