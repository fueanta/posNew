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
    public partial class CreateOrder : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Employee> employees = null;
        List<Software.Model.Order_Food> available_foods = null;
        List<Software.Model.Order_Food> bucket_foods = null;
        public CreateOrder()
        {
            InitializeComponent();
            FillComboBoxes();
            discountBox.Text = 0.ToString();
            otherBox.Text = 0.ToString();

            available_foods = Software.Database.SQL.OrderFoodDB.GetAllFoods();
            foodList.DataSource = available_foods;

            bucket_foods = new List<Software.Model.Order_Food>();
            bucket_foods.Add(new Software.Model.Order_Food()); // taqui - patch
            table.DataSource = bucket_foods;

            DeleteFirstObj();
        }

        private void FillComboBoxes()
        {
            employees = Software.Database.SQL.EmployeeDB.GetAllEmployees();
            employeeBox.DataSource = employees;
            employeeBox.ValueMember = "Id";
            employeeBox.DisplayMember = "Name";
        }

        private void DeleteFirstObj() // taqui - patch
        {
            bucket_foods.RemoveAt(0);
            table.DataSource = null;
            table.DataSource = bucket_foods;

            available_foods.RemoveAt(0);
            foodList.DataSource = null;
            foodList.DataSource = available_foods;
        }

        private void CalcInventoryCost()
        {
            double bill = 0;
            foreach (var food in bucket_foods)
            {
                bill += (food.Unit_Price * food.Count);
            }
            billBox.Text = bill.ToString();
            bool doable = double.TryParse(discountBox.Text, out var discount);
            doable = double.TryParse(otherBox.Text, out var others);
            if (doable)
                totalBox.Text = (bill - (bill * (discount / 100)) + others).ToString();
            else
            {
                totalBox.Text = bill.ToString();
                discountBox.Text = 0.ToString();
                otherBox.Text = 0.ToString();
            }
        }

        private void pushRight_Click(object sender, EventArgs e)
        {
            if (available_foods.Count > 0)
            {
                var food = foodList.SelectedItem as Software.Model.Order_Food;
                if (!(food is null))
                {
                    int remove_id = food.Food_Id;
                    available_foods.Remove(available_foods.SingleOrDefault(i => i.Food_Id == remove_id));
                    foodList.DataSource = null;
                    foodList.DataSource = available_foods;
                    bucket_foods.Add(food);
                    table.DataSource = null;
                    table.DataSource = bucket_foods;
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
                var food = table.CurrentRow.DataBoundItem as Software.Model.Order_Food;
                if (!(food is null))
                {
                    int remove_id = food.Food_Id;
                    bucket_foods.Remove(bucket_foods.SingleOrDefault(i => i.Food_Id == remove_id));
                    table.DataSource = null;
                    table.DataSource = bucket_foods;
                    food.Count = 0;
                    available_foods.Add(food);
                }
                foodList.DataSource = null;
                foodList.DataSource = available_foods;
                CalcInventoryCost();
            }
            if (table.RowCount == 0) countBox.Text = "";
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            if (table.RowCount > 0 && table.CurrentRow != null)
            {
                var food = (Software.Model.Order_Food)table.CurrentRow.DataBoundItem;
                food.Count = Convert.ToInt32(countBox.Text);
                table.Refresh();
                CalcInventoryCost();
            }
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            var order = new Software.Model.POS_Order
            {
                Description = descriptionBox.Text,
                Place_Time = timeBox.Value,
                Employee_ID = ((Software.Model.Employee)employeeBox.SelectedItem).Id,
                Bill = Convert.ToDouble(billBox.Text),
                Discount_Rate = Convert.ToInt32(discountBox.Text),
                Other_Charges = Convert.ToDouble(otherBox.Text),
                Total_Bill = Convert.ToDouble(totalBox.Text),
                CardNumber = cardBox.Text
            };
            Software.Database.SQL.OrderDB.InsertOrder(order);
           
            foreach (var food in bucket_foods)
            {
                Software.Database.SQL.OrderFoodDB.InsertOrderFood(food);
            }
           
            MetroFramework.MetroMessageBox.Show(this, "Order has been added!", "Ordered Successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void table_SelectionChanged(object sender, EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];
                countBox.Text = Convert.ToString(selectedRow.Cells["Count"].Value);
            }
        }
    }
}
