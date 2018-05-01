using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Software.Database.SQL
{
    public class PeriodDB
    {
        public static List<Model.Period> GetAllPeriods()
        {
            List<Model.Period> period = new List<Model.Period>();
            string query = "select * from PERIOD order by id";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach (DataRow row in table.Rows)
            {
                period.Add(RowToEntity(row));
            }
            return period;
        }

        public static Model.Period RowToEntity(DataRow row)
        {
            Model.Period period = new Model.Period
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Employee_Id = Int32.Parse(row["Employee_Id"].ToString()),
                Login_Time = Convert.ToDateTime(row["Login_Time"]),
                Logout_Time = Convert.ToDateTime(row["Logout_Time"])
            };
            return period;
        }

        public static void InsertPeriod(Model.Period period)
        {
            string query =
                "BEGIN " +
                "period_pkg.insert_period(" + period.Employee_Id + ", '" + period.Login_Time.ToString(string.Format("dd/MMM/yyyy")) + "', '" + period.Logout_Time.ToString(string.Format("dd/MMM/yyyy")) + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void UpdatePeriod(Model.Period period)
        {
            string query =
                "BEGIN " +
                "period_pkg.update_period(" + period.Id + ", " + period.Employee_Id + ", '" + period.Login_Time.ToString(string.Format("dd/MMM/yyyy")) + "', '" + period.Logout_Time.ToString(string.Format("dd/MMM/yyyy")) + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeletePeriod(int id)
        {
            string query =
                "BEGIN " +
                "period_pkg.delete_period(" + id + "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

    }
}
