﻿using System;
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
            employees = Software.Database.SQL.EmployeeDB.GetAllEmployees();
            table.DataSource = employees;
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
            table.DataSource = Software.Database.SQL.EmployeeDB.GetAllEmployees();
            //table.Refresh();            
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
            int selectedrowindex = 0;
            if (table.SelectedCells.Count > 0)
            {
                Software.Model.Employee employee = new Software.Model.Employee();

                selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];

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
            
                MetroFramework.MetroMessageBox.Show(this, "Your data has been updated successfully.", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to update its value!", "Invalid Selection");

            DoRefresh();
            table.Rows[selectedrowindex].Selected = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = 0;
            if (table.SelectedCells.Count > 0)
            {
                selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                Software.Database.SQL.EmployeeDB.DeleteEmployee(id);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

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
