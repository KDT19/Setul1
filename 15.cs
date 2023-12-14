using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 15. Se dau 3 numere. Sa se afiseze in ordine crescatoare. 

            Console.Write("Introduceti primul numar: ");
            int nr1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            int nr2 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al treilea numar: ");
            int nr3 = int.Parse(Console.ReadLine());

            int min, mij, max;

            if (nr1 < nr2 && nr1 < nr3)
            {
                min = nr1;
                if (nr2 < nr3)
                {
                    mij = nr2;
                    max = nr3;
                }
                else
                {
                    mij = nr3;
                    max = nr2;
                }
            }
            else if (nr2 < nr1 && nr2 < nr3)
            {
                min = nr2;
                if (nr1 < nr3)
                {
                    mij = nr1;
                    max = nr3;
                }
                else
                {
                    mij = nr3;
                    max = nr1;
                }
            }
            else
            {
                min = nr3;
                if (nr1 < nr2)
                {
                    mij = nr1;
                    max = nr2;
                }
                else
                {
                    mij = nr2;
                    max = nr1;
                }
            }

            Console.WriteLine("Numerele in ordine crescatoare sunt: " + min + ", " + mij + ", " + max);
        }
    }
}