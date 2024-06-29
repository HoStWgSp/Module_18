using Module_18.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    internal class Place : ILocation
    {
        string Address;

        public Place(string address)
        {
            Address = address;
        }

        public ILocation Clone() { return new Place(Address); }

        public void GetInfo() { Console.WriteLine($"Новый объект по адресу {Address}. "); }
    }
}
