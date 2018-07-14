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
    public partial class FoodViews : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Food> foods = null;
        List<Software.Model.Food_Type> types = null;
        public FoodViews()
        {
            InitializeComponent();
            radioYes.Checked = true;

            DoRefresh();
            types = Software.Database.SQL.Food_TypeDB.GetAllFood_Types();
            typeComboBox.DataSource = types;
            typeComboBox.ValueMember = "Id";
            typeComboBox.DisplayMember = "Type_Name";
        }

        private void DoRefresh()
        {
            foods = Software.Database.SQL.FoodDB.GetAllFoods();
            table.DataSource = foods;
        }

        private void table_SelectionChanged(object sender, EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                pictureBox.ImageLocation = Convert.ToString(selectedRow.Cells["Picture"].Value);
                nameBox.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                priceBox.Text = Convert.ToString(selectedRow.Cells["Price"].Value);
                descriptionBox.Text = Convert.ToString(selectedRow.Cells["Description"].Value);
                discountBox.Text = Convert.ToString(selectedRow.Cells["Discount_Rate"].Value);
                chargesBox.Text = Convert.ToString(selectedRow.Cells["Other_Charges"].Value);
                stockBox.Text = Convert.ToString(selectedRow.Cells["Stock_Count"].Value);

                var availability = Convert.ToString(selectedRow.Cells["Availability"].Value);
                if (availability.Equals("Yes"))
                    radioYes.Checked = true;
                else
                    radioNo.Checked = true;

                Software.Model.Food_Type type = types.Single(t => t.Id == Convert.ToInt32(Convert.ToString(selectedRow.Cells["Type_Id"].Value)));
                typeComboBox.SelectedIndex = typeComboBox.FindStringExact(type.Type_Name);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            new CreateFood().ShowDialog(this);
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
                Software.Database.SQL.FoodDB.DeleteFood(id);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoRefresh();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                Software.Model.Food food = new Software.Model.Food();

                selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];

                try
                {
                    food.Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                    food.Name = nameBox.Text;
                    food.Price = Convert.ToInt32(priceBox.Text);
                    food.Description = descriptionBox.Text;
                    food.Type_Id = ((Software.Model.Food_Type)typeComboBox.SelectedItem).Id;
                    food.Discount_Rate = Convert.ToInt32(discountBox.Text);
                    food.Availability = infoGroup.Controls.OfType<RadioButton>()
                        .FirstOrDefault(r => r.Checked).Text;
                    food.Other_Charges = Convert.ToInt32(chargesBox.Text);
                    //food.Stock_Count = Convert.ToInt32(stockBox.Text);
                    food.Picture = pictureBox.ImageLocation;
                    Software.Database.SQL.FoodDB.UpdateFood(food);
                    MetroFramework.MetroMessageBox.Show(this, "Your data has been updated.", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, "Your data could not be updated.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to update its value!", "Invalid Selection");

            DoRefresh();
            table.CurrentCell = table.Rows[selectedRowIndex].Cells[0];
            table.Rows[selectedRowIndex].Selected = true;
        }

        private void inventoryBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = table.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = table.Rows[selectedRowIndex];
            new FoodIngredient_Views(Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value))).ShowDialog(this);
            DoRefresh();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images| *.JPG; *.PNG; *.GJF"; // you can add any other image type 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = ofd.FileName;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            List<Software.Model.Food> selectedFoods = foods.Where(f => f.Name.ToLower().Contains(searchBox.Text.ToLower())).ToList();
            table.DataSource = selectedFoods;
        }
    }
}
