using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Forms
{
    public partial class Unit_TypeViews : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Unit_Type> types = null;
        public Unit_TypeViews()
        {
            InitializeComponent();
            DoRefresh();
        }

        private void table_SelectionChanged(object sender, System.EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                nameBox.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                symbolBox.Text = Convert.ToString(selectedRow.Cells["Symbol"].Value);
            }
        }

        public void DoRefresh()
        {
            types = Software.Database.SQL.Unit_TypeDB.GetAllUnit_Types();
            table.DataSource = types;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            new CreateUnit_Type().ShowDialog(this);
            DoRefresh();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                Software.Model.Unit_Type type = new Software.Model.Unit_Type();

                selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];

                type.Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                type.Name = nameBox.Text;
                type.Symbol = symbolBox.Text;
                Software.Database.SQL.Unit_TypeDB.UpdateUnit_Type(type);
            }
            else
                MessageBox.Show("You must select a row to update its value!", "Invalid Selection");

            DoRefresh();
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
                Software.Database.SQL.Unit_TypeDB.DeleteUnit_Type(id);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DoRefresh();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            List<Software.Model.Unit_Type> selectedTypes = types.Where(t => t.Name.ToLower().Contains(searchBox.Text.ToLower())).ToList();
            table.DataSource = selectedTypes;
        }

    }
}
