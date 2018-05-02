using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Database.SQL
{
    public class PuchaseDB
    {
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
          //  string query =
          //      "BEGIN " +
          //      "ingredient_pkg.delete_ingredient(" + id + "); " +
          //      "END;";
          //  DB_Handler.ExecuteQuery(query);
        }
    }
}
