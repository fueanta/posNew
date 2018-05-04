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
    public partial class CreateFood : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Food_Type> types = null;
        public CreateFood()
        {
            InitializeComponent();
            radioYes.Checked = true;

            types = Software.Database.SQL.Food_TypeDB.GetAllFood_Types();
            typeComboBox.DataSource = types;
            typeComboBox.ValueMember = "Id";
            typeComboBox.DisplayMember = "Type_Name";
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Software.Model.Food food = new Software.Model.Food();
            try
            {
                food.Name = nameBox.Text;
                food.Price = Convert.ToInt32(priceBox.Text);
                food.Description = descriptionBox.Text;
                food.Availability = infoGroup.Controls.OfType<RadioButton>()
                        .FirstOrDefault(r => r.Checked).Text;
                food.Type_Id = ((Software.Model.Food_Type)typeComboBox.SelectedItem).Id;
                food.Discount_Rate = Convert.ToInt32(discountBox.Text);
                food.Other_Charges = Convert.ToInt32(chargesBox.Text);
                //food.Stock_Count = Convert.ToInt32(stockBox.Text);
                food.Picture = pictureBox.ImageLocation;

                Software.Database.SQL.FoodDB.InsertFood(food);
                MetroFramework.MetroMessageBox.Show(this, "Data has been inserted!", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, "Your data could not be inserted!", "Invalid data!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
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

        private void foodTypebtn_Click(object sender, EventArgs e) {
            new CreateFood_Type().ShowDialog(this);
        }

    }
}
