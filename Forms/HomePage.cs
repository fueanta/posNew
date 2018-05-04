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
    public partial class HomePage : MetroFramework.Forms.MetroForm
    {
        public HomePage()
        {
            InitializeComponent();
            if (!Login_Form.access.Equals("ADMIN"))
            {
                tileEmployees.Enabled = false;
                tileFoods.Enabled = false;
                metroTile3.Enabled = false; //FOOD TYPE
                tileIngredients.Enabled = false;
                tileJobs.Enabled = false;
                userLabel.Text = "REGULAR";
            }
            else
            {
                userLabel.Text = "ADMIN";
            }
        }

        private void tileCustomer_Click(object sender, EventArgs e)
        {
            new CustomersViews().ShowDialog(this);
        }

        private void tileCustomerType_Click(object sender, EventArgs e)
        {
            new Customer_TypeViews().ShowDialog(this);
        }

        private void tileEmployees_Click(object sender, EventArgs e)
        {
            new EmployeeViews().ShowDialog(this);
        }

        private void tilePayment_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            new OrderView().ShowDialog(this);
=======
            new EmployeePaymentViews().ShowDialog(this);
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
        }

        private void tileFoods_Click(object sender, EventArgs e)
        {
            new FoodViews().ShowDialog(this);
        }

        private void tileIngredients_Click(object sender, EventArgs e)
        {
            new IngredientViews().ShowDialog(this);
        }

        private void tileJobs_Click(object sender, EventArgs e)
        {
            new JobViews().ShowDialog(this);
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            new SupplierForm().ShowDialog(this);
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            new Food_TypeViews().ShowDialog(this);
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            new PurchaseView().ShowDialog(this);
=======
            new CreatePurchase().ShowDialog(this);
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {
            new Unit_TypeViews().ShowDialog(this);
<<<<<<< HEAD
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // logout
            new Login_Form().DoRefresh();
            Close();
=======
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
        }
    }
}
