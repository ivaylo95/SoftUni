using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input metric: ");
            var metric = double.Parse(Console.ReadLine());
            Console.Write("Unit from: ");
            var unitFrom = Console.ReadLine();
            Console.Write("Unit to: ");
            var unitTo = Console.ReadLine();

            var units = new Dictionary <string, double>
            {
                {"m",1},
                {"mm",1000},
                {"cm",100},
                {"mi",0.000621371192},
                {"in",39.3700787},
                {"km",0.001 },
                {"ft",3.2808399},
                {"yd",1.0936133}
            };
            var result = metric / units[unitFrom] * units[unitTo];
            Console.WriteLine("{0} {1}",result, unitTo);
            Console.ReadLine();
        }
    }
}
