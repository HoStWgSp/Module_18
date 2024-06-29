
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
            CarPlant carPlant = new CarPlant();

            Conveyor builder = new CarConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            builder = new MotoConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            builder = new ScooterConveyor();
            carPlant.Construct(builder);
            builder.Product.Show();

            Console.ReadKey();
        }
    }
}
