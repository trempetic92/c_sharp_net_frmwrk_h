using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadaca2
    {
        public static void Izracun_kmh_mph()
        {
            Console.WriteLine("Unesite broj m/s: ");
            double brzinaPoSekundi = double.Parse(Console.ReadLine());


            Console.WriteLine($"Izračun u kmh: {(brzinaPoSekundi * 1000) / 3600}");
            Console.WriteLine($"Izračun u mph: {((brzinaPoSekundi * 1000) / 3600) * 0.621371192}");
        }
    }
}
