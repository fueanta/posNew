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
    public partial class Food_TypeViews : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Food_Type> types = null;
        public Food_TypeViews()
        {
            InitializeComponent();
            DoRefresh();
        }

        private void DoRefresh()
        {
            types = Software.Database.SQL.Food_TypeDB.GetAllFood_Types();
            table.DataSource = types;
        }

        private void table_SelectionChanged(object sender, EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                nameBox.Text = Convert.ToString(selectedRow.Cells["Type_Name"].Value);
                descriptionBox.Text = Convert.ToString(selectedRow.Cells["Description"].Value);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            new CreateFood_Type().ShowDialog(this);
            DoRefresh();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                Software.Model.Food_Type type = new Software.Model.Food_Type();

                selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];

                type.Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                type.Type_Name = nameBox.Text;
                type.Description = descriptionBox.Text;
                Software.Database.SQL.Food_TypeDB.UpdateFood_Type(type);
                MetroFramework.MetroMessageBox.Show(this, "Your data has been updated.", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to update its value!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                Software.Database.SQL.Food_TypeDB.DeleteFood_Type(id);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DoRefresh();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            List<Software.Model.Food_Type> selectedTypes = types.Where(t => t.Type_Name.ToLower().Contains(searchBox.Text.ToLower())).ToList();
            table.DataSource = selectedTypes;
        }

    }
}
