﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1: ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("y1: ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("x2: ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("y2: ");
            var y2 = double.Parse(Console.ReadLine());
            var a = Math.Abs(x1 - x2);
            var b = Math.Abs(y1 - y2);
            var area = a * b;
            var perimeter = 2 * (a + b);
            Console.WriteLine("Rectangle area is: {0}", area);
            Console.WriteLine("Rectangle perimetr is: {0}", perimeter);
            Console.ReadLine();
        }
    }
}
