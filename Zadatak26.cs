using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak26
    {
        public static void zadatak26()
        {
            string[] automobili = { "Volvo", "BMW", "Mazda", "Ford" };

            foreach (string mobili in automobili)
            {
                Console.WriteLine(mobili);
            }


            char[] spolovi = { 'm', 'ž', 'm', 'ž', 'ž' };
            int brojacM = 0;
            int brojacZ = 0;
            foreach (char m in spolovi)
            {
                if (m == 'm')
                {
                    brojacM++;
                }
                if (m == 'ž')
                {
                    brojacZ++;
                }
            }

            Console.WriteLine("Broj muških:" + brojacM);
            Console.WriteLine("Broj ženskih:" + brojacZ);

            int parni = 0;
            int neparni = 0;

            List<int> list = new List<int> { 2, 4, 34, 867, 33, 11 };

            foreach (int i in list)
            {
                if (i % 2 == 0)
                {
                    parni++;
                }
                if (i % 2 != 0)
                {
                    neparni++;
                }
            }

            Console.WriteLine(parni);
            Console.WriteLine(neparni);

            

        }
    }
}
