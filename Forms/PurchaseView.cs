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
    public partial class PurchaseView : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.POS_Purchase> purchases = null;

        public PurchaseView()
        {
            InitializeComponent();

            if (!Login_Form.access.Equals("ADMIN"))
            {
                deleteBtn.Enabled = false;
            }
        }

        private void DoRefresh()
        {
            purchases = Software.Database.SQL.PurchaseDB.GetPurchases(fromTime.Value, toTime.Value);
            table.DataSource = purchases;
            CalcTotalBill();
        }

        private void CalcTotalBill()
        {
            double cost = 0;
            foreach (var purchase in purchases)
            {
                cost += purchase.Total_Cost;
            }
            totalLabel.Text = string.Format($"Total Cost : BDT. {cost:N}");
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            DoClear();
            DoRefresh();
        }

        private void DoClear()
        {
            timeBox.Value = DateTime.Now;
            employeeBox.Text = "";
            supplierBox.Text = "";
            costBox.Text = "";
            discountBox.Text = "";
            totalBox.Text = "";
            descriptionBox.Text = "";
        }

        private void table_SelectionChanged(object sender, EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];

                timeBox.Value = Convert.ToDateTime(selectedRow.Cells["Time"].Value);
                employeeBox.Text = Convert.ToString(selectedRow.Cells["Employee_Id"].Value);
                supplierBox.Text = Convert.ToString(selectedRow.Cells["Supplier_Id"].Value);
                costBox.Text = Convert.ToString(selectedRow.Cells["Cost"].Value);
                discountBox.Text = Convert.ToString(selectedRow.Cells["Discount_Rate"].Value);
                totalBox.Text = Convert.ToString(selectedRow.Cells["Total_Cost"].Value);
                descriptionBox.Text = Convert.ToString(selectedRow.Cells["Description"].Value);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            new CreateOrder().ShowDialog(this);
            DoRefresh();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];
                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                Software.Database.SQL.PurchaseDB.DeletePurchase(id);
                MetroFramework.MetroMessageBox.Show(this, "Data has been deleted successfully!", "Deletion Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoRefresh();
        }

        private void generateBtn_Click_1(object sender, EventArgs e)
        {
            DoClear();
            DoRefresh();
        }
    }
}
