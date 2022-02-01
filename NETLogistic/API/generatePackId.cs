using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLogistic.API
{
    class generatePackId
    {
        public static int generatedId
        {
            get;
            set;
        }
        public static void Generate(int x,int y)
        {
            Random random = new Random();
            generatedId = random.Next(x, y); // Програмата генерира произволно число от диапазон X > Y въведени в метода от потребителя
        }
    }
}
