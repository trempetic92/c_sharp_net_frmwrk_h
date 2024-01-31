using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadaca4
    {
        public static void zadaca4()
        {
            //Unijeti 2 broja (int) te znak za računsku operaciju(+ , - , *, / , %)
            //Ispisati rezultat rač.operacije
            int a, b;
            char znak;

            Console.Write("Unesite prvi broj: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Unesite drugi broj: ");
            b = Int32.Parse(Console.ReadLine());

            Console.Write("Unesite računski znak: ");
            znak = Convert.ToChar(Console.ReadLine());

            
            
                switch (znak)
                {
                    case '+':
                        Console.WriteLine($"Riješenje je: {a + b}");
                        break;
                    case '-':
                        Console.WriteLine($"Riješenje je: {a - b}");
                        break;
                    case '*':
                        Console.WriteLine($"Riješenje je: {a * b}");
                        break;
                    case '/':
                        Console.WriteLine($"Riješenje je: {a / b}");
                        break;
                    case '%':
                        Console.WriteLine($"Riješenje je: {a % b}");
                        break;
                    default:
                        Console.WriteLine("\nUnesite valjani znak");                      
                        break;
                }
        }

    }
}


