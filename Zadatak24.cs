using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak24
    {
        public static void zadatak24()
        {
            //pronađite proste brojeve u nekom rasponu brojeva

            int broj, rasponDonji, rasponGornji, brojac;
            Console.WriteLine("Donja granica raspona: ");
            rasponDonji = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Gornja granica raspona: ");
            rasponGornji = Int32.Parse(Console.ReadLine());

            brojac = 0;
            for (int i = rasponDonji; i<= rasponGornji; i++)
            {
                int brojDjeljivih = 0;
                for (broj = 2; broj < i/2 ; broj++)
                {
                    if (broj % 1 == 0)
                    {
                        brojDjeljivih++;
                        break;
                    }
                }
                if(brojDjeljivih == 0 && i!=1)
                {
                    brojac++;
                    Console.Write("");
                }


               



            }

        }
    }
}
