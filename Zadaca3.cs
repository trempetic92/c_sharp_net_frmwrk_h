using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadaca3
    {
        public static void longuint()
        {
            long velikiBroj = 123456789012345;
            Console.WriteLine((int)velikiBroj);
            Console.WriteLine("If the long value is outside the int range, the conversion\n effectively takes the lowest 32 bits of the long value and interprets that as an int.");
        }
    }
}
