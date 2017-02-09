using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Min_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = int.Parse(Console.ReadLine());
            var min = num;
            for (int i = 0; i < n - 1; i++)
            {
                var num1 = int.Parse(Console.ReadLine());
                if (num1 < min)
                {
                    min = num1;
                }

            }
            Console.WriteLine(min);
            Console.ReadLine(); 
        }
    }
}
