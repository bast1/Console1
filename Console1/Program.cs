using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Summe zweier Zahlen.
            Console.WriteLine("Hallo Welt");
            int summand1 = 5;
            int summand2 = 9;
            int summe = summand1 + summand2;

            Console.WriteLine("Die Summe aus " + summand1 + " und " + summand2 + " ist " + summe + ".");

            //For-Schleife einfach
            for(int zaehler = 0; zaehler < 10; zaehler = zaehler + 1)
            {
                Console.WriteLine(zaehler + ". Hallo Welt");
            }

            //For-Schleife
            summe = 0;
            for (int i = 1; i <= 10; i++)
            {
                summe += i;
                Console.WriteLine("Aktuelle Zahl: " + summe);
            }
            Console.WriteLine("Die Summe lautet " + summe);

            int addiere(int summanden1, int summanden2)
            {
                return summanden1 + summanden2;
            }

            int summeFunc = addiere(10, 19);

            Console.WriteLine("summeFunc = " + summeFunc); 



        }
    }
}
