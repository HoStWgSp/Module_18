
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
            

            BaseClass myObject = new ImplementationOne(1);
            myObject.GetId();

            BaseClass clone = myObject.Clone();
            clone.GetId();

            myObject = new ImplementationTwo(2);
            myObject.GetId();

            clone = myObject.Clone();
            clone.GetId();

            Console.ReadKey();
        }
    }
}
