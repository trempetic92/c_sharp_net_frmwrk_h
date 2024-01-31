using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak12
    {
        public static void Natjecanje()
        {
            double osnoveProgramiranja, fizika, kemija, ukupno;
            double postotak;
            string ime, prezime, rezultatNatjecanja;

            Console.Write("Ime učenika: ");
            ime = Console.ReadLine();
            Console.Write("Prezime učenika: ");
            prezime = Console.ReadLine();

            Console.Write("Unesite ostvarene bodove iz Fizike (0-100): ");
            fizika = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite ostvarene bodove iz Kemije (0-100): ");
            kemija = Convert.ToInt32(Console.ReadLine());
            Console.Write("Unesite ostvarene bodove iz Osnova programiranja (0-100): ");
            osnoveProgramiranja = Convert.ToInt32(Console.ReadLine());

            // do 48% -> ekonomska
            // do 60% -> tehnička
            // preko 60% -> gimnazija

            ukupno = (fizika + kemija + osnoveProgramiranja) / 3.0;
            Console.WriteLine(ukupno);

            if (ukupno <= 48.0) 
            {
                Console.WriteLine("ekonomska");
            }
            else if (ukupno > 48.0 && ukupno < 60.0)
            {
                Console.WriteLine("tehnička");
            }
            else 
            {
                Console.WriteLine("gimnazija");
            }

        }
    }
}
