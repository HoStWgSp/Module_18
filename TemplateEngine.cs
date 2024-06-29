using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    internal class TemplateEngine
    {
        public Template GenerateTemplate(TemplateBuilder templateBuilder)
        {
            templateBuilder.CreateTemplate();

            templateBuilder.BuildHeader();
            templateBuilder.BuildBody();
            templateBuilder.BuildFooter();

            return templateBuilder.Template;
        }
    }
}
