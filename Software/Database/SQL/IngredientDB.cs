using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Database.SQL
{
    public class IngredientDB
    {
        public static List<Model.Ingredient> GetAllIngredients()
        {
            List<Model.Ingredient> ingredients = new List<Model.Ingredient>();
            string query = "select * from ingredient order by Id";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                ingredients.Add(RowToEntity(row));
            }
            return ingredients;
        }

        public static Model.Ingredient RowToEntity(DataRow row)
        {
            Model.Ingredient ingredient = new Model.Ingredient
            {                
                Name = row["Name"].ToString(),
                Description = row["Description"].ToString(),                
                Unit_Cost = Int32.Parse(row["Unit_Cost"].ToString()),
                Amount = Double.Parse(row["Amount"].ToString()),
                Id = Int32.Parse(row["Id"].ToString()),
                Unit_Id = Int32.Parse(row["Unit_Id"].ToString())
            };
            return ingredient;
        }

        public static void InsertIngredient(Model.Ingredient ingredient)
        {
            string query =
                "BEGIN " +
                "ingredient_pkg.insert_ingredient('" + ingredient.Name + "', '" + ingredient.Description + "', " + ingredient.Unit_Id + ", " + ingredient.Unit_Cost + ", " + ingredient.Amount + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdateIngredient(Model.Ingredient ingredient)
        {
            string query =
                "BEGIN " +
                "ingredient_pkg.update_ingredient(" + ingredient.Id + ", '" + ingredient.Name + "', '" + ingredient.Description + "', " + ingredient.Unit_Id + ", " + ingredient.Unit_Cost + ", " + ingredient.Amount + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteIngredient(int id)
        {
            string query =
                "BEGIN " +
                "ingredient_pkg.delete_ingredient(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }
    }
}
