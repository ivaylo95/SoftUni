using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Input b: ");
            var b = int.Parse(Console.ReadLine());
            if (a > b)
                Console.WriteLine(a);
            else
                Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
