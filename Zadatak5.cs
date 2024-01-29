using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak5
    {
        public static void Pravokutnik()
        {
            Console.WriteLine("Unesite stranice pravokutnika...");
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine($"Opseg = {2 * (a + b)}");
            Console.WriteLine($"Površina = {a * b}");
            Console.WriteLine($"Dijagonala  = {Math.Sqrt(a * a + b * b)}");

            //Nacrtaj pravokutnik pomoću znaka #
            for (int i = 0; i < a; i++)
            {               
                for (int j = 0; j < b; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine("#");
            }

        }
    }
}
