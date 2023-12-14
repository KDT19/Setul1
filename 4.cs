using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4. Detreminati daca un an y este an bisect. 
            Console.WriteLine("Introduceti un an: ");
            int y = int.Parse(Console.ReadLine());
            if(y%4!=0)
                Console.WriteLine($"Anul {y} nu este bisect");
            else
            {
                if(y%100==0)
                {
                    if(y%400!=0)
                        Console.WriteLine($"Anul {y} nu este bisect");
                    else
                        Console.WriteLine($"Anul {y} este bisect");
                }
                else
                    Console.WriteLine($"Anul {y} este bisect");
            }
        }
    }
}
