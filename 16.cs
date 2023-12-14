using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)

            int nr1, nr2, nr3, nr4, nr5;

            Console.Write("Introduceti primul numar: ");
            nr1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea numar: ");
            nr2 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al treilea numar: ");
            nr3 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al patrulea numar: ");
            nr4 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al cincilea numar: ");
            nr5 = int.Parse(Console.ReadLine());

            
            int temp;

            if (nr1 > nr2)
            {
                temp = nr1;
                nr1 = nr2;
                nr2 = temp;
            }
            if (nr1 > nr3)
            {
                temp = nr1;
                nr1 = nr3;
                nr3 = temp;
            }
            if (nr1 > nr4)
            {
                temp = nr1;
                nr1 = nr4;
                nr4 = temp;
            }
            if (nr1 > nr5)
            {
                temp = nr1;
                nr1 = nr5;
                nr5 = temp;
            }
            if (nr2 > nr3)
            {
                temp = nr2;
                nr2 = nr3;
                nr3 = temp;
            }
            if (nr2 > nr4)
            {
                temp = nr2;
                nr2 = nr4;
                nr4 = temp;
            }
            if (nr2 > nr5)
            {
                temp = nr2;
                nr2 = nr5;
                nr5 = temp;
            }
            if (nr3 > nr4)
            {
                temp = nr3;
                nr3 = nr4;
                nr4 = temp;
            }
            if (nr3 > nr5)
            {
                temp = nr3;
                nr3 = nr5;
                nr5 = temp;
            }
            if (nr4 > nr5)
            {
                temp = nr4;
                nr4 = nr5;
                nr5 = temp;
            }

            // Afișați numerele sortate
            Console.WriteLine("Numerele sortate in ordine crescatoare:");
            Console.WriteLine(nr1);
            Console.WriteLine(nr2);
            Console.WriteLine(nr3);
            Console.WriteLine(nr4);
            Console.WriteLine(nr5);

        }
        
    }
}
