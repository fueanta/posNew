using System;
using System.Collections.Generic;
using System.Data;

namespace Software.Database.SQL
{
    public class CustomerDB
    {
        public static List<Model.Customer> GetAllCustomers()
        {
            List<Model.Customer> customers = new List<Model.Customer>();
            string query = "select * from customer order by id";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                customers.Add(RowToEntity(row));
            }
            return customers;
        }

        public static Model.Customer RowToEntity(DataRow row)
        {
            Model.Customer customer = new Model.Customer
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Name = row["Name"].ToString(),
                Contact_No = row["Contact_No"].ToString(),
                Email = row["Email"].ToString(),
                Address = row["Address"].ToString(),
                Type_Id = Int32.Parse(row["Type_Id"].ToString()),
                Picture = row["Picture"].ToString()
            };
            return customer;
        }

        public static void InsertCustomer(Model.Customer customer)
        {
            string query =
                "BEGIN " +
                "customer_pkg.insert_customer('" + customer.Name + "', '" + customer.Contact_No + "', '" + customer.Email + "', '" + customer.Address + "', " + customer.Type_Id + ", '" + customer.Picture + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdateCustomer(Model.Customer customer)
        {
            string query =
                "BEGIN " +
                "customer_pkg.update_customer(" + customer.Id + ", '" + customer.Name + "', '" + customer.Contact_No + "', '" + customer.Email + "', '" + customer.Address + "', " + customer.Type_Id + ", '" + customer.Picture + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteCustomer(int id)
        {
            string query =
                "BEGIN " +
                "customer_pkg.delete_customer(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }
    }
}
