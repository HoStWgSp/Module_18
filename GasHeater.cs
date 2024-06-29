using Module_18.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    internal class GasHeater : IHeater
    { 
        public void Heat()
        {
            Console.WriteLine("Нагрев газом");
        }
    }
}
