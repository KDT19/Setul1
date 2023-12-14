using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex17
{
    internal class Program
    {
        // 17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.
        // Folositi algoritmul lui Euclid.

        // Functie pentru a calcula CMMDC
        static int CMMDC(int n1, int n2)
        {
            while (n2 != 0)
            {
                int temp = n2;
                n2 = n1 % n2;
                n1 = temp;
            }
            return n1;
        }

        // Functie pentru a calcula CMMMC
        static int CMMMC(int n1, int n2)
        {
            return (n1 * n2) / CMMDC(n1, n2);
        }


        static void Main(string[] args)
        {
            // 17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.
            // Folositi algoritmul lui Euclid. 

            Console.WriteLine("Introduceti cele doua numere pentru calculul CMMDC si CMMMC:");
            int nr1 = Convert.ToInt32(Console.ReadLine());
            int nr2 = Convert.ToInt32(Console.ReadLine());

            int cmmdc = CMMDC(nr1, nr2);
            int cmmmc = CMMMC(nr1, nr2);

            Console.WriteLine($"Cel mai mare divizor comun (CMMDC) al celor doua numere este: {cmmdc}");
            Console.WriteLine($"Cel mai mic multiplu comun (CMMMC) al celor doua numere este: {cmmmc}");


        }
    }
}
