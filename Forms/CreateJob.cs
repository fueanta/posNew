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
    public partial class CreateJob : MetroFramework.Forms.MetroForm
    {
        public CreateJob()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Software.Model.Job job = new Software.Model.Job
            {
                Job_Title = jobTitileBox.Text,
                Salary = Int32.Parse(salaryBox.Text),
                Description = descriptionBox.Text
            };
            Software.Database.SQL.JobDB.InsertJob(job);
            MetroFramework.MetroMessageBox.Show(this, "Sucess", "Data Inserted Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}
