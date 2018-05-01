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
    public partial class CreateChangelog : MetroFramework.Forms.MetroForm
    {
        public CreateChangelog()
        {
            InitializeComponent();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Software.Model.Changelog changelogs = new Software.Model.Changelog();
            changelogs.Description = DescriptionBox.Text;
            changelogs.Employee_Id = Convert.ToInt32(employeeBox.Text);

            Software.Database.SQL.ChangelogDB.InsertChangelog(changelogs);
            MetroFramework.MetroMessageBox.Show(this, "Data has been inserted!", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
