using Module_18.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Module_18
{
    internal class Pult
    {
        IAction action;

        public void SetAction(IAction action) {  this.action = action; }

        public void OpenButton()
        {
            // запуск команды
            action.Run();
        }

        public void CloseButton()
        {
            // отмена команды
            action.Undo();
        }
    }
}
