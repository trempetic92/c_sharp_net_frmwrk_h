using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak13
    {
        public static void switchcase()
        {
            Console.WriteLine();

            Console.WriteLine("=========================");
            Console.WriteLine("Primjer provjera dana u tjednu po njegovom broju:");

            Console.Write("Unesi broj dana: ");
            int brojDana = Int32.Parse(Console.ReadLine());

            switch (brojDana)
            {
                case 1:
                    Console.WriteLine("Ponedjeljak");
                    break;
                case 2:
                    Console.WriteLine($"Utorak");
                    break;
                case 3:
                    Console.WriteLine($"Srijeda");
                    break;
                case 4:
                    Console.WriteLine($"Četvrtak");
                    break;
                case 5:
                    Console.WriteLine($"Petak");
                    break;
                case 6:
                    Console.WriteLine($"Subota");
                    break;
                case 7:
                    Console.WriteLine($"Nedjelja");
                    break;
                default:
                    Console.WriteLine("Neznamo koji je dan");
                    break;
            }
        }
    }
}
