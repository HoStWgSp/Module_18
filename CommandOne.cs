using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    internal class CommandOne : Command
    {
        Receiver receiver;
        public CommandOne(Receiver receiver) { this.receiver = receiver; }

        public override void Run()
        {
            Console.WriteLine("Команда отправлена");
            receiver.Operation();
        }

        public override void Cancel() { }
    }
}
