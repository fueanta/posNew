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
    public partial class CreateCustomer_Type : MetroFramework.Forms.MetroForm
    {
        public CreateCustomer_Type()
        {
            InitializeComponent();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Software.Model.Customer_Type type = new Software.Model.Customer_Type
            {
                Type_Title = typeTitileBox.Text,
                Order_Count = Int32.Parse(orderCountBox.Text),
                Total_Bill = Int32.Parse(totalBillBox.Text),
                Discount_Rate = Int32.Parse(discountBox.Text)
            };
            Software.Database.SQL.Customer_TypeDB.InsertCustomer_Type(type);
            MetroFramework.MetroMessageBox.Show(this, "Sucess", "Data Inserted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
