using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeReflection
{
    public class DescriptionAttribute:Attribute
    {
        public string text { get; set; } 
        public DescriptionAttribute(string text)
        {
            this.text = text;
        }
    }
}
