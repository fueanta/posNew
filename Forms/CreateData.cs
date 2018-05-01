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
    public partial class CreateData : MetroFramework.Forms.MetroForm
    {
        public CreateData()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Software.Model.Data Data = new Software.Model.Data();
            Data.Data_Name = nameBox.Text;
            Data.Data_Value = Convert.ToInt32(datavalBox.Text);

            Software.Database.SQL.DataDB.InsertData(Data);
            MetroFramework.MetroMessageBox.Show(this, "Data has been inserted!", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
