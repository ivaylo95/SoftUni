using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_0._._._100_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if (n < 0 || n > 100)
            {
                Console.WriteLine("invalid number"); 
            }
            else if (n == 100)
            {
                Console.WriteLine("one hundred");
            }
            else
            {
                string[] ones = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                string[] tens = { "", "", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
                int firstDigit = n / 10;
                int secondDigit = n % 10;
                if (n < 20)
                {
                    Console.WriteLine("{0}", ones[n]);
                }
                else if (n % 10 == 0)
                {
                    Console.WriteLine("{0}", tens[firstDigit]);

                }
                else
                {
                    Console.WriteLine("{0} {1}", tens[firstDigit], ones[secondDigit]);
                }

            }
            Console.ReadLine();
        }
    }
}
