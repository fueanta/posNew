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
    public partial class Changelog : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Changelog> changelogs = null;
        public Changelog()
        {
            InitializeComponent();
            DoRefresh();
        }

        public void DoRefresh()
        {
            changelogs = Software.Database.SQL.ChangelogDB.GetAllChangelog();
            table.DataSource = changelogs;
        }

        private void table_SelectionChanged(object sender, System.EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                idBox.Text = Convert.ToString(selectedRow.Cells["Id"].Value);
                employeeBox.Text = Convert.ToString(selectedRow.Cells["Employee_Id"].Value);
                DescriptionBox.Text = Convert.ToString(selectedRow.Cells["Description"].Value);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = 0;
            if (table.SelectedCells.Count > 0)
            {
                selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                int id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                Software.Database.SQL.ChangelogDB.DeleteChangelog(id);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to delete it!", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            DoRefresh();
        }


        private void updateBtn_Click(object sender, EventArgs e)
        {
            int selectedrowindex = 0;
            if (table.SelectedCells.Count > 0)
            {
                Software.Model.Changelog changelogs = new Software.Model.Changelog();

                selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];

                changelogs.Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Id"].Value));
                changelogs.Description = DescriptionBox.Text;
                changelogs.Employee_Id = Convert.ToInt32(Convert.ToString(selectedRow.Cells["Employee_Id"].Value));
                

                Software.Database.SQL.ChangelogDB.UpdateChangelog(changelogs);

                MetroFramework.MetroMessageBox.Show(this, "Your data has been updated successfully.", "Successfully Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "You must select a row to update its value!", "Invalid Selection");

            DoRefresh();
            table.Rows[selectedrowindex].Selected = true;
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            new CreateChangelog().ShowDialog(this);
            DoRefresh();
        }
    }
}
