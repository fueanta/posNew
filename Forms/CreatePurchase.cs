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
    public partial class CreatePurchase : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Employee> employees = null;
        List<Software.Model.Supplier> suppliers = null;
        List<Software.Model.Purchase_Ingredient> available_ingredients = null;
        List<Software.Model.Purchase_Ingredient> bucket_ingredients = null;
        public CreatePurchase()
        {
            InitializeComponent();
            FillComboBoxes();
            discountBox.Text = 0.ToString();

            available_ingredients = Software.Database.SQL.PurchaseIngredientDB.GetAllIngredients();
            ingredientList.DataSource = available_ingredients;

            bucket_ingredients = new List<Software.Model.Purchase_Ingredient>();
            bucket_ingredients.Add(new Software.Model.Purchase_Ingredient()); // taqui - patch
            table.DataSource = bucket_ingredients;

            DeleteFirstObj(); // taqui - patch
        }

        private void FillComboBoxes()
        {
            employees = Software.Database.SQL.EmployeeDB.GetAllEmployees();
            employeeBox.DataSource = employees;
            employeeBox.ValueMember = "Id";
            employeeBox.DisplayMember = "Name";

            suppliers = Software.Database.SQL.SupplierDB.GetAllSuppliers();
            supplierBox.DataSource = suppliers;
            supplierBox.ValueMember = "Id";
            supplierBox.DisplayMember = "Name";
        }

        private void DeleteFirstObj() // taqui - patch
        {
            bucket_ingredients.RemoveAt(0);
            table.DataSource = null;
            table.DataSource = bucket_ingredients;

            available_ingredients.RemoveAt(0);
            ingredientList.DataSource = null;
            ingredientList.DataSource = available_ingredients;
        }

        private void CalcInventoryCost()
        {
            double purchase_cost = 0;
            foreach (var ingredient in bucket_ingredients)
            {
                purchase_cost += (ingredient.Unit_Cost * ingredient.Amount);
            }
            costBox.Text = purchase_cost.ToString();
            bool doable = double.TryParse(discountBox.Text, out var discount);
            if (doable)
                totalBox.Text = (purchase_cost - (purchase_cost * (discount / 100))).ToString();
        }

        private void pushRight_Click(object sender, EventArgs e)
        {
            if (available_ingredients.Count > 0)
            {
                var ingredient = ingredientList.SelectedItem as Software.Model.Purchase_Ingredient;
                if (!(ingredient is null))
                {
                    int remove_id = ingredient.Ingredient_ID;
                    available_ingredients.Remove(available_ingredients.SingleOrDefault(i => i.Ingredient_ID == remove_id));
                    ingredientList.DataSource = null;
                    ingredientList.DataSource = available_ingredients;
                    bucket_ingredients.Add(ingredient);
                    table.DataSource = null;
                    table.DataSource = bucket_ingredients;
                }                             
                CalcInventoryCost();
                table.CurrentCell = table.Rows[table.Rows.Count - 1].Cells[0];
                table.Rows[table.Rows.Count - 1].Selected = true;
            }
        }

        private void pushLeft_Click(object sender, EventArgs e)
        {
            if (table.RowCount > 0)
            {
                var ingredient = table.CurrentRow.DataBoundItem as Software.Model.Purchase_Ingredient;
                if (!(ingredient is null))
                {
                    int remove_id = ingredient.Ingredient_ID;
                    bucket_ingredients.Remove(bucket_ingredients.SingleOrDefault(i => i.Ingredient_ID == remove_id));
                    table.DataSource = null;
                    table.DataSource = bucket_ingredients;
                    ingredient.Amount = 0.0d;
                    available_ingredients.Add(ingredient);
                }
                ingredientList.DataSource = null;
                ingredientList.DataSource = available_ingredients;
                CalcInventoryCost();
            }
        }

        private void table_SelectionChanged(object sender, EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];
                amountBox.Text = Convert.ToString(selectedRow.Cells["Amount"].Value);
            }
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (table.RowCount > 0 && table.CurrentRow != null)
            {
                var ingredient = (Software.Model.Purchase_Ingredient)table.CurrentRow.DataBoundItem;
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

        private void purchaseBtn_Click(object sender, EventArgs e)
        {
            var purchase = new Software.Model.POS_Purchase
            {
                Description = descriptionBox.Text,
                Time = timeBox.Value,
                Employee_Id = ((Software.Model.Employee)employeeBox.SelectedItem).Id,
                Supplier_Id = ((Software.Model.Supplier)supplierBox.SelectedItem).Id,
                Cost = Convert.ToDouble(costBox.Text),
                Discount_Rate = Convert.ToInt32(discountBox.Text),
                Total_Cost = Convert.ToDouble(totalBox.Text)
            };
            Software.Database.SQL.PurchaseDB.InsertPurchase(purchase);

            foreach (var ingredient in bucket_ingredients)
            {
                Software.Database.SQL.PurchaseIngredientDB.InsertPurchaseIngredient(ingredient);
            }
            
            MetroFramework.MetroMessageBox.Show(this, "Purchase has been added!", "Purchased Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
