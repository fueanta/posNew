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
            DoRefresh();
            types = Software.Database.SQL.Customer_TypeDB.GetAllCustomerTypes();
            typeComboBox.DataSource = types;
            typeComboBox.ValueMember = "Id";
            typeComboBox.DisplayMember = "Type_Title";
        }

        private void table_SelectionChanged(object sender, System.EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];
                pictureBox.ImageLocation = Convert.ToString(selectedRow.Cells["Picture"].Value);
                nameBox.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                contactBox.Text = Convert.ToString(selectedRow.Cells["Contact_No"].Value);
                emailBox.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                addressBox.Text = Convert.ToString(selectedRow.Cells["Address"].Value);

                Software.Model.Customer_Type type = types.Single(t => t.Id == Convert.ToInt32(Convert.ToString(selectedRow.Cells["Type_Id"].Value)));
                typeComboBox.SelectedIndex = typeComboBox.FindStringExact(type.Type_Title);
            }
        }

        public void DoRefresh()
        {
            customers = Software.Database.SQL.CustomerDB.GetAllCustomers();
            table.DataSource = customers;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            new CreateCustomer().ShowDialog(this);
            DoRefresh();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                Software.Model.Customer customer = new Software.Model.Customer();

                selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];

                customer.Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                customer.Name = nameBox.Text;
                customer.Contact_No = contactBox.Text;
                customer.Email = emailBox.Text;
                customer.Address = addressBox.Text;
                customer.Type_Id = ((Software.Model.Customer_Type)typeComboBox.SelectedItem).Id;
                customer.Picture = pictureBox.ImageLocation;

                Software.Database.SQL.CustomerDB.UpdateCustomer(customer);

                MetroFramework.MetroMessageBox.Show(this, "Your data has been updated successfully.", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to update its value!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoRefresh();
            table.CurrentCell = table.Rows[selectedRowIndex].Cells[0];
            table.Rows[selectedRowIndex].Selected = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];
                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                Software.Database.SQL.CustomerDB.DeleteCustomer(id);
                MetroFramework.MetroMessageBox.Show(this, "Data has been deleted!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            DoRefresh();
            

        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images| *.JPG; *.PNG; *.GJF"; // you can add any other image type 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = ofd.FileName;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            List<Software.Model.Customer> selectedCustomers = customers.Where(c => c.Name.ToLower().Contains(searchBox.Text.ToLower())).ToList();
            table.DataSource = selectedCustomers;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

}
