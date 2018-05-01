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
    public partial class CustomersViews : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Customer> customers = null;
        List<Software.Model.Customer_Type> types = null;
        public CustomersViews()
        {
            InitializeComponent();
            customers = Software.Database.SQL.CustomerDB.GetAllCustomers();
            table.DataSource = customers;
            types = Software.Database.SQL.Customer_TypeDB.GetAllCustomerTypes();
            typeComboBox.DataSource = types;
            typeComboBox.ValueMember = "Id";
            typeComboBox.DisplayMember = "Type_Title";
        }

        private void table_SelectionChanged(object sender, System.EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                pictureBox.ImageLocation = Convert.ToString(selectedRow.Cells["Picture"].Value);
                nameBox.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                contactBox.Text = Convert.ToString(selectedRow.Cells["Contact_No"].Value);
                emailBox.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                addressBox.Text = Convert.ToString(selectedRow.Cells["Address"].Value);

                Software.Model.Customer_Type type = types.Single(t => t.Id == Convert.ToInt32(Convert.ToString(selectedRow.Cells["Type_Id"].Value)));
                typeComboBox.SelectedIndex = typeComboBox.FindStringExact(type.Type_Title);
            }

        }
    }

}
