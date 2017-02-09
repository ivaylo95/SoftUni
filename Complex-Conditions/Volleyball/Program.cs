using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var p = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            double games = -1;
            if (year == "leap")
            {
                games = (48 - h) * 3.0 / 4 + h + (p * 2.0 / 3);
                games += games * 0.15;
                Console.WriteLine(Math.Truncate(games));
            }
            else if (year == "normal")
            {
                games = (48 - h) * 3.0/4 + h + (p* 2.0/3);
                Console.WriteLine(Math.Truncate(games));
            }
            else
            {
                Console.WriteLine("error");
            }
            Console.ReadLine();
        }
    }
}
