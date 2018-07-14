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
    public partial class CreateIngredient : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Unit_Type> types = null;
        public CreateIngredient()
        {
            InitializeComponent();
            types = Software.Database.SQL.Unit_TypeDB.GetAllUnit_Types();
            comboBox.DataSource = types;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Software.Model.Ingredient ingredient = new Software.Model.Ingredient();
            ingredient.Name = nameBox.Text;
            ingredient.Description = descriptionBox.Text;
            ingredient.Unit_Cost = Convert.ToInt32(costBox.Text);
            ingredient.Amount = Convert.ToDouble(amountBox.Text);
            ingredient.Unit_Id = ((Software.Model.Unit_Type)comboBox.SelectedItem).Id;
            Software.Database.SQL.IngredientDB.InsertIngredient(ingredient);
            MetroFramework.MetroMessageBox.Show(this, "Data has been inserted!", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
