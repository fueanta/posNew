using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Database.SQL
{
    public class PurchaseDB
    {
        public static List<Model.POS_Purchase> GetPurchases(DateTime first, DateTime second)
        {
            List<Model.POS_Purchase> purchases = new List<Model.POS_Purchase>();
            string query = "select * from pos_purchase where time between TO_DATE('" + first.ToString(string.Format("MM-dd-yyyy")) + "', 'mm-dd-yyyy') and TO_DATE('" + second.ToString(String.Format("MM-dd-yyyy")) + "', 'mm-dd-yyyy')";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                purchases.Add(RowToEntity(row));
            }
            return purchases;
        }

        private static Model.POS_Purchase RowToEntity(DataRow row)
        {
            Model.POS_Purchase purchase = new Model.POS_Purchase
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Description = row["Description"].ToString(),
                Time = Convert.ToDateTime(row["Time"].ToString()),
                Employee_Id = Int32.Parse(row["Employee_Id"].ToString()),
                Supplier_Id = Int32.Parse(row["Supplier_Id"].ToString()),
                Cost = Convert.ToDouble(row["Cost"].ToString()),
                Discount_Rate = Convert.ToInt32(row["Discount_Rate"].ToString()),
                Total_Cost = Convert.ToDouble(row["Total_Cost"].ToString())                
            };
            return purchase;
        }
        public static void InsertPurchase(Model.POS_Purchase purchase)
        {
            string query =
                "BEGIN " +
                "purchase_pkg.insert_purchase('" + purchase.Description + "', '" + purchase.Time.ToString(string.Format("dd/MMM/yyyy")) + "', " + purchase.Employee_Id + ", " + purchase.Supplier_Id + ", " + purchase.Cost + ", " + purchase.Discount_Rate + ", " + purchase.Total_Cost + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdatePurchase(Model.POS_Purchase purchase)
        {
          //  string query =
          //      "BEGIN " +
          //      "ingredient_pkg.update_ingredient(" + ingredient.Id + ", '" + ingredient.Name + "', '" + ingredient.Description + "', " + ingredient.Unit_Id + ", " + ingredient.Unit_Cost + ", " + ingredient.Amount + "); " +
          //      "END;";
          //  DB_Handler.ExecuteQuery(query);
        }

        public static void DeletePurchase(int id)
        {
            string query =
                "BEGIN " +
                "purchase_pkg.delete_purchase(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }
    }
}
