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
    public partial class IngredientViews : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Ingredient> ingredients = null;
        List<Software.Model.Unit_Type> types = null;
        public IngredientViews()
        {
            InitializeComponent();
            DoRefresh();
            types = Software.Database.SQL.Unit_TypeDB.GetAllUnit_Types();
            comboBox.DataSource = types;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";
        }

        public void DoRefresh()
        {
            ingredients = Software.Database.SQL.IngredientDB.GetAllIngredients();
            CalcTotalInventoryCost();
            table.DataSource = ingredients;
        }

        private void CalcTotalInventoryCost()
        {
            double inventory_cost = 0;
            foreach (var ingredient in ingredients)
            {
                inventory_cost += (ingredient.Unit_Cost * ingredient.Amount);
            }
            totalLabel.Text = String.Format($"** Inventory Value : BDT. {inventory_cost:N}");
        }

        private void table_SelectionChanged(object sender, EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];
                nameBox.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                descriptionBox.Text = Convert.ToString(selectedRow.Cells["Description"].Value);
                costBox.Text = Convert.ToString(selectedRow.Cells["Unit_Cost"].Value);
                amountBox.Text = Convert.ToString(selectedRow.Cells["Amount"].Value);

                Software.Model.Unit_Type type = types.Single(t => t.Id == Convert.ToInt32(Convert.ToString(selectedRow.Cells["Unit_Id"].Value)));
                comboBox.SelectedIndex = comboBox.FindStringExact(type.Name);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            new CreateIngredient().ShowDialog(this);
            DoRefresh();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                Software.Model.Ingredient ingredient = new Software.Model.Ingredient();

                selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];

                ingredient.Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                ingredient.Name = nameBox.Text;
                ingredient.Description = descriptionBox.Text;
                ingredient.Unit_Cost = Convert.ToInt32(costBox.Text);
                ingredient.Amount = Convert.ToDouble(amountBox.Text);

                ingredient.Unit_Id = ((Software.Model.Unit_Type)comboBox.SelectedItem).Id;
                
                Software.Database.SQL.IngredientDB.UpdateIngredient(ingredient);

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
                Software.Database.SQL.IngredientDB.DeleteIngredient(id);
                MetroFramework.MetroMessageBox.Show(this, "Data has been deleted!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoRefresh();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            List<Software.Model.Ingredient> selectedIngredients = ingredients.Where(i => i.Name.ToLower().Contains(searchBox.Text.ToLower())).ToList();
            table.DataSource = selectedIngredients;
        }
    }
}
