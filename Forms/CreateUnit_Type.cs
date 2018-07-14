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
    public partial class CreateUnit_Type : MetroFramework.Forms.MetroForm
    {
        public CreateUnit_Type()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Software.Model.Unit_Type type = new Software.Model.Unit_Type
            {
                Name = nameBox.Text,
                Symbol = symbolBox.Text
            };
            Software.Database.SQL.Unit_TypeDB.InsertUnit_Type(type);
            MetroFramework.MetroMessageBox.Show(this, "Sucess", "Data Inserted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
