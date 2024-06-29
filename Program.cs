
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Подключаем котел на газу
            var boiler = new Boiler(30, "Bosch", new GasHeater());
            // Запускаем
            boiler.Start();

            // газ закончился. Переключаемся на электричество
            boiler.Heater = new ElectricHeater();
            // Запускаем
            boiler.Start();

            Console.ReadKey();
        }
    }
}
