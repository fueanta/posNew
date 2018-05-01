using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Software.Database.SQL
{
    public class ChangelogDB
    {
        public static List<Model.Changelog> GetAllChangelog()
        {
            List<Model.Changelog> changelogs = new List<Model.Changelog>();
            string query = "select * from CHANGE_LOG order by id";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                changelogs.Add(RowToEntity(row));
            }
            return changelogs;
        }

        public static Model.Changelog RowToEntity(DataRow row)
        {
            Model.Changelog changelogs = new Model.Changelog
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Employee_Id = Int32.Parse(row["Employee_Id"].ToString()),
                Description = row["Description"].ToString(),
            };
            return changelogs;
        }

        public static void InsertChangelog(Model.Changelog changelogs)
        {
            string query =
                "BEGIN " +
                "change_log_pkg.insert_change_log('" + changelogs.Employee_Id + "', '" + changelogs.Description + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdateChangelog(Model.Changelog changelogs)
        {
            string query =
                "BEGIN " +
                "change_log_pkg.update_change_log('" + changelogs.Id + "', '" + changelogs.Employee_Id + "', '" + changelogs.Description + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteChangelog(int id)
        {
            string query =
                "BEGIN " +
                "change_log_pkg.delete_change_log(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }





    }
}
