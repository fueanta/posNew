using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Database.SQL
{
    public class FoodIngredientDB
    {
        public static List<Model.Food_Ingredient> GetUnusedIngredients(int Id)
        {
            List<Model.Food_Ingredient> ingredients = new List<Model.Food_Ingredient>();
            string query = "select i.id, i.name, i.unit_cost from ingredient i where i.id not in (select i.id from ingredient i, food_ingredient fi where i.id = fi.ingredient_id and fi.food_id = " + Id + ") order by i.id";
            DataTable table = DB_Handler.GetDataTable(query);
            ingredients.Add(new Model.Food_Ingredient { }); // taqui - patch
            foreach (DataRow row in table.Rows)
            {
                ingredients.Add(RowToEntity2(row));
            }
            return ingredients;
        }

        public static List<Model.Food_Ingredient> GetUsedIngredients(int Id)
        {
            List<Model.Food_Ingredient> f_ingredients = new List<Model.Food_Ingredient>();
            string query = "select fi.Ingredient_Id, i.Name, i.unit_cost, fi.Amount from ingredient i, food_ingredient fi where i.id = fi.ingredient_id and fi.food_id = " + Id;
            DataTable table = DB_Handler.GetDataTable(query);
            f_ingredients.Add(new Model.Food_Ingredient { }); // taqui - patch
            foreach (DataRow row in table.Rows)
            {
                f_ingredients.Add(RowToEntity(row));
            }
            return f_ingredients;
        }

        public static Model.Food_Ingredient RowToEntity(DataRow row)
        {
            Model.Food_Ingredient f_ingredient = new Model.Food_Ingredient
            {
                //Food_Id = Int32.Parse(row["Food_Id"].ToString()),
                Ingredient_Id = Int32.Parse(row["Ingredient_Id"].ToString()),
                Ingredient_Name = row["Name"].ToString(),
                Amount = Double.Parse(row["Amount"].ToString()),
                Unit_Cost = Int32.Parse(row["Unit_Cost"].ToString())
            };
            return f_ingredient;
        }

        public static Model.Food_Ingredient RowToEntity2(DataRow row)
        {
            Model.Food_Ingredient f_ingredient = new Model.Food_Ingredient
            {
                Ingredient_Id = Int32.Parse(row["Id"].ToString()),
                Ingredient_Name = row["Name"].ToString(),
                Amount = 0.0d,
                Unit_Cost = Int32.Parse(row["Unit_Cost"].ToString())
            };
            return f_ingredient;
        }

        public static void InsertFoodIngredient(Model.Food_Ingredient fi, int Id)
        {
            string query =
                "BEGIN " +
                "food_ingredient_pkg.insert_food_ingredient(" + Id + ", " + fi.Ingredient_Id + ", " + fi.Amount + ");" +
                " END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteFoodIngredient(int Id)
        {
            string query =
                "BEGIN " +
                "food_ingredient_pkg.delete_food_ingredient(" + Id + ");" +
                " END;";
            DB_Handler.ExecuteQuery(query);
        }

    }
}
