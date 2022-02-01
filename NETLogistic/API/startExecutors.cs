using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLogistic.API
{
    class startExecutors
    {
        public static void executeEvents()
        {
            Console.Title = "NETLogistic | Добре дошли"; // Задаваме името на конзолата
            Console.Clear(); // Трием конзолата
            Database.Database.Connect(); // Пробваме да се свържем със базата данни
            getVersion.Check(); // Правим проверка на версията


            // NetLogistic Version 1.0 || Автор: dayofpay || //
        }
    }
}
