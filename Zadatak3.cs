using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak3
    {
        public static void Varijable_brojevi()
        {
            int broj1 = 367521;
            uint broj2 = 986298376;
            long broj3 = Int64.MaxValue;
            ulong broj4 = UInt64.MaxValue;
            short broj5 = 32424;
            ushort broj6 = UInt16.MaxValue;
            byte broj7 = Byte.MaxValue;
            sbyte broj8 = sbyte.MinValue;

            Console.WriteLine($"{broj1}\n{broj2}\n{broj3}\n{broj4}\n{broj5}\n{broj6}\n{broj7}\n{broj8}\n");

            float dec1 = 1F / 3F;
            double dec2 = 1D / 3D;
            decimal dec3 = 1M / 3M;

            Console.WriteLine($"{dec1}\n{dec2}\n{dec3}\n");

            bool isTrue= true;
            Console.WriteLine(isTrue);

            string ime = "Marko";
            char PocetnoSlovoImena = ime[0];
            Console.WriteLine($"Prvo slovo imena {ime} je: {PocetnoSlovoImena}");


        }
    }
}
