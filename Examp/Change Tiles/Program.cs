using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Tiles
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var length = double.Parse(Console.ReadLine());
            var a = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());
            var tilePrice = double.Parse(Console.ReadLine());
            var masterPrice = double.Parse(Console.ReadLine());

            double VFloor = width * length;
            double VTile = a * h / 2;
            double needTiles = Math.Ceiling(VFloor / VTile) + 5;
            double total = needTiles * tilePrice + masterPrice;
            if (total > money)
            {
                Console.WriteLine("You'll need {0:f2} lv more.", total - money);
            }
            else
            {
                Console.WriteLine("{0:f2} lv left.", money - total);
            }
            Console.ReadLine();
        }
    }
}
