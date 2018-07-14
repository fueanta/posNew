using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software.Database.SQL
{
    public class Unit_TypeDB
    {
        public static List<Model.Unit_Type> GetAllUnit_Types()
        {
            List<Model.Unit_Type> types = new List<Model.Unit_Type>();
            string query = "SELECT * FROM UNIT_TYPE ORDER BY ID";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                types.Add(RowToEntity(row));
            }
            return types;
        }

        public static Model.Unit_Type RowToEntity(DataRow row)
        {
            Model.Unit_Type type = new Model.Unit_Type
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Name = row["Name"].ToString(),
                Symbol = row["Symbol"].ToString()
            };
            return type;
        }

        public static void InsertUnit_Type(Model.Unit_Type type)
        {
            string query =
                "BEGIN " +
                "unit_type_pkg.insert_unit_type('" + type.Name + "', '" + type.Symbol + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdateUnit_Type(Model.Unit_Type type)
        {
            string query =
                "BEGIN " +
                "unit_type_pkg.update_unit_type(" + type.Id + ", '" + type.Name + "', '" + type.Symbol + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteUnit_Type(int id)
        {
            string query =
                "BEGIN " +
                "unit_type_pkg.delete_unit_type(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }
    }
}
