using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n + 1; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
            Console.ReadLine();
        }
    }
}
