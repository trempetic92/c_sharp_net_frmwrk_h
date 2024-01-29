using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class SedmiZadatak
    {
        public static void BooleanIIoeratori()
        {
            bool predavanjeJeZabavno = true;
            bool vrijemeJeLijepo = false;

            Console.WriteLine(predavanjeJeZabavno);
            Console.WriteLine(vrijemeJeLijepo);

            int x = 1;
            int y = 3;
            Console.WriteLine("Usporedba vrijednosti...");

            Console.WriteLine(x > y);
            Console.WriteLine(x < y);
            Console.WriteLine(x == y);
            Console.WriteLine(x != y);
            Console.WriteLine(x = y);
            Console.WriteLine(x > y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine("=================\n");

            Console.WriteLine("Tablica istinitosti za logičke operatore...");
            Console.WriteLine("Negacija\n!");
            Console.WriteLine(!true);  //false
            Console.WriteLine(!false); //true
            Console.WriteLine();
            Console.WriteLine("Logički I\t&&");
            Console.WriteLine(true && true);   //1
            Console.WriteLine(true && false);  //0
            Console.WriteLine(false && true);  //0
            Console.WriteLine(false && false); //0

            Console.WriteLine();
            Console.WriteLine("Logički ILI\t||");
            Console.WriteLine(true || true);   //1
            Console.WriteLine(true || false);  //1
            Console.WriteLine(false || true);  //1
            Console.WriteLine(false || false); //0
        }
    }
}
