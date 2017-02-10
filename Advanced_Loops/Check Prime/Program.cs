using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            if (digit<2)
                Console.WriteLine("Not Prime");
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(digit); i++)
            {
                if (digit % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if(isPrime==false)
                Console.WriteLine("Not Prime");
            else
                Console.WriteLine("Prime");
            Console.ReadLine();

        }
    }
}
