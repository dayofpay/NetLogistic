using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace NETLogistic.API
{
    class getVersion
    {
        public static string currentVersion
        {
            get;
            set;
        }
        public static void Check()
        {
            MySqlCommand checkVersion = new MySqlCommand("SELECT app_version FROM appinfo", Database.Database.connection);
            using (MySqlDataReader readVersion = checkVersion.ExecuteReader())
            {
                while (readVersion.Read())
                {
                    currentVersion = readVersion.GetString(0);
                }
                readVersion.Close();
            }
        }
    }
}
