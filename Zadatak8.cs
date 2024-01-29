using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak8
    {
        public static void KontrolaToka()
        {
            Console.WriteLine("Obični if...");

            string vrijeme = "Sunny";

            if (vrijeme == "Sunny")
            {
                Console.WriteLine("Vrijeme je Sunny");
            }

            Console.WriteLine("if else...");

            if (vrijeme == "sunny")
            {
                Console.WriteLine("Vrijeme je sunny");
            }
            else
            {
                Console.WriteLine("Vrijeme nije sunny");
            }

            Console.WriteLine("Nested if...");

            vrijeme = "oblacno";
            bool kisaPada = false;

            if (vrijeme == "oblacno")
            {
                if (!kisaPada)
                {
                    Console.WriteLine("Ipak možemo na kupanje");
                }
                else
                {
                    Console.WriteLine("Nemožemo na kupanje");
                }
            }

            Console.WriteLine("elseif ...");

            int x = 4;
            int y = 10;

            if (x > y)
            {
                Console.WriteLine("x > y");
            }
            else if (x == y) 
            {
                Console.WriteLine("x == y");
            }
            else
            {
                Console.WriteLine("x < y");
            }


        }
    }
}
