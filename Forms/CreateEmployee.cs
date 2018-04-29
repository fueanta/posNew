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
    public partial class CreateEmployee : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Job> jobs = null;
        public CreateEmployee()
        {
            InitializeComponent();
            jobs = Software.Database.SQL.JobDB.GetAllJobs();
            jobComboBox.DataSource = jobs;
            jobComboBox.ValueMember = "Id";
            jobComboBox.DisplayMember = "Job_Title";
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            Software.Model.Employee employee = new Software.Model.Employee();
            employee.Name = nameBox.Text;
            employee.Contact_No = contactBox.Text;
            employee.Email = emailBox.Text;
            employee.Address = addressBox.Text;
            employee.Hire_Date = hireDateTime.Value;
            employee.Commission = Convert.ToInt32(commissionBox.Text);
            employee.Job_Id = ((Software.Model.Job)jobComboBox.SelectedItem).Id;
            employee.Picture = pictureBox.ImageLocation;
            employee.Password = passBox.Text;
            employee.Authority = authorityBox.Text;

            Software.Database.SQL.EmployeeDB.InsertEmployee(employee);
            MetroFramework.MetroMessageBox.Show(this, "Your data has been updated successfully.", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void jobComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* 
             if (((Software.Model.Job)jobComboBox.SelectedItem).Id != 1)
            {
                passBox.Enabled = false;
                authorityBox.Enabled = false;
            }
            else
            {
                passBox.Enabled = true;
                authorityBox.Enabled = true;
            }
             */
        }

        
    }
}
