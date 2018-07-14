using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Database.SQL
{
    public class Food_TypeDB
    {
        public static List<Model.Food_Type> GetAllFood_Types()
        {
            List<Model.Food_Type> food_Types = new List<Model.Food_Type>();
            string query = "select * from food_type order by id";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                food_Types.Add(RowToEntity(row));
            }
            return food_Types;
        }

        public static Model.Food_Type RowToEntity(DataRow row)
        {
            Model.Food_Type food_Type = new Model.Food_Type
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Type_Name = row["Type_Name"].ToString(),
                Description = row["Description"].ToString()
            };
            return food_Type;
        }

        public static void InsertFood_Type(Model.Food_Type food_Type)
        {
            string query =
                "BEGIN " +
                "food_type_pkg.insert_food_type('" + food_Type.Type_Name + "', '" + food_Type.Description + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdateFood_Type(Model.Food_Type food_Type)
        {
            string query =
                "BEGIN " +
                "food_type_pkg.update_food_type(" + food_Type.Id + ", '" + food_Type.Type_Name + "', '" + food_Type.Description + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteFood_Type(int id)
        {
            string query =
                "BEGIN " +
                "food_type_pkg.delete_food_type(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }
    }
}
