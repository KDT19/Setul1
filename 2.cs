using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Rezolvati ecuatia de gradul 2 cu o necunoscuta:
            // ax^2 + bx + c = 0, unde a, b si c sunt date de intrare.
            // Tratati toate cazurile posibile. 

            Console.WriteLine("Introduceti valoarea lui a:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduceti valoarea lui b:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Introduceti valoarea lui c:");
            double c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
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
                    double x = -c / b;
                    Console.WriteLine("Ecuatia este de gradul 1 si are o solutie reala: x = " + x);
                }
            }
            else if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Ecuatia are doua solutii reale distincte: x1 = " + x1 + " si x2 = " + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine("Ecuatia are o solutie reala dubla: x = " + x);
            }
            else
            {
                double partereala = -b / (2 * a);
                double parteimaginara = Math.Sqrt(-delta) / (2 * a);
                Console.WriteLine("Ecuatia are doua solutii complexe conjugate: x1 = " + partereala + " + " + parteimaginara + "i si x2 = " + partereala + " - " + parteimaginara + "i");
            }
        }
    }
}
