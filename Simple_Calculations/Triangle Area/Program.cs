using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a: ");
            var a = double.Parse(Console.ReadLine());
            Console.Write("Input h: ");
            var h = double.Parse(Console.ReadLine());
            var area = a * h / 2;
            Console.Write("Triangle area: {0}", Math.Round(area,2));
            Console.ReadLine();
        }
    }
}
