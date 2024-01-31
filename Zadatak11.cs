using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak11
    {
        public static void if_profit()
        {
            {
                double cijenaProizvodnje;
                double cijenaProdajna;

                Console.Write("Unesite proizvodnu cijenu: ");
                cijenaProizvodnje = double.Parse(Console.ReadLine());
                Console.Write("Unesite prodajnu cijenu: ");
                cijenaProdajna = double.Parse(Console.ReadLine());

                if (cijenaProizvodnje < cijenaProdajna)
                {
                    double profit = cijenaProdajna - cijenaProizvodnje;
                    Console.WriteLine($"Gubitak u iznosu od {profit}");
                }
                else if (cijenaProizvodnje > cijenaProdajna)
                {


                    double profit = cijenaProizvodnje - cijenaProdajna;
                    Console.WriteLine($"Dobit {profit}");

                }
                else
                {

                    Console.WriteLine($"Na nuli smo nuli smo");
                }
            }
        }
    }
}
