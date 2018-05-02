using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software.Model;

namespace Software.Database.SQL
{
    public class PurchaseIngredientDB
    {
        public static List<Model.Purchase_Ingredient> GetAllIngredients()
        {
            List<Model.Purchase_Ingredient> ingredients = new List<Model.Purchase_Ingredient>();
            string query = "select name, unit_cost, id from ingredient order by id";
            DataTable table = DB_Handler.GetDataTable(query);
            ingredients.Add(new Model.Purchase_Ingredient { }); // taqui - patch
            foreach (DataRow row in table.Rows)
            {
                ingredients.Add(RowToEntity(row));
            }
            return ingredients;
        }

        private static Purchase_Ingredient RowToEntity(DataRow row)
        {
            var ingredient = new Purchase_Ingredient
            {
                Ingredient_Name = row["Name"].ToString(),
                Unit_Cost = Int32.Parse(row["Unit_Cost"].ToString()),
                Ingredient_ID = Int32.Parse(row["Id"].ToString()),
                Amount = 0.0d
            };
            return ingredient;
        }

        public static void InsertPurchaseIngredient(Purchase_Ingredient ingredient)
        {
            string query =
                "BEGIN " +
                "insert_purchase_ingredient(" + ingredient.Ingredient_ID + ", " + ingredient.Amount + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }
    }
}
