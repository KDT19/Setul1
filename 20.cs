using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace s1ex20
{
    internal class Program
    {

        // 20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). 
        // O fractie este neperiodica daca numitorul este de forma 2^m*5^n unde m si n sunt mai mari sau egale decat 0
        // O fractie este periodica simpla daca numitorul nu se divide cu 2 si nici cu 5. 
        // O fractie este periodica mixta daca se divide cu 2 si/sau 5 SI se mai divide si cu alte numere prime diferite de 2 si 5. 
        static void Main(string[] args)
        {
            Console.Write("Introduceti numaratorul (m): ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("Introduceti numitorul (n): ");
            int n = int.Parse(Console.ReadLine());

            string result = ConvertToDecimalFraction(m, n);
            Console.WriteLine($"{m}/{n} = {result}");
        }

        static string ConvertToDecimalFraction(int numarator, int numitor)
        {
            if (numitor == 0)
            {
                return "Divizare la zero!";
            }

            // Verificam tipul de fractie
            if (IsNonRecurringFraction(numitor))
            {
                return ((double)numarator / numitor).ToString();
            }
            else if (IsSimpleRecurringFraction(numitor))
            {
                return ConvertSimpleRecurringFraction(numarator, numitor);
            }
            else
            {
                return ConvertMixedRecurringFraction(numarator, numitor);
            }
        }

        static bool IsNonRecurringFraction(int denominator)
        {
            // Verificam daca numitorul este de forma 2^m * 5^n
            while (denominator % 2 == 0)
            {
                denominator /= 2;
            }
            while (denominator % 5 == 0)
            {
                denominator /= 5;
            }
            return denominator == 1;
        }

        static bool IsSimpleRecurringFraction(int denominator)
        {
            // Verificam daca numitorul nu se divide cu 2 si nici cu 5
            return denominator % 2 != 0 && denominator % 5 != 0;
        }

        static string ConvertSimpleRecurringFraction(int numerator, int denominator)
        {
            StringBuilder result = new StringBuilder();
            result.Append((numerator / denominator).ToString()); // Partea intreaga

            int remainder = numerator % denominator;
            result.Append(".");
            Dictionary<int, int> remainderMap = new Dictionary<int, int>();

            while (remainder != 0)
            {
                if (remainderMap.ContainsKey(remainder))
                {
                    int recurringStartIndex = remainderMap[remainder];
                    string recurringPart = result.ToString(recurringStartIndex, result.Length - recurringStartIndex);
                    result.Insert(recurringStartIndex, "(");
                    result.Append(")");
                    break;
                }

                remainderMap[remainder] = result.Length;
                remainder *= 10;
                result.Append((remainder / denominator).ToString());
                remainder %= denominator;
            }

            return result.ToString();
        }

        static string ConvertMixedRecurringFraction(int numerator, int denominator)
        {
            int integerPart = numerator / denominator;
            numerator %= denominator;

            List<int> quotientDigits = new List<int>();
            Dictionary<int, int> remainders = new Dictionary<int, int>();

            StringBuilder result = new StringBuilder(integerPart.ToString() + ".");

            int position = 0;
            int recurringStartIndex = -1;

            while (numerator != 0)
            {
                if (remainders.ContainsKey(numerator))
                {
                    recurringStartIndex = remainders[numerator];
                    break;
                }

                remainders[numerator] = position;
                numerator *= 10;
                quotientDigits.Add(numerator / denominator);
                numerator %= denominator;
                position++;
            }

            for (int i = 0; i < position; i++)
            {
                if (i == recurringStartIndex)
                    result.Append("(");
                result.Append(quotientDigits[i]);
            }

            if (recurringStartIndex >= 0)
                result.Append(")");

            return result.ToString();
        }
    }
}

