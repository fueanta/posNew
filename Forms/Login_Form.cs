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
    public partial class Login_Form : MetroFramework.Forms.MetroForm
    {
        public static string access;
        List<Software.Model.Employee> employees = null;

        public Login_Form()
        {
            InitializeComponent();
            DoRefresh();
        }

        public void DoRefresh()
        {
            employees = Software.Database.SQL.EmployeeDB.GetAllEmployees();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Software.Model.Employee employee = employees.SingleOrDefault(i => i.Email.Equals(emailBox.Text) && i.Password.Equals(passBox.Text));
                if (emailBox.Text == "" || passBox.Text == "")
                {
                    MessageBox.Show(" Enter UserName and Password .");
                    return;
                }
                //Write Login Method
                else if (!(employee is null))
                {
                    access = employee.Authority;
                    new HomePage().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Not Registered User or Invalid Name/Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
