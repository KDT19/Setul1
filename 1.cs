using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
            Console.WriteLine("Introduceti valoarea lui a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduceti valoarea lui b:");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Ecuatia are o infinitate de solutii.");
                }
                else
                {
                    Console.WriteLine("Ecuatia nu are solutii.");
                }
            }
            else
            {
                double x = -b / a;
                Console.WriteLine("Solutia ecuatiei este x = " + x);
            }

        }
    }
}
