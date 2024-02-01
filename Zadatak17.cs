using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak17
    {
        public static void nizovi()
        {
            int[] nizBrojeva = new int[3];
            nizBrojeva[2] = 10;
            nizBrojeva[0] = 30;
            nizBrojeva[1] = 50;
            for (int i = 0; i < nizBrojeva.Length; i++)
            {
                Console.WriteLine(nizBrojeva[i]);
            }

            string[] nizStringova = new string[3] { "prvi", "drugi", "treći" };

            for (int i = 0; i < nizStringova.Length; i++)
            {
                Console.WriteLine(nizStringova[i]);
            }

            string[] tekstovi = new string[3];

            for (int i = 0; i < tekstovi.Length; i++)
            {
                Console.WriteLine($"{i+1}. element je: \"{tekstovi[i]}\"");
            }

            
        }
    }
}
