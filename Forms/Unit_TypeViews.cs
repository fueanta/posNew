using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Forms
{
    public partial class Unit_TypeViews : MetroFramework.Forms.MetroForm
    {
        List<Software.Model.Unit_Type> types = null;
        public Unit_TypeViews()
        {
            InitializeComponent();
            types = Software.Database.SQL.Unit_TypeDB.GetAllUnit_Types();
            table.DataSource = types;
        }

        private void table_SelectionChanged(object sender, System.EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                nameBox.Text = Convert.ToString(selectedRow.Cells["Name"].Value);
                symbolBox.Text = Convert.ToString(selectedRow.Cells["Symbol"].Value);
            }
        }

        public void DoRefresh()
        {
            table.DataSource = Software.Database.SQL.Unit_TypeDB.GetAllUnit_Types();
            //table.Refresh();            
        }

        private void createBtn_Click(object sender, EventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
