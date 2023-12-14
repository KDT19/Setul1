using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.
            // Se cere sa se inverseze valorile lor. 
            Console.Write("Introduceti valoarea lui a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Introduceti valoarea lui b: ");
            int b = int.Parse(Console.ReadLine());

 
            int aux = a;
            a = b;
            b = aux;

            Console.WriteLine("Valorile inverse sunt:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);


        }
    }
}
