using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Software.Database.SQL
{
    public class DataDB
    {
        public static List<Model.Data> GetAllChangelog()
        {
            List<Model.Data> Data = new List<Model.Data>();
            string query = "select * from Data order by id";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                Data.Add(RowToEntity(row));
            }
            return Data;
        }

        public static Model.Data RowToEntity(DataRow row)
        {
            Model.Data Data = new Model.Data
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Data_Value = Int32.Parse(row["Data_Value"].ToString()),
                Data_Name = row["Data_Name"].ToString(),
            };
            return Data;
        }

        public static void InsertData(Model.Data Data)
        {
            string query =
                "BEGIN " +
                "data_pkg.insert_data('" + Data.Data_Name + "', '" + Data.Data_Value + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdateData(Model.Data Data)
        {
            string query =
                "BEGIN " +
                "data_pkg.update_data('" + Data.Id + "', '" + Data.Data_Name + "', '" + Data.Data_Value + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteData(int id)
        {
            string query =
                "BEGIN " +
                "data_pkg.delete_data(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

    }
}
