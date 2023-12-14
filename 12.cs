using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 

            Console.WriteLine("Introduceti numarul n:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti intervalul [a, b]:");
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());

            int nr = 0; 
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                {
                    nr++;
                }
            }

            Console.WriteLine($"In intervalul [{a}, {b}] exista {nr} numere intregi divizibile cu {n}.");


        }
    }
}
