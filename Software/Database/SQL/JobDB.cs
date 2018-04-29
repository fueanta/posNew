using System;
using System.Collections.Generic;
using System.Data;


namespace Software.Database.SQL
{
    public class JobDB
    {
        public static List<Model.Job> GetAllJobs()
        {
            List<Model.Job> jobs = new List<Model.Job>();
            string query = "SELECT * FROM JOB";
            DataTable table = DB_Handler.GetDataTable(query);
            foreach(DataRow row in table.Rows)
            {
                jobs.Add(RowToEntity(row));
            }
            return jobs;
        }

        public static Model.Job RowToEntity(DataRow row)
        {
            Model.Job job = new Model.Job
            {
                Id = Int32.Parse(row["Id"].ToString()),
                Job_Title = row["Job_Title"].ToString(),
                Salary = Int32.Parse(row["Salary"].ToString()),
                Description = row["Description"].ToString()
            };
            return job;
        }

        public static void UpdateJob(Model.Job job)
        {
            string query =
                "BEGIN " +
                "update_job(" + job.Id + ", '" + job.Job_Title + "', " + job.Salary + ", '" + job.Description + "'); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }

        public static void DeleteJob(int id)
        {
            string query =
                "BEGIN " +
                "delete_job(" + id +  "); " +
                "END;";
            DB_Handler.ExecuteQuery(query);
        }
    }
}
