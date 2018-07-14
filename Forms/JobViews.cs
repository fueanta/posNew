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
    public partial class JobViews : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Job> jobs = null;
        public JobViews()
        {
            InitializeComponent();
            DoRefresh();
        }

        private void table_SelectionChanged(object sender, EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                jobTitileBox.Text = Convert.ToString(selectedRow.Cells["Job_Title"].Value);
                salaryBox.Text = Convert.ToString(selectedRow.Cells["Salary"].Value);
                descriptionBox.Text = Convert.ToString(selectedRow.Cells["Description"].Value);
            }
        }

        public void DoRefresh()
        {
            jobs = Software.Database.SQL.JobDB.GetAllJobs();
            table.DataSource = jobs;
        }

        public void Clear()
        {
            table.ClearSelection();
            jobTitileBox.Clear();
            salaryBox.Clear();
            descriptionBox.Clear();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            new CreateJob().ShowDialog(this);
            DoRefresh();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedRowIndex = 0;
            if (table.SelectedCells.Count > 0)
            {
                Software.Model.Job job = new Software.Model.Job();

                selectedRowIndex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedRowIndex];

                job.Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                job.Job_Title = jobTitileBox.Text;
                job.Salary = Convert.ToInt32(salaryBox.Text);
                job.Description = descriptionBox.Text;
                Software.Database.SQL.JobDB.UpdateJob(job);               
            }
            else
                MessageBox.Show("You must select a row to update its value!", "Invalid Selection");
           
            DoRefresh();
            table.CurrentCell = table.Rows[selectedRowIndex].Cells[0];
            table.Rows[selectedRowIndex].Selected = true;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = 0;
            if (table.SelectedCells.Count > 0)
            {
                selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));                
                Software.Database.SQL.JobDB.DeleteJob(id);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DoRefresh();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            List<Software.Model.Job> selectedJobs = jobs.Where(j => j.Job_Title.ToLower().Contains(searchBox.Text.ToLower())).ToList();
            table.DataSource = selectedJobs;
        }
    }
}
