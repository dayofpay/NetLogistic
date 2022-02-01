using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace NETLogistic.API
{
    class sendPack
    {
        public static void Send(int packId,double packWeight,string packDesc,string packSendDate,string packReceiver,string packSender,string packEsetDelivery,string packType,double packtotalPrice,double packDeliveryPrice,string packDeliverCity,string packSentFromCitty)
        {
            MySqlCommand insertData = new MySqlCommand("INSERT INTO packs(pack_id,pack_weight,pack_description,pack_sent_date,pack_receiver,pack_sent_from,pack_estimated_delivery,pack_type,pack_total_price,pack_delivery_price,pack_deliver_city,pack_sent_from_city)VALUES('" + packId +"','" + packWeight + "','" +packDesc + "','" + packSendDate + "','" + packReceiver + "','" + packSendDate + "','" + packEsetDelivery + "','" + packType + "','" + packtotalPrice + "','" + packDeliveryPrice + "','" + packDeliverCity + "','" + packSentFromCitty+"'" + ");",Database.Database.connection);
            try
            {
                insertData.ExecuteScalar(); // Правим опит да въведем данните в таблицата
                Console.Beep(255,1000); // Активираме звук със честота 255 за 1 секунда
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(API.getUsername.username + $", [{packSender}, изпратихте успешно пратка {packId} ! :)");
                System.Threading.Thread.Sleep(7500); // Правим пауза от 7.5 секунди
                Program.Main(); // Връщаме се в Main метода ( Началото на програмта )
            }
            catch(MySqlException error)
            {
                Console.WriteLine($"Грешка : {error.Message}");
                System.Threading.Thread.Sleep(7500); // Правим пауза от 7.5 секунди
                Program.Main(); // Връщаме се в Main метода ( Началото на програмта )
            }
        }
    }
}
