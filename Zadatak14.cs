using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak14
    {
        public static void samoglasnici()
        {
            {
                Console.WriteLine("Unesite slovo za provjeru je li je samoglasnik");
                char samoglasnik = Console.ReadLine().ToLower()[0];

                switch(samoglasnik)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine("Samoglasnik");
                        break;
                    default:
                        Console.WriteLine("Nije samoglasnik");
                        break;
                }
            }
        }
    }
}
