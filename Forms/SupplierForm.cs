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
    public partial class SupplierForm : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Supplier> suppliers = null;
        public SupplierForm()
        {
            InitializeComponent();
            DoRefresh();
            
        }

        private void table_SelectionChanged(object sender, EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                nameBox.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                contactBox.Text = Convert.ToString(selectedRow.Cells["Contact_No"].Value);
                emailBox.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                addressBox.Text = Convert.ToString(selectedRow.Cells["Address"].Value);
                dateTime.Value = Convert.ToDateTime(selectedRow.Cells["Date_Added"].Value);
                descriptionBox.Text = Convert.ToString(selectedRow.Cells["Description"].Value);
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            List<Software.Model.Supplier> selectedSuppliers = suppliers.Where(i => i.Name.ToLower().Contains(searchBox.Text.ToLower())).ToList();
            table.DataSource = selectedSuppliers;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            new CreateSupplier().ShowDialog(this);
            DoRefresh();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = 0;
            if (table.SelectedCells.Count > 0)
            {
                Software.Model.Supplier supplier = new Software.Model.Supplier();

                selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];

                supplier.Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                supplier.Name = nameBox.Text;
                supplier.Contact_No = contactBox.Text;
                supplier.Email = emailBox.Text;
                supplier.Address = addressBox.Text;
                supplier.Date_Added = dateTime.Value;
                supplier.Description = descriptionBox.Text;

                Software.Database.SQL.SupplierDB.UpdateSupplier(supplier);

                MetroFramework.MetroMessageBox.Show(this, "Your data has been updated.", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to update its value!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoRefresh();
            table.Rows[selectedrowindex].Selected = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = 0;
            if (table.SelectedCells.Count > 0)
            {
                selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                Software.Database.SQL.SupplierDB.DeleteSupplier(id);
                MetroFramework.MetroMessageBox.Show(this, "Your data has been deleted.", "Successfully Deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoRefresh();
        }

        public void DoRefresh()
        {
            suppliers = Software.Database.SQL.SupplierDB.GetAllSuppliers();
            table.DataSource = suppliers;
        }

    }
}