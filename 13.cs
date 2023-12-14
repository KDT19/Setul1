using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 13. Determianti cati ani bisecti sunt intre anii y1 si y2.

            Console.Write("Introduceti primul an (y1): ");
            int y1 = int.Parse(Console.ReadLine());

            Console.Write("Introduceti al doilea an (y2): ");
            int y2 = int.Parse(Console.ReadLine());

            int anibis = 0;

            for (int i = y1; i <= y2; i++)
            {
                if (Bisect(i))
                {
                    anibis++;
                }
            }

            Console.WriteLine($"Intre anii {y1} si {y2} sunt {anibis} ani bisecti.");


        }
        static bool Bisect(int x)
        {
            if ((x % 4 == 0 && x % 100 != 0) || (x % 400 == 0))
            {
                return true;
            }
            return false;
        }
    }
}
