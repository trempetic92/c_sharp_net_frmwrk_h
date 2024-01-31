using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak9
    {
        public static void if_skracenice()
        {
            int broj;
            Console.WriteLine("Unesite broj...");

            broj = Int32.Parse(Console.ReadLine());

            
            if (broj > 0)
            {
                Console.WriteLine("Broj {0} je pozitivan broj",broj);
            }
            else 
            { 
                Console.WriteLine($"Broj {broj} nije pozitivan broj");
            }
        }
    }
}
