using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLogistic.Options
{
    class listOptions
    {
        public static double deliverySum
        {
            get;
            set;
        }
        public static string senderName
        {
            get;set;
        }
        public static string receiverName
        {
            get;
            set;
        }
        public static void List(string listType)
        {
            if(listType == "guest")
            {
                Console.WriteLine("1) Проверка на пратка");
                Console.WriteLine("2) Създаване на нова пратка");
                Console.WriteLine("3) Премахване на пратка");
                Console.WriteLine("4) Админ панел");
                Console.WriteLine("");
                Console.Write("Опция: ");
                var opciq = int.Parse(Console.ReadLine());
                if(opciq == 1)
                {
                    Console.Write("Номер на пратка: ");
                    var nomernaPratka = int.Parse(Console.ReadLine());
                    API.checkPack.packCheck(nomernaPratka);
                }
                if(opciq == 2)
                {
                    Console.Clear();
                    Console.Write("Тегло на пратката : ");
                    var teglo = double.Parse(Console.ReadLine());
                    if(teglo <= 1) // Ако теглото е по-малко или равно на 1, цената на доставката ще бъде 2.60 ЛВ
                    {
                        deliverySum = 2.60;
                    }
                    else if(teglo >= 1 && teglo <= 3) // Ако теглото е по-голямо или равно на 1 и не по-малко от 3, цената на доставката ще бъде 4.60 ЛВ
                    {
                        deliverySum = 4.60;
                    }
                    else if(teglo >=3 && teglo <= 10) // Ако теглото е по-голямо или равно на 3 и не по-малко от 10, цената на доставката ще бъде 10 ЛВ
                    {
                        deliverySum = 10;
                    }
                    else if(teglo > 10) // За всеки килограм над 10 ще се добавя 1 ЛВ ( Пример 200 КГ = 200 ЛВ )
                    {
                        deliverySum = 1 * teglo;
                    }
                    Console.Clear();
                    Console.Write("Описание на пратката : ");
                    var packDesc = Console.ReadLine();
                    Console.Clear();
                    Console.Write("Дата на изпращане на пратката : ");
                    var sendDate = Console.ReadLine();
                    Console.Clear();
                    Ime:
                    Console.Write("Име на получател: ");
                    var receiver = Console.ReadLine();
                    var tNames = receiver.Split(new[] { ' ' });
                    if(tNames[0] == "")
                    {
                        Console.WriteLine("Моля, въведете име...");
                        goto Ime;
                    }
                    if(tNames[1] == "")
                    {
                        Console.WriteLine("Моля, въведете презиме...");
                        goto Ime;
                    }
                    if (tNames[2] == "")
                    {
                        Console.WriteLine("Моля, въведете фамилия...");
                        goto Ime;
                    }
                    else
                    {
                        receiverName = tNames[0] + " " + tNames[1] + " " + tNames[2]; 
                        Console.Clear();
                        Imena:
                        Console.Write("Вашите имена: ");
                        var sender = Console.ReadLine();
                        var tSender = sender.Split(new[] { ' ' });
                        if (tSender[0] == "")
                        {
                            Console.WriteLine("Моля, въведете име...");
                            goto Imena;
                        }
                        if (tSender[1] == "")
                        {
                            Console.WriteLine("Моля, въведете презиме...");
                            goto Imena;
                        }
                        if (tSender[2] == "")
                        {
                            Console.WriteLine("Моля, въведете фамилия...");
                            goto Imena;
                        }
                        else
                        {
                            senderName = tSender[0] + " " + tSender[1] + " " + tSender[2];
                            Console.Clear();
                            Console.Write("Прогнозирана дата на получаване: ");
                            var prognozaZaPoluchavane = Console.ReadLine();
                            Console.Clear();
                            Console.Write("Тип на пратката: ");
                            var packType = Console.ReadLine();
                            Console.Clear();
                            Console.Write("Цена на пратката: ");
                            var cena = double.Parse(Console.ReadLine());
                            Console.Clear();
                            Console.Write("Пратката е изпратена от град: ");
                            var grad = Console.ReadLine();
                            Console.Clear();
                            Console.Write("Пратката се изпраща за град: ");
                            var gradIzprashta = Console.ReadLine();
                            API.generatePackId.Generate(1000, 949285);
                            API.sendPack.Send(API.generatePackId.generatedId, teglo, packDesc, sendDate, receiverName, senderName, prognozaZaPoluchavane, packType, cena + deliverySum, deliverySum, gradIzprashta, grad);
                        }
                    }
                }
                if(opciq == 4)
                {
                    Console.WriteLine("Passcode: ");
                    var passCode = Console.ReadLine();
                    if(passCode == "<Execute>$AdminPanel</Execute>")
                    {
                        Console.WriteLine("[1] Провери всички пратки");
                        Console.WriteLine("[2] Изтрий пратка");
                        Console.WriteLine("[3] Актуализирай пратка");
                        Console.WriteLine("");
                        Console.Write("Опция: ");
                        var option = int.Parse(Console.ReadLine());
                        if(option == 1)
                        {
                            API.checkPack.checkAllPacks();
                        }
                        // Всички останали опции ще бъдат довършени в предстощи актуализации
                    }
                    else
                    {
                        Console.WriteLine("[!] Грешен код !");
                        System.Threading.Thread.Sleep(1000);
                        Console.Clear();
                        Program.Main();
                    }
                }
            }
        }
    }
}
