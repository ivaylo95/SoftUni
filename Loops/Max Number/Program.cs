using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = int.Parse(Console.ReadLine());
            var max = num;
            for (int i = 0; i < n-1; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                if (num1 > max)
                {
                    max = num1;
                }
            }
            Console.WriteLine(max);
            
            Console.ReadLine();
        }
    }
}
