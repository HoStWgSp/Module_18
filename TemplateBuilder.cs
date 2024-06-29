using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    abstract class TemplateBuilder
    {
        public Template Template { get; private set; }

        public void CreateTemplate()
        {
            Template = new Template();
        }

        public abstract void BuildHeader();
        public abstract void BuildFooter();
        public abstract void BuildBody();
    }
}
