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

        private void tileEmployeeManagerHRD_Click(object sender, EventArgs e)
        {
            CustomersViews customer = new CustomersViews();
            customer.Show();
            this.Hide();
            
        }
    }
}
