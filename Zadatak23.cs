using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_net_frmwrk_h
{
    internal class Zadatak23
    {
        public static void zadatak23()
        {
            string userName, password;
            int brojac = 0;

            // user, abcd

            do
            {
                Console.WriteLine("Unesite korisničko ime: ");
                userName = Console.ReadLine();
                Console.WriteLine("Unesite lozinku: ");
                password = Console.ReadLine();               
                if (userName == "user" && password == "abcd")
                {
                    Console.WriteLine("Uspješno ste logirani.");
                    break;
                }
                else
                {
                    brojac++;
                    Console.WriteLine("Neuspješnja prijava");
                    if (brojac == 3)
                    {
                        Console.WriteLine("Maksimalni broj netočnih pokušaja");
                    }
                
                    
                }
            } while (brojac < 3);
            

        }
    }
}
