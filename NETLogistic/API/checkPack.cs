using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace NETLogistic.API
{
    class checkPack
    {
        public static void checkAllPacks()
        {
            MySqlCommand checkAllPacks = new MySqlCommand("SELECT * from packs", Database.Database.connection);
            using (MySqlDataReader readPacks = checkAllPacks.ExecuteReader())
            {
                if (readPacks.HasRows)
                {
                    while (readPacks.Read()){
                        Console.Title = "NETLogistic| Информация за пратка " + readPacks.GetString(0);
                        Console.WriteLine($"Номер на пратката: {readPacks.GetString(0)}");
                        Console.WriteLine($"Тегло на пратката: {readPacks.GetString(1)} KG");
                        Console.WriteLine($"Описание на пратката: {readPacks.GetString(2)}");
                        Console.WriteLine($"Пратката е изпратена на: {readPacks.GetString(3)}");
                        Console.WriteLine($"Име на получател: {readPacks.GetString(4)}");
                        Console.WriteLine($"Име на подател: {readPacks.GetString(5)}");
                        Console.WriteLine($"Прогнозирано време за получаване на пратка: {readPacks.GetString(6)}");
                        Console.WriteLine($"Тип на пратка: {readPacks.GetString(7)}");
                        Console.WriteLine($"Обща сума за пратката: {readPacks.GetString(8)} ЛВ");
                        Console.WriteLine($"Сума за доставка на пратката:{readPacks.GetString(9)} ЛВ");
                        Console.WriteLine($"Изпратена за град:{readPacks.GetString(10)}");
                        Console.WriteLine($"Изпратена от град:{readPacks.GetString(11)}");
                    }
                    Console.ReadKey();
                    readPacks.Close();
                }
            }
        }
        public static void packCheck(int packId)
        {
            MySqlCommand checkPack = new MySqlCommand("SELECT * FROM packs WHERE pack_id ='" + packId + "'",Database.Database.connection);
            using (MySqlDataReader readInfo = checkPack.ExecuteReader())
            {
                try
                {
                    if (readInfo.HasRows)
                    {
                        while (readInfo.Read())
                        {
                            Console.Title = "NETLogistic| Информация за пратка " + packId;
                            Console.WriteLine($"Номер на пратката: {readInfo.GetString(0)}");
                            Console.WriteLine($"Тегло на пратката: {readInfo.GetString(1)} KG");
                            Console.WriteLine($"Описание на пратката: {readInfo.GetString(2)}");
                            Console.WriteLine($"Пратката е изпратена на: {readInfo.GetString(3)}");
                            Console.WriteLine($"Име на получател: {readInfo.GetString(4)}");
                            Console.WriteLine($"Име на подател: {readInfo.GetString(5)}");
                            Console.WriteLine($"Прогнозирано време за получаване на пратка: {readInfo.GetString(6)}");
                            Console.WriteLine($"Тип на пратка: {readInfo.GetString(7)}");
                            Console.WriteLine($"Обща сума за пратката: {readInfo.GetString(8)} ЛВ");
                            Console.WriteLine($"Сума за доставка на пратката:{readInfo.GetString(9)} ЛВ");
                            Console.WriteLine($"Изпратена за град:{readInfo.GetString(10)}");
                            Console.WriteLine($"Изпратена от град:{readInfo.GetString(11)}");
                        }
                        Console.ReadKey();
                        readInfo.Close();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("[!] Няма такава пратка !");
                        System.Threading.Thread.Sleep(1500);
                        Program.Main();
                    }
                }
                catch (MySqlException error)
                {
                    Console.WriteLine($"Грешка: {error.Message}");
                }
            }
        }
    }
}
