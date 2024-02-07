using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak21
    {
        public static void zadatak21()
        {
            //prebroji broj pojava jednog niza u drugom (string)

            //npr . 1. niz: Ovo je primjer za provjeru.  
            //      2. niz: je

            Console.WriteLine("Unesite rečenicu: ");
            string recenica = Console.ReadLine();

            Console.WriteLine("Unesite traženu riječ");
            string rijec = Console.ReadLine();
            int pocetak = 0;
            int brojac = -1;
            int index = -1;


            while (pocetak != -1)
            {
                pocetak = recenica.IndexOf(rijec, index + 1);
                brojac++;
                index = pocetak;
            }

            Console.WriteLine(brojac);

            
            

        }
    }
}
