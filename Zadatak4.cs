using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak4
    {
        public static void OsobniPodaciUnos()
        {
            string punoIme;
            string grad;
            sbyte starost;
            int postanskiBroj;

            Console.WriteLine("Unesite osobne podatke...");

            Console.Write("Ime i prezime: ");
            punoIme = Console.ReadLine();

            Console.Write("Grad: ");
            grad = Console.ReadLine();

            Console.Write("Unesite starost: ");

            starost = sbyte.Parse(Console.ReadLine());

            Console.Write("Unesite poštanski broj: ");

            postanskiBroj = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Uneseni su sljedeći podaci...");
            Console.WriteLine($"Ime i prezime: {punoIme}");
            Console.WriteLine($"Starost: {starost}");
            Console.WriteLine($"Grad: {grad}");          
            Console.WriteLine($"Poštanski broj: {postanskiBroj}");


        }
    }
}
