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
    public partial class CreateCustomer : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Customer_Type> types = null;
        public CreateCustomer()
        {
            InitializeComponent();
            types = Software.Database.SQL.Customer_TypeDB.GetAllCustomerTypes();
            typeComboBox.DataSource = types;
            typeComboBox.ValueMember = "Id";
            typeComboBox.DisplayMember = "Type_Title";
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "images| *.JPG; *.PNG; *.GIF"; // you can add any other image type 
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox.ImageLocation = ofd.FileName;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Software.Model.Customer customer = new Software.Model.Customer();
            customer.Name = nameBox.Text;
            customer.Contact_No = contactBox.Text;
            customer.Email = emailBox.Text;
            customer.Address = addressBox.Text;
            customer.Type_Id = ((Software.Model.Customer_Type)typeComboBox.SelectedItem).Id;
            customer.Picture = pictureBox.ImageLocation;

            Software.Database.SQL.CustomerDB.InsertCustomer(customer);
            MetroFramework.MetroMessageBox.Show(this, "Data has been inserted!", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
