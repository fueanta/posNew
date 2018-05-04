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
    public partial class FoodIngredient_Views : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Food_Ingredient> unused = null;
        List<Software.Model.Food_Ingredient> used = null;
        int Id;
        public FoodIngredient_Views()
        {

        }
        public FoodIngredient_Views(int Id) : this()
        {
            InitializeComponent();
            this.Id = Id;

            unused = Software.Database.SQL.FoodIngredientDB.GetUnusedIngredients(Id);
            list.DataSource = unused;
            
            used = Software.Database.SQL.FoodIngredientDB.GetUsedIngredients(Id);
            table.DataSource = used;

            CalcInventoryCost();

            DeleteFirstObj(); // taqui - patch
        }

        private void discardBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pushRight_Click(object sender, EventArgs e)
        {
            if (unused.Count > 0)
            {
                var ingredient = list.SelectedItem as Software.Model.Food_Ingredient;
                if (!(ingredient is null))
                {
                    int remove_id = ingredient.Ingredient_Id;
                    unused.Remove(unused.SingleOrDefault(i => i.Ingredient_Id == remove_id));
                    list.DataSource = null;
                    list.DataSource = unused;
                }
                used.Add(ingredient);
                table.DataSource = null;
                table.DataSource = used;
                CalcInventoryCost();

                table.CurrentCell = table.Rows[table.Rows.Count - 1].Cells[0];
                table.Rows[table.Rows.Count - 1].Selected = true;
            }
        }

        private void DeleteFirstObj() // taqui - patch
        {
            used.RemoveAt(0);
            table.DataSource = null;
            table.DataSource = used;

            unused.RemoveAt(0);
            list.DataSource = null;
            list.DataSource = unused;
        }

        private void pushLeft_Click(object sender, EventArgs e)
        {
            if (table.RowCount > 0)
            {
                var ingredient = table.CurrentRow.DataBoundItem as Software.Model.Food_Ingredient;
                if (!(ingredient is null))
                {
                    int remove_id = ingredient.Ingredient_Id;
                    used.Remove(used.SingleOrDefault(i => i.Ingredient_Id == remove_id));
                    table.DataSource = null;
                    table.DataSource = used;
                    ingredient.Amount = 0.0d;
                    unused.Add(ingredient);
                }
                list.DataSource = null;
                list.DataSource = unused;
                CalcInventoryCost();
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (table.RowCount > 0 && table.CurrentRow != null)
            {
                var ingredient = (Software.Model.Food_Ingredient)table.CurrentRow.DataBoundItem;
                ingredient.Amount = Convert.ToDouble(amountBox.Text);
                if (check.Checked)
                {
                    ingredient.Amount /= 1000;
                    amountBox.Text = ingredient.Amount.ToString();
                    check.Checked = false;
                }
                table.Refresh();
                CalcInventoryCost();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            Software.Database.SQL.FoodIngredientDB.DeleteFoodIngredient(Id);
            foreach (var usedIngredient in used)
            {
                Software.Database.SQL.FoodIngredientDB.InsertFoodIngredient(usedIngredient, Id);
            }
            Software.Database.SQL.FoodDB.UpdateStockCount(Id);
            MetroFramework.MetroMessageBox.Show(this, "Inventory Binding has been changed!", "Updated Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void table_SelectionChanged(object sender, EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                amountBox.Text = Convert.ToString(selectedRow.Cells["Amount"].Value);
            }
        }

        private void CalcInventoryCost()
        {
            double inventory_cost = 0;
            foreach (var ingredient in used)
            {
                inventory_cost += (ingredient.Unit_Cost * ingredient.Amount);
            }
            totalLabel.Text = String.Format($"** Inventory Value : BDT. {inventory_cost:N}");
        }
    }
}
