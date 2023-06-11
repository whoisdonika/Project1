using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number up to 6 digits : ");
            string stringNum = Console.ReadLine();

            if (stringNum.Length > 6)
            {
                Console.WriteLine("The number can only have 6 or less digits!");
                return;
            }


            if (!int.TryParse(stringNum, out int number))
            {
                Console.WriteLine("Invalid type for the number!");
                return;
            }

            int sumEven = 0;
            int countOdd = 0;
            

            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0)
                {
                  sumEven += digit;
                }
                else
                {
                  countOdd++;
                }

                number /= 10;
            }
            

            Console.WriteLine(sumEven);
            Console.WriteLine(countOdd);
        }
    }
}
