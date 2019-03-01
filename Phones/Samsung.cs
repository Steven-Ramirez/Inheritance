using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phones
{
    public class Samsung : Phone
    {
        public bool hasStylus = true;
        public bool alwaysOnDisplay = true;


        public Samsung(string samsungName, int samsungSize)
        {
            this.Name = samsungName;
            this.Size = samsungSize;
        }

        public override string Display()
        {
            string SamsungInfo = base.Display();
            if (hasStylus == true)
                SamsungInfo += $" The {this.Name} has a stylus and ";
            SamsungInfo += $" The {this.Name} does not has a stylus and ";

            if (alwaysOnDisplay == true)
                SamsungInfo += $" and {this.Name} has Always on Display";
            SamsungInfo += $" and {this.Name} does not have Always on Display";
            return SamsungInfo;
        }
    }
}