using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Database.SQL
{
    public class OrderFoodDB
    {
        public static List<Model.Order_Food> GetAllFoods()
        {
            List<Model.Order_Food> foods = new List<Model.Order_Food>();
            string query = "select name, price, id from food where availability = 'Yes' order by id";
            DataTable table = DB_Handler.GetDataTable(query);
            foods.Add(new Model.Order_Food { }); // taqui - patch
            foreach (DataRow row in table.Rows)
            {
                foods.Add(RowToEntity(row));
            }
            return foods;
        }

        private static Model.Order_Food RowToEntity(DataRow row)
        {
            var food = new Model.Order_Food
            {
                Name = row["Name"].ToString(),
                Count = 0,
                Unit_Price = Double.Parse(row["Price"].ToString()),
                Food_Id = Int32.Parse(row["Id"].ToString())
            };
            return food;
        }
        public static void InsertOrderFood(Software.Model.Order_Food food)
        {
            string query =
                "BEGIN " +
                "insert_order_food(" + food.Food_Id + ", " + food.Count + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }
    }
}
