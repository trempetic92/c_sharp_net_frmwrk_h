using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak20
    {
        public static void zadatak20()
        {

            //Console.WriteLine("Za kraj unesite kraj");
            //while (true)
            //{
            //    Console.WriteLine("Unesite Ime: ");
            //    string ime = Console.ReadLine();

            //    if (ime == "kraj")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(ime);
            //}

            //string novoIme = "";
            //while (novoIme != "kraj")
            //{
            //    Console.WriteLine("Unesite Ime: ");
            //    novoIme = Console.ReadLine();

            //    if (novoIme == "kraj")
            //    {
            //        break;
            //    }
            //    Console.WriteLine(novoIme);
            //}

            Console.WriteLine("Unesite rečenicu: ");
            string recenica = Console.ReadLine();

            int slova, znamenke, specZnakovi, i;

            slova = znamenke = specZnakovi = i = 0;

            while (i < recenica.Length)
            {
                if (char.IsLetter(recenica[i]))
                {
                    slova++;
                }
                else if (char.IsNumber(recenica[i]))
                {
                    znamenke++;
                }
                else
                {
                    specZnakovi++;
                }
                i++;
            }

            Console.WriteLine($"Broj slova = {slova}");
            Console.WriteLine($"Broj znamenki = {znamenke}");
            Console.WriteLine($"Broj specijalnih znakova = {specZnakovi}");
            Console.WriteLine($"Ukupan broj znakova = {recenica.Length}");


        }
    }
}
