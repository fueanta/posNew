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
    public partial class DataViews : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Data> Data = null;

        public DataViews()
        {
            InitializeComponent();
            DoRefresh();
        }

        public void DoRefresh()
        {
            Data = Software.Database.SQL.DataDB.GetAllChangelog();
            table.DataSource = Data;
        }

        private void table_SelectionChanged(object sender, System.EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                nameBox.Text = Convert.ToString(selectedRow.Cells["Data_Name"].Value);
                valueBox.Text = Convert.ToString(selectedRow.Cells["Data_Value"].Value);                
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            new CreateData().ShowDialog(this);
            DoRefresh();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = 0;
            if (table.SelectedCells.Count > 0)
            {
                selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                Software.Database.SQL.DataDB.DeleteData(id);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            DoRefresh();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                Software.Model.Data Data = new Software.Model.Data();

                selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];

                Data.Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                Data.Data_Name = nameBox.Text;
                Data.Data_Value = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Data_Value"].Value));


                Software.Database.SQL.DataDB.UpdateData(Data);

                MetroFramework.MetroMessageBox.Show(this, "Your data has been updated successfully.", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to update its value!", "Invalid Selection");

            DoRefresh();
            table.CurrentCell = table.Rows[selectedRowIndex].Cells[0];
            table.Rows[selectedRowIndex].Selected = true;
        }
    }
}
