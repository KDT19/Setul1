using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

            Console.WriteLine("Bine ati venit la jocul de ghicit numarul!");
            Console.WriteLine("Alegeti un numar intre 1 si 1024.");
            Console.WriteLine("Eu voi incerca sa ghicesc numarul dvs. prin intrebari.");

            int min = 1;
            int max = 1024;
            int nr = (min + max) / 2;
            string response;

            do
            {
                Console.WriteLine($"Este numarul mai mare sau egal decat {nr}?");
                Console.Write("Raspundeti cu 'da' sau 'nu': ");
                response = Console.ReadLine().ToLower();

                if (response == "da")
                {
                    min = nr + 1;
                }
                else if (response == "nu")
                {
                    max = nr - 1;
                }
                else
                {
                    Console.WriteLine("Raspuns invalid. Va rog sa raspundeti cu 'da' sau 'nu'.");
                }

                nr = (min + max) / 2;
            } while (min <= max);

            Console.WriteLine($"Numarul ghicit este {nr}!");
        }
    }
}
