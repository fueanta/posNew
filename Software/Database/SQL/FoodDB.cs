using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Database.SQL
{
    public class FoodDB
    {
        public static List<Model.Food> GetAllFoods()
        {
            List<Model.Food> foods = new List<Model.Food>();
            string query = "select * from food order by id";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                foods.Add(RowToEntity(row));
            }
            return foods;
        }

        public static Model.Food RowToEntity(DataRow row)
        {
            Model.Food food = new Model.Food
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Name = row["Name"].ToString(),
                Price = Int32.Parse(row["Price"].ToString()),
                Description = row["Description"].ToString(),
                Type_Id = Int32.Parse(row["Type_Id"].ToString()),
                Discount_Rate = Int32.Parse(row["Discount_Rate"].ToString()),
                Availability = row["Availability"].ToString(),
                Other_Charges = Int32.Parse(row["Other_Charges"].ToString()),                
                Picture = row["Picture"].ToString(),
                Stock_Count = Int32.Parse(row["Stock_Count"].ToString())
            };
            return food;
        }

        public static void InsertFood(Model.Food food)
        {
            string query =
                "BEGIN " +
                "food_pkg.insert_food('" + food.Name + "', " + food.Price + ", '" + food.Description + "', " + food.Type_Id + ", " + food.Discount_Rate + ", '" + food.Availability + "', " + food.Other_Charges + ", '" + food.Picture + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdateFood(Model.Food food)
        {
            string query =
                "BEGIN " +
                "food_pkg.update_food(" + food.Id + ", '" + food.Name + "', " + food.Price + ", '" + food.Description + "', " + food.Type_Id + ", " + food.Discount_Rate + ", '" + food.Availability + "', " + food.Other_Charges + ", '" + food.Picture + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteFood(int id)
        {
            string query =
                "BEGIN " +
                "food_pkg.delete_food(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdateStockCount(int Id)
        {
            string query =
                "DECLARE " +
                "COUNT number; " +
                "BEGIN " +
                "COUNT := generate_StockCount(" + Id + "); " +
                "UPDATE food SET STOCK_COUNT = COUNT WHERE Id = " + Id + "; " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

    }
}
