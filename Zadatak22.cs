using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak22
    {
        public static void zadatak22()
        {
            // do-While

            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            }
            while (i < 0);


            i = 0;
            while (i < 0)
            {
                Console.WriteLine(i);
                i++;
            }


            string ime = "";

            do
            {
                Console.WriteLine("Unesite ime: ");
                ime= Console.ReadLine();
                Console.WriteLine("Dobar dan, " + ime);
            } while (ime != "kraj");

        }
    }
}
