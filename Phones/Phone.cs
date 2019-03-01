using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones
{
    public class Phone
    {
        public int Size;
        public string Name;

        public Phone()
        {
         
        }

        public virtual string Display()
        {
            string s = "";
            s += $"The {this.Name} is {this.Size}";
            return s;
        }
    }
}
