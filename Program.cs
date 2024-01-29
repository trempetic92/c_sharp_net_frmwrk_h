using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool nastavi = true;
            while (nastavi)
            {
                Console.WriteLine("\nOdabir zadatka:\n");
                Console.WriteLine("1. Prvi zadatak (HelloWorld)");
                Console.WriteLine("2. Drugi zadatak (Varijable_uvod)");
                Console.WriteLine("3. Treći zadatak (Varijable_brojevi)");
                Console.WriteLine("4. Četvrti zadatak (Unos_podataka_osobniPodaci)");
                Console.WriteLine("5. Peti zadatak (Varijable_pravokutnik)");
                Console.WriteLine("6. Šesti zadatak (Varijable_zamjene)");
                Console.WriteLine("z1. Zadaca 1 (IzracunOdGodine)");
                Console.WriteLine("z2. Zadaca 2 (ms_u_kmh_i_mph)");
                Console.WriteLine("0. Izlaz");

                string odabir = Console.ReadLine();

                switch (odabir)
                {
                    case "1":
                        PrviZadatak.ispisi_HelloWorld();
                        break;
                    case "2":
                        DrugiZadatak.Varijable_uvod();
                        break;
                    case "3":
                        TreciZadatak.Varijable_brojevi();
                        break;
                    case "4":
                        CetvrtiZadatak.OsobniPodaciUnos();
                        break;
                    case "5":
                        PetiZadatak.Pravokutnik();
                        break;
                    case "6":
                        SestiZadatak.VarijablaZamjena();
                        break;
                    case "z1":
                        Zadaca1.IzracunDoGodine();
                        break;
                    case "z2":
                        Zadaca2.Izracun_kmh_mph();
                        break;
                    case "0":
                        nastavi = false;
                        break;
                    default:
                        Console.WriteLine("\nUnesite valjani broj zadatka.");
                        Console.Write(odabir);
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}


