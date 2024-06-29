using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_18
{
    internal class Template
    {
        public Header Header { get; set; }
        public Body Body { get; set; }
        public Footer Footer { get; set; }
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            
            if (Header != null)
                text.Append(Header.Text + "\n");

            if (Body != null)
                text.Append($"{Body.Text} \n");

            if (Footer != null)
                text.Append($"{Footer.Text} \n");

            return text.ToString();
        }
    }
}
