using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 9. Afisati toti divizorii numarului n. 
            Console.Write("Introduceti un număr n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Divizorii numărului {n} sunt:");

            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
