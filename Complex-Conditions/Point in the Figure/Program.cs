using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            int x1 = 0;
            int y1 = 0;
            int x2 = 3 * h;
            int y2 = h;

            int a1 = h;
            int b1 = h + 3 * h;
            int a2 = h + h;
            int b2 = h;

            bool isMiddle = (((x == h) && (y > 0 && y < h)) || ((x == 2 * h) && (y > 0 && y < h)) || ((x > h && x < 2 * h) && (y == h)));
           

            if ((x < x1 || x > x2 || y < y1 || y > y2) && (x < a1 || x > a2 || y > b1 || y < b2))
            {
                Console.WriteLine("outside");
            }
            else if ((x >= x1 || x <= x2 || y >= y1 || y <= y2) && (x >= a1 || x <= a2 || y <= b1 || y >= b2))
            {
                if ((x == x1 || x == x2 || y == y1 || y == y2) || (x == a1 || x == a2 || y == b1 || y == b2))
                {
                    if (!isMiddle)
                    {
                        Console.WriteLine("border");
                    }
                    else
                    {
                        Console.WriteLine("inside");
                    }
                }
                else
                {
                    Console.WriteLine("inside");
                }
            }

            Console.ReadLine();
        }
    }
}