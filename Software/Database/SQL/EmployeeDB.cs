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
            string query = "SELECT * FROM Employee";
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
                Contact_No = row["Name"].ToString(),
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
    }
}
