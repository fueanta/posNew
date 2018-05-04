using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software.Model;

namespace Software.Database.SQL
{
    public class OrderDB
    {
        public static List<POS_Order> GetOrders(DateTime first, DateTime second)
        {
            List<POS_Order> orders = new List<POS_Order>();
            string query = "select * from pos_order where place_time between TO_DATE('" + first.ToString(string.Format("MM-dd-yyyy")) + "', 'mm-dd-yyyy') and TO_DATE('" + second.ToString(String.Format("MM-dd-yyyy")) + "', 'mm-dd-yyyy')";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                orders.Add(RowToEntity(row));
            }
            return orders;
        }

        private static POS_Order RowToEntity(DataRow row)
        {
            POS_Order order = new POS_Order
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Description = row["Description"].ToString(),
                Place_Time = Convert.ToDateTime(row["Place_Time"].ToString()),
                Employee_ID = Int32.Parse(row["Employee_Id"].ToString()),
                Bill = Convert.ToDouble(row["Bill"].ToString()),
                Discount_Rate = Convert.ToInt32(row["Discount_Rate"].ToString()),
                Other_Charges = Convert.ToDouble(row["Other_Charges"].ToString()),
                Total_Bill = Convert.ToDouble(row["Total_Bill"].ToString()),
                CardNumber = row["Card_Number"].ToString()
            };
            return order;
        }

        public static void InsertOrder(POS_Order order)
        {
            string query =
                "BEGIN " +
                "order_pkg.insert_order('" + order.Description + "', '" + order.Place_Time.ToString(string.Format("dd/MMM/yyyy")) + "', " + order.Employee_ID + ", "  + order.Bill + ", " + order.Discount_Rate + ", " + order.Other_Charges + ", " + order.Total_Bill + ", '" + order.CardNumber + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteOrder(int Id)
        {
            string query =
                "BEGIN " +
                "order_pkg.delete_order(" + Id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

    }
}
