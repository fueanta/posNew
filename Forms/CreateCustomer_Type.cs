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
    public partial class CreateCustomer_Type : MetroFramework.Forms.MetroForm
    {
        public CreateCustomer_Type()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
