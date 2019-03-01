using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phones
{
    public class Apple : Phone
    {
        public bool canFaceTime = true;
        public bool canApplePay = true;

        public Apple(string name, int size)
        {
            this.Name = name;
            this.Size = size;
        }

        public override string Display()
        {
            string iphoneInfo = base.Display();
            if (canFaceTime == true)
                iphoneInfo += $"The {this.Name} can Facetime, and ";
            iphoneInfo += $"The {this.Name} cannot Facetime, and ";

            if (canApplePay == true)
                iphoneInfo += $"this phone can use Apple Pay";
            iphoneInfo += $"this phone cannot use Apple Pay";
            return iphoneInfo;
        }
    }
}