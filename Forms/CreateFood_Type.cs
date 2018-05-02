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
    public partial class CreateFood_Type : MetroFramework.Forms.MetroForm
    {
        public CreateFood_Type()
        {
            InitializeComponent();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Software.Model.Food_Type type = new Software.Model.Food_Type
            {
                Type_Name = nameBox.Text,
                Description = descriptionBox.Text
            };
            Software.Database.SQL.Food_TypeDB.InsertFood_Type(type);
            MetroFramework.MetroMessageBox.Show(this, "Sucess", "Data Inserted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
