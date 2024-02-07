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
                Console.WriteLine("9. Zadatak9 (if_skracenice)");
                Console.WriteLine("10. Zadatak10 (if_korijen_jednadzbe)");
                Console.WriteLine("11. Zadatak11 (if_profit)");
                Console.WriteLine("12. Zadatak12 (Natjecanje)");
                Console.WriteLine("13. Zadatak13 (switchcase)");
                Console.WriteLine("14. Zadatak13 (samoglasnici)");
                Console.WriteLine("15. Zadatak13 (enumeratori)");
                Console.WriteLine("16. Zadatak13 (tekstualni tipovi)");
                Console.WriteLine("17. Zadatak13 (nizovi)");
                Console.WriteLine("z1. Zadaca 1 (IzracunOdGodine)");
                Console.WriteLine("z2. Zadaca 2 (ms_u_kmh_i_mph)");
                Console.WriteLine("z3. Zadaca 3 (longuInt)");
                Console.WriteLine("z4. Zadaca 4 (longuInt)");
                Console.WriteLine("z5. Zadaca 5 (longuInt)");
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
                    case "9":
                        Zadatak9.if_skracenice();
                        break;
                    case "10":
                        Zadatak10.if_korijen_jednadzbe();
                        break;
                    case "11":
                        Zadatak11.if_profit();
                        break;
                    case "12":
                        Zadatak12.Natjecanje();
                        break;
                    case "13":
                        Zadatak13.switchcase();
                        break;
                    case "14":
                        Zadatak14.samoglasnici();
                        break;
                    case "15":
                        Zadatak15.enumeratorStringa();
                        break;
                    case "16":
                        Zadatak16.tekstualni_tipovi();
                        break;
                    case "17":
                        Zadatak17.nizovi();
                        break;
                    case "18":
                        Zadatak18.arryListe();
                        break;
                    case "19":
                        Zadatak19.petlje();
                        break;
                    case "20":
                        Zadatak20.zadatak20();
                        break;
                    case "21":
                        Zadatak21.zadatak21();
                        break;
                    case "22":
                        Zadatak22.zadatak22();
                        break;
                    case "23":
                        Zadatak23.zadatak23();
                        break;
                    case "24":
                        Zadatak24.zadatak24();
                        break;
                    case "25":
                        Zadatak25.zadatak25();
                        break;
                    case "26":
                        Zadatak26.zadatak26();
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
                    case "z4":
                        Zadaca4.zadaca4();
                        break;
                    case "z5":
                        Zadaca5.zadaca5();
                        break;
                    case "z6":
                        Zadaca6.zadaca6();
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


