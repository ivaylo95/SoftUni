using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var projection = Console.ReadLine().ToLower();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());
            double price = -1;
            switch (projection)
            {
                case "premiere":
                    price = 12 * rows * columns;
                    Console.WriteLine("{0:F2}", price);
                    break;
                case "normal":
                    price = 7.50 * rows * columns;
                    Console.WriteLine("{0:F2}", price);
                    break;
                case "discount":
                    price = 5 * rows * columns;
                    Console.WriteLine("{0:F2} leva", price);
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            };
            Console.ReadLine();
        }
    }
}
