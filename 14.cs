using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 14. Determianti daca un numar n este palindrom.

            Console.Write("Introduceti numarul n: ");
            int n = int.Parse(Console.ReadLine());
            int pal = 0, aux;
            aux = n;
            
            while(aux > 0)
            {
                int cif = aux % 10;
                aux /= 10;
                pal = pal * 10 + cif;

            }

            if (pal == n)
                Console.WriteLine("Numarul n este palindrom");
            else
                Console.WriteLine("Numarul n nu este palindrom");


        }
    }
}
