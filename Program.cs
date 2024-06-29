
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
            var sender = new Sender();

            var receiver = new Receiver();

            var commandOne = new CommandOne(receiver);

            sender.SetCommand(commandOne);

            sender.Run();

            Console.ReadKey();
        }
    }
}
