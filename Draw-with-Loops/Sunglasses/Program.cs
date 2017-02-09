using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        { 
            var n = int.Parse(Console.ReadLine());
            string stars = new string('*', 2*n);
            string star = new string('*', 1);
            string space = new string(' ', n);
            string downline = new string('/', 2*n-2);
            string line = new string('|', n);
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    Console.Write(stars);
                    Console.Write(space);
                    Console.Write(stars);
                }
                else
                {
                    if (i == (n-1)/2+1)
                    {
                        Console.Write(star);
                        Console.Write(downline);
                        Console.Write(star);
                        Console.Write(line);
                        Console.Write(star);
                        Console.Write(downline);
                        Console.Write(star);
                    }
                    else
                    {
                        Console.Write(star);
                        Console.Write(downline);
                        Console.Write(star);
                        Console.Write(space);
                        Console.Write(star);
                        Console.Write(downline);
                        Console.Write(star);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
