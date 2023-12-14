using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 18. Afisati descompunerea in factori primi ai unui numar n.
            // De ex. pentru n = 1176 afisati 2^3 x 3^1 x 7^2. 

            Console.WriteLine("Introduceti numarul pentru descompunerea în factori primi:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Descompunerea in factori primi ai lui {n} este: ");

            for (int d = 2; d <= n; d++)
            {
                int putere = 0;
                while (n % d == 0)
                {
                    n /= d;
                    putere++;
                }

                if (putere > 0) // deoarece la puterea 0 orice numar ar fi luat in descompunere, ceea ce nu este corect
                {
                    Console.Write($"{d}^{putere}");
                    if (n > 1)
                    {
                        Console.Write(" x ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
