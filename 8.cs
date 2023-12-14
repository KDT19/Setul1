using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
            // Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.  

            Console.Write("Introduceti valoarea lui a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti valoarea lui b: ");
            int b = int.Parse(Console.ReadLine());

            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine("Valorile inverse sunt:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);


        }
    }
}
