using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inicijalni6_4D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Napišite program koji će izračunati sumu reda:
        1/3 + 1/9 + 1/27 + . . .
        Korisnik treba unijeti broj članova reda.
        */
            Console.WriteLine("Unesi broj članova reda: ");
            int a = Convert.ToInt32(Console.ReadLine());
            int n = 1;
            double suma = 0;
            for(int i = 1; i <= a; i++)
            {
                int nazivnik = n * 3;
                double broj = 1 / nazivnik;
                suma = suma + broj;
                n= nazivnik;
            }
            Console.WriteLine(suma);
            Console.ReadLine(); 
        }
    }
}
