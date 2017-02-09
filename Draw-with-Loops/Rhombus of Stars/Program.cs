using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                string spaces = new string(' ', n - i);
                string space = new string(' ', 1);
                string stars = new string('*', 1);
                Console.Write(spaces);
                for (int j = 1; j <= i ; j++)
                {
                    Console.Write(stars);
                    Console.Write(space);
                }
                Console.WriteLine();
            }
            for (int i = 1; i <= n - 1; i++)
            {
                string spaces = new string(' ', i);
                string space = new string(' ', 1);
                string stars = new string('*', 1);
                Console.Write(spaces);
                for (int j = n-1; j >= i; j--)
                {
                    Console.Write(stars);
                    Console.Write(space);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
