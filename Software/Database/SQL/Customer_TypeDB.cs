using System;
using System.Collections.Generic;
using System.Data;

namespace Software.Database.SQL
{
    public class Customer_TypeDB
    {
        public static List<Model.Customer_Type> GetAllCustomerTypes()
        {
            List<Model.Customer_Type> customer_Types = new List<Model.Customer_Type>();
            string query = "select * from customer_type order by id";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                customer_Types.Add(RowToEntity(row));
            }
            return customer_Types;
        }

        public static Model.Customer_Type RowToEntity(DataRow row)
        {
            Model.Customer_Type customer_Type = new Model.Customer_Type
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Type_Title = row["Type_Title"].ToString(),
                Order_Count = Int32.Parse(row["Order_Count"].ToString()),
                Total_Bill = Int32.Parse(row["Total_Bill"].ToString()),
                Discount_Rate = Int32.Parse(row["Discount_Rate"].ToString())
            };
            return customer_Type;
        }

        public static void InsertCustomer_Type(Model.Customer_Type customer_Type)
        {
            string query =
                "BEGIN " +
                "customer_type_pkg.insert_customer_type('" + customer_Type.Type_Title + "', " + customer_Type.Order_Count + ", " + customer_Type.Total_Bill + ", " + customer_Type.Discount_Rate + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdateCustomer_Type(Model.Customer_Type customer_Type)
        {
            string query =
                "BEGIN " +
                "customer_type_pkg.update_customer_type(" + customer_Type.Id + ", '" + customer_Type.Type_Title + "', " + customer_Type.Order_Count + ", " + customer_Type.Total_Bill + ", " + customer_Type.Discount_Rate + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteCustomer_Type(int id)
        {
            string query =
                "BEGIN " +
                "customer_type_pkg.delete_customer_type(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

    }
}
