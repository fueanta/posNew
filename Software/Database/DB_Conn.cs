using Oracle.ManagedDataAccess.Client;

namespace Software.Database
{
    public static class DB_Conn
    {
        // connection string attributes
        static string _data_source = "FuB-RoG:1521/XE";
        static string _user_id = "POS";
        static string _password = "pos";

        // oracle connection string generator
        static string GetOracleConnectionString()
        {
            return "Data Source=" + _data_source + ";User Id=" + _user_id + ";Password=" + _password + ";";
        }

        // oracle connection itself
        static OracleConnection _oracle_connection;

        // oracle connection generator
        public static OracleConnection GetOracleConnection()
        {
            // if connection has not been created, then ...
            if (_oracle_connection == null)
            {
                _oracle_connection = new OracleConnection
                {
                    ConnectionString = GetOracleConnectionString()
                };
            }

            // if connection is closed or broken, then ...
            try
            {
                if (_oracle_connection.State != System.Data.ConnectionState.Open)
                    _oracle_connection.Open();
            }
            catch (OracleException ex)
            {
                return null;
            }

            return _oracle_connection;
        }
    }
}