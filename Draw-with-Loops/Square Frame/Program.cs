using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string plus = new string('+',1);
                string minus = new string('-', 1);
                string draw = new string('|', 1);
                string spaces = new string(' ',1);
                if (i == 1 || i == n)
                {
                    Console.Write(plus);
                    for (int j = 1; j <= n-2; j++)
                    {
                        Console.Write(spaces);
                        Console.Write(minus);
                        
                    }
                    Console.Write(spaces);
                    Console.Write(plus);
                }
                else
                {
                    Console.Write(draw);
                    for (int j = 1; j <= n - 2; j++)
                    {
                        Console.Write(spaces);
                        Console.Write(minus);
                        
                    }
                    Console.Write(spaces);
                    Console.Write(draw);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
