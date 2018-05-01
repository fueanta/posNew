using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class HomePage : MetroFramework.Forms.MetroForm
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void tileCustomer_Click(object sender, EventArgs e)
        {
            CustomersViews cust = new CustomersViews();
            cust.Show();
            this.Hide();
        }
    }
}
