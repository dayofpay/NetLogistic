using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace NETLogistic.Database
{
    class Database
    {
        public static MySqlConnection connection { get; set; }
        public static string server { get; set; }
        public static string database { get; set; }
        public static string user { get; set; }
        public static string password { get; set; }
        public static string port { get; set; }
        public static string connectionString { get; set; }
        public static string sslM { get; set; }
        public static string conString { get; set; }
        public static void Connect()
        {
            server = "localhost";
            database = "logistic";
            user = "root";
            password = "";
            port = "3306";
            sslM = "none";
            connectionString = String.Format("server={0};port={1};user id={2}; password={3}; database={4}; SslMode={5}", server, port, user, password, database, sslM);
            conString = connectionString;
            connection = new MySqlConnection(conString);
            try
            {
                connection.Open();
                System.Threading.Thread.Sleep(1000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[!] Връзката със базата дани беше установена !");
            }
            catch (MySqlException getError)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"[!] ГРЕШКА: {getError.Message}");
                System.Threading.Thread.Sleep(4000);
            }
        }
    }
}
