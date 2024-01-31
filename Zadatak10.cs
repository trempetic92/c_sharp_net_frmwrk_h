using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak10
    {
        public static void if_korijen_jednadzbe()
        {
            int a, b, c;

            double rezultat, x1, x2;

            Console.WriteLine("\n\n");
            Console.WriteLine("Izračunaj korijen kvadratne jednadžbe\n");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\n\n");

            Console.Write("Unesite vrijednost za a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite vrijednost za b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite vrijednost za c: ");
            c = Convert.ToInt32(Console.ReadLine());

            rezultat = b * b - 4 * a * c;

            if (rezultat == 0)
            {
                Console.WriteLine("Oba korijena su jednaka");
                x1 = -b / (2.0 * a);
                x2 = x1;
                Console.Write("Prvi korijen, x1 = {0}\n", x1);
                Console.Write("Drugi korijen, x1 = {0}\n", x2);
            }
            else if (rezultat > 0)
            {
                Console.Write("Oba korijena su realna.\n");
                x1 = (-b + Math.Sqrt(rezultat)) / (2 * a);
                x2 = (-b - Math.Sqrt(rezultat)) / (2 * a);

                Console.Write("Prvi korijen, x1 = {0}\n", x1);
                Console.Write("Drugi korijen, x1 = {0}\n", x2);
            }
            else
            {
                Console.WriteLine("Korijeni su imaginarni. \nNema rješenja. \n\n");
            }

        }
    }
}
