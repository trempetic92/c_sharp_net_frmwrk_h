using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak25
    {
        public static void zadatak25()
        {
            int brojRedova = Int32.Parse(Console.ReadLine());
            int broj = 1;
            for (int i = 0; i <= brojRedova; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(broj++);

                }
                Console.WriteLine();
            }

            /*
            DZ
            trokut brojeva

            */

        }
    }
}
