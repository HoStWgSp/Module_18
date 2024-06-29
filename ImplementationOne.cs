using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    internal class ImplementationOne : BaseClass
    {
        public ImplementationOne(int id) : base(id) { }

        public override BaseClass Clone() { return new ImplementationOne(Id); }
    }
    internal class ImplementationTwo : BaseClass
    {
        public ImplementationTwo(int id) : base(id) { }

        public override BaseClass Clone() { return new ImplementationTwo(Id); }
    }
}
