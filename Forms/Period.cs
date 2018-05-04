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
    public partial class Period : MetroFramework.Forms.MetroForm
        
    {
        List<Software.Model.Period> period = null;
        public Period()
        {
            InitializeComponent();
            DoRefresh();
        }

        public void DoRefresh()
        {
            period = Software.Database.SQL.PeriodDB.GetAllPeriods(); // ?
            table.DataSource = period;
        }

        private void table_SelectionChanged(object sender, System.EventArgs e)
        {
            if (table.SelectedCells.Count > 0)
            {
                int selectedrowindex = table.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = table.Rows[selectedrowindex];
                idBox.Text = Convert.ToString(selectedRow.Cells["ID"].Value);
                empBox.Text = Convert.ToString(selectedRow.Cells["EMPLOYEE_ID"].Value);
                loginDateTime.Value = Convert.ToDateTime(selectedRow.Cells["Login_Time"].Value);
                logoutDateTime.Value = Convert.ToDateTime(selectedRow.Cells["LOGOUT_TIME"].Value);
               
            }

        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
