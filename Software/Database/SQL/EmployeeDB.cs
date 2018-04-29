using System;
using System.Collections.Generic;
using System.Data;

namespace Software.Database.SQL
{
    public class EmployeeDB
    {
        public static List<Model.Employee> GetAllEmployees()
        {
            List<Model.Employee> employees = new List<Model.Employee>();
            string query = "select * from employee order by id";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                employees.Add(RowToEntity(row));
            }
            return employees;
        }

        public static Model.Employee RowToEntity(DataRow row)
        {
            Model.Employee employee = new Model.Employee
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Name = row["Name"].ToString(),
                Contact_No = row["Contact_No"].ToString(),
                Email = row["Email"].ToString(),
                Address = row["Address"].ToString(),
                Hire_Date = Convert.ToDateTime(row["Hire_Date"]),
                Commission = Int32.Parse(row["Commission"].ToString()),
                Job_Id = Int32.Parse(row["Job_Id"].ToString()),
                Picture = row["Picture"].ToString(),
                Password = row["Password"].ToString(),
                Authority = row["Authority"].ToString(),
            };
            return employee;
        }

        public static void UpdateEmployee(Model.Employee employee)
        {
            string query =
                "BEGIN " +
                "update_employee(" + employee.Id + ", '" + employee.Name + "', '" + employee.Contact_No + "', '" + employee.Email + "', '" + employee.Address + "', '" + employee.Hire_Date.ToString(string.Format("dd/MMM/yyyy")) + "', " + employee.Commission + ", " + employee.Job_Id + ", '" + employee.Picture + "', '" + employee.Password + "', '" + employee.Authority + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteEmployee(int id)
        {
            string query =
                "BEGIN " +
                "delete_employee(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }
    }
}
