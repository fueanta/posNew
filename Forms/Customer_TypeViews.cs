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
    public partial class Customer_TypeViews : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Customer_Type> types = null;
        public Customer_TypeViews()
        {
            InitializeComponent();
            types = Software.Database.SQL.Customer_TypeDB.GetAllCustomerTypes();
            table.DataSource = types;
        }

        private void table_SelectionChanged(object sender, EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                typeTitleBox.Text = Convert.ToString(selectedRow.Cells["Type_Title"].Value);
                orderCountBox.Text = Convert.ToString(selectedRow.Cells["Order_Count"].Value);
                totalBillBox.Text = Convert.ToString(selectedRow.Cells["Total_Bill"].Value);
                discountBox.Text = Convert.ToString(selectedRow.Cells["Discount_Rate"].Value);
            }
        }

        public void DoRefresh()
        {
            table.DataSource = Software.Database.SQL.Customer_TypeDB.GetAllCustomerTypes();
            //table.Refresh();            
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            new CreateCustomer_Type().ShowDialog(this);
            DoRefresh();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                Software.Model.Customer_Type type = new Software.Model.Customer_Type();

                selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];

                type.Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                type.Type_Title = typeTitleBox.Text;
                type.Order_Count = Convert.ToInt32(orderCountBox.Text);
                type.Total_Bill = Convert.ToInt32(totalBillBox.Text);
                type.Discount_Rate = Convert.ToInt32(discountBox.Text);
                Software.Database.SQL.Customer_TypeDB.UpdateCustomer_Type(type);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to update its value!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            DoRefresh();
            table.CurrentCell = table.Rows[selectedRowIndex].Cells[0];
            table.Rows[selectedRowIndex].Selected = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = 0;
            if (table.SelectedCells.Count > 0)
            {
                selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                Software.Database.SQL.Customer_TypeDB.DeleteCustomer_Type(id);
                MetroFramework.MetroMessageBox.Show(this, "Deleted the record successfully!", "Deletion Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DoRefresh();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            List<Software.Model.Customer_Type> selectedTypes = types.Where(j => j.Type_Title.ToLower().Contains(searchBox.Text.ToLower())).ToList();
            table.DataSource = selectedTypes;
        }

    }
}
