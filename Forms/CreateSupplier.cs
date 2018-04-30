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
    public partial class CreateSupplier : MetroFramework.Forms.MetroForm
    {
        public CreateSupplier()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Software.Model.Supplier supplier = new Software.Model.Supplier();
            supplier.Name = nameBox.Text;
            supplier.Contact_No = contactBox.Text;
            supplier.Email = emailBox.Text;
            supplier.Address = addressBox.Text;
            supplier.Date_Added = dateTime.Value;
            supplier.Description = descriptionBox.Text;

            Software.Database.SQL.SupplierDB.InsertSupplier(supplier);
            MetroFramework.MetroMessageBox.Show(this, "Your data has been created.", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

    }
}
