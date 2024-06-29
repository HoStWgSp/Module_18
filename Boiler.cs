using Module_18.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    internal class Boiler
    {
        protected int Power;
        protected string Model;

        public Boiler(int power, string model, IHeater heater)
        {
            Power = power;
            Model = model;
            Heater = heater;
        }

        public IHeater Heater { get; set; }

        public void Start() { Heater.Heat(); }
    }
}
