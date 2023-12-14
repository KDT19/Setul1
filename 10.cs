using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex10
{
    internal class Program
    {
        // 10. Test de primalitate: determinati daca un numar n este prim.
        static bool Prim(uint n)
        {
            if (n <= 1)
            {
                return false;
            }

            if (n <= 3)
            {
                return true;
            }

            if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }

            for (int i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar intreg pozitiv: ");
            if (uint.TryParse(Console.ReadLine(), out uint nr))
            {
                if (Prim(nr))
                {
                    Console.WriteLine($"{nr} este un numar prim.");
                }
                else
                {
                    Console.WriteLine($"{nr} nu este un numar prim.");
                }
            }
            else
            {
                Console.WriteLine("Introducerea nu este valida. Va rugam sa introduceti un numar intreg pozitiv.");
            }
        }
    }
}

