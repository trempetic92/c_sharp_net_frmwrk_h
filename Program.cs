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
                Console.WriteLine("1. Zadatak (HelloWorld)");
                Console.WriteLine("2. Zadatak (Varijable_uvod)");
                Console.WriteLine("3. Zadatak (Varijable_brojevi)");
                Console.WriteLine("4. Zadatak (Unos_podataka_osobniPodaci)");
                Console.WriteLine("5. Zadatak (Varijable_pravokutnik)");
                Console.WriteLine("6. Zadatak (Varijable_zamjene)");
                Console.WriteLine("7. Zadatak (Boolean_I_Operatori)");
                Console.WriteLine("8. Zadatak (Kontrola_Toka)");
                Console.WriteLine("z1. Zadaca 1 (IzracunOdGodine)");
                Console.WriteLine("z2. Zadaca 2 (ms_u_kmh_i_mph)");
                Console.WriteLine("z3. Zadaca 3 (longuInt)");
                Console.WriteLine("0. Izlaz\n\n");

                string odabir = Console.ReadLine();
                Console.WriteLine();

                switch (odabir)
                {
                    case "1":
                        Zadatak1.ispisi_HelloWorld();
                        break;
                    case "2":
                        Zadatak2.Varijable_uvod();
                        break;
                    case "3":
                        Zadatak3.Varijable_brojevi();
                        break;
                    case "4":
                        Zadatak4.OsobniPodaciUnos();
                        break;
                    case "5":
                        Zadatak5.Pravokutnik();
                        break;
                    case "6":
                        Zadatak6.VarijablaZamjena();
                        break;
                    case "7":
                        Zadatak7.BooleanIIoeratori();
                        break;
                    case "8":
                        Zadatak8.KontrolaToka();
                        break;
                    case "z1":
                        Zadaca1.IzracunDoGodine();
                        break;
                    case "z2":
                        Zadaca2.Izracun_kmh_mph();
                        break;
                    case "z3":
                        Zadaca3.longuint();
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


