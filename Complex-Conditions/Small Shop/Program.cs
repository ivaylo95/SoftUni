using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("product: ");
            var product = Console.ReadLine();
            Console.Write("city: ");
            var city = Console.ReadLine();
            Console.Write("count: ");
            var count = double.Parse(Console.ReadLine());
            double result = 0;

            var SofiaStore = new Dictionary<string, double>
            {
                {"coffee", 0.5},
                {"water", 0.8},
                {"beer", 1.2},
                {"sweets", 1.45},
                {"peanuts", 1.6}
            };

            var PlovdivStore = new Dictionary<string, double>
            {
                {"coffee", 0.4},
                {"water", 0.7},
                {"beer", 1.15},
                {"sweets", 1.3},
                {"peanuts", 1.5}
            };

            var VarnaStore = new Dictionary<string, double>
            {
                {"coffee", 0.45},
                {"water", 0.7},
                {"beer", 1.1},
                {"sweets", 1.35},
                {"peanuts", 1.55}
            };

            var stores = new Dictionary<string, Dictionary<string, double>>
            {
                {"Sofia", SofiaStore},
                {"Plovdiv", PlovdivStore},
                {"Varna", VarnaStore}
            };

                result = (stores[city])[product] * count;
                Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
