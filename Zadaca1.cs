using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadaca1
    {
        public static void IzracunDoGodine()
        {
            Console.Write("Unesite godinu do koje izračun: ");
            long godina = Int64.Parse(Console.ReadLine());

            Console.WriteLine($"Broj godina: {godina}");
            Console.WriteLine($"Broj mjeseci: {godina * 12}");
            Console.WriteLine($"Broj dana: {godina * 365}");
            Console.WriteLine($"Broj sati: {godina * 365 * 24}");
            Console.WriteLine($"Broj minuta: {godina * 365 * 24 * 60}");
            Console.WriteLine($"Broj sekundi: {godina * 365 * 24 * 60 * 60}");
        }
    }
}
