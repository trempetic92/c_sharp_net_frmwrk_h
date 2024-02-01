using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadaca5
    {
        public static void zadaca5()
        {
            //Napišite program kako biste pronašli prihvatljivost za upis na stručni studij

            int fizika, kemija, matematika;

            Console.Write("Unesite bodove iz fizike: ");
            fizika = Int32.Parse(Console.ReadLine());
            Console.Write("Unesite bodove iz kemije: ");
            kemija = Int32.Parse(Console.ReadLine());
            Console.Write("Unesite bodove iz matematike: ");
            matematika = Int32.Parse(Console.ReadLine());

            int ukupno = fizika + kemija + matematika;
            int matfiz = matematika + fizika;


            Console.Write("Kriteriji prihvatljivosti:\n");
            Console.Write("Bodovi iz matematike >=65\n");
            Console.Write("i bodovi iz fizike >=55\n");
            Console.Write("i bodovi iz kemije >=50\n");
            Console.Write("i ukupno za sva tri predmeta >= 180\n");
            Console.Write("ili ukupo iz matematke i fizike >=140\n");
            Console.Write("-------------------------------------------\n\n");


            Console.WriteLine($"Ukupno bodova imate: {ukupno}");
            Console.WriteLine("-------------------------------------------\n");

            if (matfiz >= 140)
            {
                Console.WriteLine("Dozvoljen upis na stručni studij.");
            }
            else if (ukupno >= 180 && kemija >= 50 && fizika >= 55 & matematika >= 65)
            {
                Console.WriteLine("Dozvoljen upis na stručni studij.");
            }
            else
            {
                Console.WriteLine("Nije dozvoljen upis.\n");
            }
            Console.WriteLine("-------------------------------------------\n");
            Console.WriteLine("Kriteriji koji nisu ispunjeni:\n");

            var uvjeti = new List<(bool, string)>
            {
                (matematika < 65, "Matematika nije zadovoljila kriterij"),
                (fizika < 55, "Fizika nije zadovoljila kriterij"),
                (kemija < 50, "Kemija nije zadovoljila kriterij"),
                (ukupno < 180, "Nemate ukupan zbroj bodova veći ili jednak 180"),
                (matfiz < 140, "Nemate zbroj bodova matematike i fizike veći ili jednak 140")
              };

            
            foreach (var (nijeIspunjeno, poruka) in uvjeti)
            {
                if (nijeIspunjeno)
                {
                    Console.WriteLine(poruka);
                }
            }

        }
    }
}
