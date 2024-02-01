using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak16
    {
        public static void tekstualni_tipovi()
        {
            string recenica = "Danas je lijep i sunčan dan!";
            Console.WriteLine(recenica);

            string abeceda = "ABCČĆDDŽĐEFGHIJKLLJMNNJOPQRSŠTUVZŽ";
            Console.WriteLine("Dužina teksta varijable abeceda je " + abeceda.Length);

            string urediSlova = "Bok, jesi li za sok?";

            Console.WriteLine(urediSlova.ToLower());
            Console.WriteLine(urediSlova.ToUpper());

            string ime = "Luka";
            string prezime = "Trempetić";
            string imePrezime = ime + " " + prezime;
            Console.WriteLine(imePrezime);


            char slovo1 = 'C';
            char slovo2 = '#';

            Console.WriteLine("Učimo " + slovo1 + slovo2 + "!");
            Console.WriteLine("Učimo " + string.Concat(slovo1, slovo2) + "!");

            // specijalni znakovi

            string tekst_bez_greske = "To je zanimljivo, ali ja sam vidio \"čokoladu\" u hladnjaku";
            Console.WriteLine(tekst_bez_greske);

            string spec2 = "jesi l' dobro?";
            Console.WriteLine(spec2);

            string spec3 = "Specijalni znak \\";
            Console.WriteLine(spec3);

            string putanja = "C:\\Temp\\Upload\\file.txt";
            string putanja2 = @"C:\Temp\Upload\file.txt";
            string putanja3 = @"""C:\Temp\Upload\file.txt""";
            Console.WriteLine(putanja);
            Console.WriteLine(putanja2);
            Console.WriteLine(putanja3);

            int cijeli = 13;
            double decimalni = 13.2645;

            Console.WriteLine(cijeli + " " + decimalni.ToString("N2") + " ili " + decimalni);
            Console.WriteLine();

            string x = "22", y = "33";
            string zbroj = x + y;
            // int zbrojSaStringovima = x + y; Nemože!!!

            Console.WriteLine(zbroj);

            Console.WriteLine(Convert.ToInt32(x) + Convert.ToInt32(y));


            char i = '1';
            char j = '8';
            int zbroj_charova = i + j;
            Console.WriteLine(zbroj_charova);
            string test = "test";

            int pretvori_i = Convert.ToInt32(i);
            int pretvori_j = (int)Char.GetNumericValue(j);
            int novi_zbroj = pretvori_i + pretvori_j;
            Console.WriteLine("Točan zbroj s znakovima je: " + novi_zbroj);

            //dodatne metode kod stringova

            Console.WriteLine(recenica.Substring(6));
            Console.WriteLine(recenica.Substring(0, 5));
            Console.WriteLine(recenica.Substring(0, recenica.Length - 1));
            Console.WriteLine(recenica.Last());


            Console.WriteLine(recenica.IndexOf("a", 7));
            Console.WriteLine(recenica.LastIndexOf(" "));
            Console.WriteLine(recenica.Replace("Danas", "Sutra"));
            Console.WriteLine(recenica.Replace("je", "bude"));

            //split

            string[] rijeci = recenica.Split(' ');
            Console.WriteLine(rijeci[0]);
            Console.WriteLine(rijeci[5]);

            string ponavljanje = "Možda je možda je";

            string[] je = ponavljanje.Split(' ');

            bool promjenjeno = false;
            for (int g = 0; g < je.Length; g++)
            {
                if (je[g] == "je")
                {
                    while (!promjenjeno)
                    {
                        je[g] = "nije";
                        promjenjeno = true;
                    }
                }
            }

            ponavljanje = String.Join(" ", je);
            Console.WriteLine(ponavljanje);
           



            for (int h = 0; h < rijeci.Length; h++)
            {
                Console.WriteLine(rijeci[h]);
            }


            






        }
    }
}
