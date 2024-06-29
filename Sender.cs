using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    internal class Sender
    {
        Command command;

        public void SetCommand(Command command) {  this.command = command; }
        public void Run() { command.Run(); }
        public void Cancel() { command.Cancel(); }
    }
}
