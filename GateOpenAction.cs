using Module_18.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    internal class GateOpenAction : IAction
    {
        Gate gate;

        public GateOpenAction(Gate gate)
        {
            this.gate = gate;
        }

        public void Run()
        {
            gate.Open();
        }

        public void Undo()
        {
            gate.Close();
        }
    }
}
