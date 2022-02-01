using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETLogistic.Database;
namespace NETLogistic
{
    class Program
    {
        public static void Main()
        {
            API.startExecutors.executeEvents(); // При стартиране на софтуера изпълняваме редица от събития, като проверка на версия, проверка за връзка със базата данни и т.н
            Console.WriteLine($"Добре дошъл, {API.getUsername.username}, във NETLogistic (Версия {API.getVersion.currentVersion})");
            System.Threading.Thread.Sleep(1500); // Правим пауза на конзолата за 1.5 секунди
            Console.WriteLine("Моля, избери опция: ");
            Options.listOptions.List("guest");
        }
    }
}
