using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak18
    {
        public static void arryListe()
        {
            ArrayList listaBrojeva = new ArrayList();

            var listaBrojeva2 = new ArrayList();

            listaBrojeva.Add(10);
            listaBrojeva.Add(23);
            listaBrojeva.Add(25.5);
            listaBrojeva.Add(3.45F);

            Console.WriteLine(listaBrojeva[1]);
            Console.WriteLine(listaBrojeva[3]);
            Console.WriteLine(listaBrojeva[2]);
            Console.WriteLine(listaBrojeva[0]);

            int[] nizInt = { 1, 6, 7, 4 };

            var listaRaznih = new ArrayList
            {
                23,
                listaBrojeva[0],
                "Nesto",
                true,
                null,
                "Luka",
                3,
                nizInt

            };

            Console.WriteLine(listaRaznih.Count);

            Console.WriteLine(listaRaznih[0]);
            Console.WriteLine(listaRaznih[1]);
            Console.WriteLine(listaRaznih[2]);
            Console.WriteLine(listaRaznih[3]);
            Console.WriteLine(listaRaznih[4]);



            Console.WriteLine(listaRaznih.Count);



            int suma = 0;
            suma = (int)listaRaznih[0] + (int)listaRaznih[1] + (int)listaRaznih[6];

            Console.WriteLine(suma);

            string broj = "25";
            List<int> brojevi = new List<int>();
            brojevi.Add(1);
            brojevi.Add(435);
            brojevi.Add(Int32.Parse(broj));

            List<string> nekiStringovi = new List<string>();

            List<int> brojevi2 = new List<int>() { 1, 4, 9 };

            for (int i = 0; i < brojevi.Count; i++)
            {
                Console.WriteLine(brojevi[i]);
            }

        }
    }
}
