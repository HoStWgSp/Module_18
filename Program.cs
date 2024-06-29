
using Module_18.Interfaces;
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
            ILocation location = new Point(45.22, 13.56);
            ILocation newLocation = location.Clone();

            location.GetInfo();
            newLocation.GetInfo();

            location = new Place("Аравинская стрит");
            newLocation = location.Clone();
            location.GetInfo();
            newLocation.GetInfo();

            Console.ReadKey();
        }
    }
}
