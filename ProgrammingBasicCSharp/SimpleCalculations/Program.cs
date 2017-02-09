using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Area_and_Perimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input radius: ");
            var r = double.Parse(Console.ReadLine());
            var CirclePerimeter = 2 * Math.PI * r;
            var CircleArea = Math.PI * r * r;
            Console.WriteLine("Circle perimeter is: {0} and circle area is: {1}",CirclePerimeter,CircleArea);
            Console.ReadLine();
        }
    }
}
