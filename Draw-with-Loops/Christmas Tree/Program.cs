using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            n += 1;
            for (int i = 0 ; i < n; i++)
            {
                string spaces = new string (' ', n-i-1);
                string star = new string('*', i);
                string draw = new string('|', 1);
                string space = new string(' ', 1);

                Console.Write(spaces);
                Console.Write(star);
                Console.Write(space);
                Console.Write(draw);
                Console.Write(space);
                Console.Write(star);
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}
