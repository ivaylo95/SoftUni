using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            var a = int.Parse(Console.ReadLine());
            var SquareArea = a * a;
            Console.Write("Square area = ");
            Console.WriteLine(SquareArea);
            Console.ReadLine();
        }
    }
}
