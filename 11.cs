using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 11. Afisati in ordine inversa cifrele unui numar n. 

            Console.Write("Introduceti un numar intreg: ");
            if (int.TryParse(Console.ReadLine(), out int nr))
            {
                Console.Write("Cifrele in ordine inversa sunt: ");
                while (nr > 0)
                {
                    int cif = nr % 10;
                    Console.Write(cif + " ");
                    nr /= 10;
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Introducerea nu este valida. Va rugam sa introduceti un numar intreg.");
            }
        }
    }
}
