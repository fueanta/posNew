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
<<<<<<< HEAD
        public static string access;
=======
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
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
<<<<<<< HEAD
                Software.Model.Employee employee = employees.SingleOrDefault(i => i.Email.Equals(emailBox.Text) && i.Password.Equals(passBox.Text));
=======
>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
                if (emailBox.Text == "" || passBox.Text == "")
                {
                    MessageBox.Show(" Enter UserName and Password .");
                    return;
                }
                //Write Login Method
<<<<<<< HEAD
                else if (!(employee is null))
                {
                    access = employee.Authority;
                    new HomePage().ShowDialog();
                }
=======



>>>>>>> 4410b8a4bbb75fc029515ceb15b63a9cb2b26558
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }
