using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phones
{
    class Program
    {
        static void Main(string[] args)
        {
            Samsung note8 = new Samsung("Note 8", 8) { alwaysOnDisplay = true, hasStylus = true };
            Samsung Razr = new Samsung("Razr", 5) { alwaysOnDisplay = false, hasStylus = false };

            Apple iphoneXS = new Apple("Iphone XS", 8) { canApplePay = true, canFaceTime = true };
            Apple iphone4 = new Apple("Iphone 4", 5) { canApplePay = false, canFaceTime = false };

            Console.ReadLine();
        }
    }
}
