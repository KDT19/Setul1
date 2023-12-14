using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 

            Console.Write("Introduceti lungimea laturii a: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Introduceti lungimea laturii b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Introduceti lungimea laturii c: ");
            double c = double.Parse(Console.ReadLine());

            if (triunghi(a, b, c))
            {
                Console.WriteLine("Cele trei lungimi pot forma un triunghi.");
            }
            else
            {
                Console.WriteLine("Cele trei lungimi nu pot forma un triunghi.");
            }
        }

        static bool triunghi(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (a + b > c && a + c > b && b + c > a)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
