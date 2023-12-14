using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta.
            // De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.

            // pt. mine ---> trebuie sa se repete o cifra de cel putin 4 ori si
            //               sa nu fie mai mult de 2 cifre care se repeta de 2 ori
            //               sau 2 cifre care sa se repete de cel putin 2 ori

            Console.WriteLine("Introduceti numarul:");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            int aux = n;

            int[] v = {0,0,0,0,0,0,0,0,0,0 };

            while (aux > 0)
            {
                int cif = aux % 10;
                v[cif]++; // in vector se memoreaza de cate ori apare fiecare cifra (de la 0 la 9) in numarul n
                aux = aux / 10;
            }

            int ok = 0, rep2 = 0, rep4 = 0; 
            for (int i = 0; i <= 9; i++)
            {
                if (v[i] >= 2)
                    rep2++; // verifica cate cifre se repeta de cel putin 2 ori
                if (v[i] >= 4)
                    rep4++; // verifica cate cifre se repeta de cel putin 4 ori
            }

            if (rep2 == 2 || (rep4 == 1 && rep2 <=2)) 
                ok = 1;

            // am verificat daca exista 2 cifre care se repeta de cel putin 2 ori sau
            // o cifra care sa se repete de cel putin 4 ori si sa nu fie mai mult de 2 cifre care
            // sa se repete de mai mult de 2 ori
            
            if (ok == 1)
                Console.WriteLine($"Numarul {n} este format doar cu 2 cifre care se pot repeta");
            else
                Console.WriteLine($"Numarul {n} nu este format doar cu 2 cifre care se pot repeta");

        }
    }
}
