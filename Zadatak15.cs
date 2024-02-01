using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak15
    {
        public enum GodisnjaDoba
        {
            Proljece,
            Ljeto,
            Jesen,
            Zima
        }

        public static void enumeratorStringa()
        {

            GodisnjaDoba doba = GodisnjaDoba.Jesen;
            Console.WriteLine($"Integralna vrijednost {doba} je {(int)doba}");

            var b = (GodisnjaDoba)1;
            Console.WriteLine(b);

            var c = (GodisnjaDoba)4;
            Console.WriteLine(c);

            switch (c)
            {
                case GodisnjaDoba.Proljece:
                    break;
                case GodisnjaDoba.Ljeto:
                    break;
                case GodisnjaDoba.Jesen:
                    break;
                case GodisnjaDoba.Zima:
                    break;
                default:
                    break;
            }

        }
    }
}
