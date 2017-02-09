using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var sum = 0;
            var previosSum = 0;
            var diff = 0;
            for (int i = 0; i < n; i++)
            {
                previosSum = sum;
                var a = int.Parse(Console.ReadLine());
                var b = int.Parse(Console.ReadLine());
                sum = a + b;
                if (n==1)
                {
                    previosSum = sum;
                }
                diff = Math.Abs(sum - previosSum);
            }
            if (diff == 0)
            {
                Console.WriteLine("Yes, value={0}", sum);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}", diff);
            }
            Console.ReadLine();

        }
    }
}
