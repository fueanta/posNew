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
    public partial class OrderView : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.POS_Order> orders = null;
        public OrderView()
        {
            InitializeComponent();
            if (!Login_Form.access.Equals("ADMIN"))
            {
                deleteBtn.Enabled = false;
            }
        }

        private void DoRefresh()
        {
            orders = Software.Database.SQL.OrderDB.GetOrders(fromTime.Value, toTime.Value);
            table.DataSource = orders;
            CalcTotalBill();
        }

        private void CalcTotalBill()
        {
            double bill = 0;
            foreach (var order in orders)
            {
                bill += order.Total_Bill;
            }
            totalLabel.Text = string.Format($"Revenue : BDT. {bill:N}");
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
            billBox.Text = "";
            discountBox.Text = "";
            otherBox.Text = "";
            totalBox.Text = "";
            cardBox.Text = "";
            descriptionBox.Text = "";
        }

        private void table_SelectionChanged(object sender, EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];

                timeBox.Value = Convert.ToDateTime(selectedRow.Cells["Place_Time"].Value);
                employeeBox.Text = Convert.ToString(selectedRow.Cells["Employee_Id"].Value);
                billBox.Text = Convert.ToString(selectedRow.Cells["Bill"].Value);
                discountBox.Text = Convert.ToString(selectedRow.Cells["Discount_Rate"].Value);
                otherBox.Text = Convert.ToString(selectedRow.Cells["Other_Charges"].Value);
                totalBox.Text = Convert.ToString(selectedRow.Cells["Total_Bill"].Value);
                cardBox.Text = Convert.ToString(selectedRow.Cells["CardNumber"].Value);
                descriptionBox.Text = Convert.ToString(selectedRow.Cells["Description"].Value);                
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];
                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                Software.Database.SQL.OrderDB.DeleteOrder(id);
                MetroFramework.MetroMessageBox.Show(this, "Data has been deleted successfully!", "Deletion Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoRefresh();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            new CreateOrder().ShowDialog(this);
            DoRefresh();
        }
    }
}
