using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak6
    {
        public static void VarijablaZamjena()
        {
            int a = 5;
            int b = 4;

            


            Console.WriteLine($"a = {a}, b = {b}");

            (a, b) = (b, a);


            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
