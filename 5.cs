using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar.
            // Cifrele se numara de la dreapta la stanga. 

            Console.Write("Introduceti un numar: ");
            string nr = Console.ReadLine();

            Console.Write("Introduceti valoarea pentru k: ");
            int k = int.Parse(Console.ReadLine());

            if (k < 1 || k > nr.Length)
            {
                Console.WriteLine("Valoarea lui k trebuie sa fie intre 1 si lungimea numarului.");
            }
            else
            {
                char cifra = nr[nr.Length - k];
                Console.WriteLine($"A {k}-a cifra de la sfarsitul numarului este: {cifra}");
            }
        }
    }
}
