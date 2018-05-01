using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Database.SQL
{
    public class Rotten_IngredientDB
    {
        public static List<Model.Rotten_Ingredient> GetAllRotten_Ingredients()
        {
            List<Model.Rotten_Ingredient> rotten_Ingredients = new List<Model.Rotten_Ingredient>();
            string query = "select * from rotten_ingredient order by id";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                rotten_Ingredients.Add(RowToEntity(row));
            }
            return rotten_Ingredients;
        }

        public static Model.Rotten_Ingredient RowToEntity(DataRow row)
        {
            Model.Rotten_Ingredient rotten_Ingredient = new Model.Rotten_Ingredient
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Ingredient_Id = Int32.Parse(row["Ingredient_Id"].ToString()),
                Amount = Double.Parse(row["Amount"].ToString()),
                Date_Added = Convert.ToDateTime(row["Date_Added"])
            };
            return rotten_Ingredient;
        }

        public static void InsertRotten_Ingredient(Model.Rotten_Ingredient rotten_Ingredient)
        {
            string query =
                "BEGIN " +
                "rotten_ingredient_pkg.insert_rotten_ingredient(" + rotten_Ingredient.Ingredient_Id + ", " + rotten_Ingredient.Amount + ", '" + rotten_Ingredient.Date_Added.ToString(string.Format("dd/MMM/yyyy")) + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdateRotten_Ingredient(Model.Rotten_Ingredient rotten_Ingredient)
        {
            string query =
                "BEGIN " +
                "rotten_ingredient_pkg.update_rotten_ingredient(" + rotten_Ingredient.Id + ", " + rotten_Ingredient.Ingredient_Id + ", " + rotten_Ingredient.Amount + ", '" + rotten_Ingredient.Date_Added.ToString(string.Format("dd/MMM/yyyy")) + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteRotten_Ingredient(int id)
        {
            string query =
                "BEGIN " +
                "rotten_ingredient_pkg.delete_rotten_ingredient(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

    }
}
