using System.Configuration;
using MySql.Data.MySqlClient;

namespace ToolTest.Models.Services
{
     public static class Conection
    {
        public static string ConnectionString;
        const string connectKey= "RunMode";
        public static MySqlConnection connection { get; set; }

        static Conection()
        {
            var tmp = ConfigurationManager.AppSettings[connectKey];

            ConnectionString = ConfigurationManager.ConnectionStrings["DB."+tmp].ConnectionString;

        }

        public static MySqlConnection ConnectDB()
        {
            connection = new MySqlConnection(ConnectionString);
            connection.Open();
            return connection;
        }

        public static void DisConnectDB()
        {
            connection.Close();
        }
    }
}
