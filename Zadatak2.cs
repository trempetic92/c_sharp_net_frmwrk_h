using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak2
    {
        public static void Varijable_uvod()
        {
            //Deklaracija varijabli
            string ime;
            int a;
            double decimalniBroj;
            bool isChecked;

            //Console.WriteLine(ime);
            //Console.WriteLine(a);
            //Console.WriteLine(decimalniBroj);
            //Console.WriteLine(isChecked);

            //Deklaracija i inicijalizacija varijable
            string punoIme = "Luka Trempetić";
            int godine = 31;
            a = 54;

            Console.WriteLine(punoIme);
            Console.WriteLine($"Godine su: {godine}");
            Console.WriteLine("{0} ima {1} godina", punoIme, godine);
            Console.WriteLine($"{punoIme} ima {godine} godina");
            Console.WriteLine(punoIme + " ima " + godine.ToString() + " godina");
            

        }
    }
}
