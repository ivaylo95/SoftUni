using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_to__Centimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input inches: ");
            var inches = double.Parse(Console.ReadLine());
            var cantimeters = inches * 2.54;
            Console.Write("Centimeters = ");
            Console.Write(cantimeters);
            Console.ReadLine();

        }
    }
}
