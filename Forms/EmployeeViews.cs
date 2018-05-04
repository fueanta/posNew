using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Forms
{
    public partial class EmployeeViews : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Employee> employees = null;
        List<Software.Model.Job> jobs = null;
        public EmployeeViews()
        {
            InitializeComponent();
            DoRefresh();
            jobs = Software.Database.SQL.JobDB.GetAllJobs();
            jobComboBox.DataSource = jobs;
            jobComboBox.ValueMember = "Id";
            jobComboBox.DisplayMember = "Job_Title";
        }

        private void table_SelectionChanged(object sender, System.EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                pictureBox.ImageLocation = Convert.ToString(selectedRow.Cells["Picture"].Value);
                nameBox.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                contactBox.Text = Convert.ToString(selectedRow.Cells["Contact_No"].Value);
                emailBox.Text = Convert.ToString(selectedRow.Cells["Email"].Value);
                addressBox.Text = Convert.ToString(selectedRow.Cells["Address"].Value);
                commissionBox.Text = Convert.ToString(selectedRow.Cells["Commission"].Value);
                passBox.Text = Convert.ToString(selectedRow.Cells["Password"].Value);
                authorityBox.Text = Convert.ToString(selectedRow.Cells["Authority"].Value);
                hireDateTime.Value = Convert.ToDateTime(selectedRow.Cells["Hire_Date"].Value);

                Software.Model.Job job = jobs.Single(j => j.Id == Convert.ToInt32(Convert.ToString(selectedRow.Cells["Job_id"].Value)));
                jobComboBox.SelectedIndex = jobComboBox.FindStringExact(job.Job_Title);
            }
        }

        public void DoRefresh()
        {
            employees = Software.Database.SQL.EmployeeDB.GetAllEmployees();
            table.DataSource = employees;
        }

        public void Clear()
        {
            table.ClearSelection();
            nameBox.Clear();
            contactBox.Clear();
            emailBox.Clear();
            addressBox.Clear();
            commissionBox.Clear();
            passBox.Clear();
            authorityBox.Clear();
            jobComboBox.SelectedIndex = 0;
            pictureBox.ImageLocation = "";
            hireDateTime.Value = DateTime.Now;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            new CreateEmployee().ShowDialog(this);
            DoRefresh();
        }

       

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                if (Software.Resources.ApplicationHelper.IsValidEmail(emailBox.Text) == true)
                {
                    if (Software.Resources.ApplicationHelper.IsValidPassword(passBox.Text) == true)
                    {
                        Software.Model.Employee employee = new Software.Model.Employee();

                        selectedRowIndex = table.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = table.Rows[selectedRowIndex];

                        employee.Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
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

                        Software.Database.SQL.EmployeeDB.UpdateEmployee(employee);

<<<<<<< HEAD
                        MetroFramework.MetroMessageBox.Show(this, "Your data has been updated successfully.", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "You must provide a valid password!", "Invalid Password");
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "You must provide a valid email!", "Invalid Email");
                }
=======
                employee.Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
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

                Software.Database.SQL.EmployeeDB.UpdateEmployee(employee);

                MetroFramework.MetroMessageBox.Show(this, "Your data has been updated successfully.", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to update its value!", "Invalid Selection");

            DoRefresh();
            table.CurrentCell = table.Rows[selectedRowIndex].Cells[0];
            table.Rows[selectedRowIndex].Selected = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];
                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                Software.Database.SQL.EmployeeDB.DeleteEmployee(id);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DoRefresh();
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

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            List<Software.Model.Employee> selectedEmployees = employees.Where(i => i.Name.ToLower().Contains(searchBox.Text.ToLower())).ToList();
            table.DataSource = selectedEmployees;
        }

<<<<<<< HEAD
        private void EmployeeViews_Load(object sender, EventArgs e)
        {

        }
=======
        
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
    }
}