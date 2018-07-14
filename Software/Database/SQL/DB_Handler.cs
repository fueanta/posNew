using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace Software.Database.SQL
{
    public class DB_Handler
    {
        internal static DataSet GetDataSet(string query)
        {
            // Getting oracle connection first
            OracleConnection connection = DB_Conn.GetOracleConnection();

            if (connection != null)
            {
                // Creating Oracle Command for perticular query through that connection
                OracleCommand command = new OracleCommand(query, connection);
                // Converting the command into C# dataset
                OracleDataAdapter dataAdapter = new OracleDataAdapter(command);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                // Closing the connection
                connection.Close();
                // Returning dataset
                return dataSet;
            }
            return null;
        }

        public static DataTable GetDataTable(string query)
        {
            DataSet dataSet = GetDataSet(query);
            if (dataSet.Tables.Count > 0)
                return dataSet.Tables[0];
            return null;
        }

        internal static int ExecuteQuery(string query)
        {
            // Getting oracle connection first
            OracleConnection connection = DB_Conn.GetOracleConnection();

            if (connection != null)
            {
                // Creating Oracle Command for perticular query through that connection
                OracleCommand command = new OracleCommand(query, connection);
                return command.ExecuteNonQuery();
            }

            return 0;
        }
    }
}
