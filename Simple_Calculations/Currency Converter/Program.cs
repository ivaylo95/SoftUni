using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input sum: ");
            var sum = double.Parse(Console.ReadLine());
            Console.Write("Input currency from: ");
            string currencyFrom = Console.ReadLine();
            Console.Write("Input currency to: ");
            string currencyTo = Console.ReadLine();

            var currencies = new Dictionary<string, double>()
            {
                {"BGN",1}, 
                {"USD",1.79549}, 
                {"EUR",1.95583}, 
                {"GBP",2.53405}
            };

            var result = sum * currencies[currencyFrom] / currencies[currencyTo];
            Console.WriteLine("{0} {1}", Math.Round(result, 2), currencyTo);
            Console.ReadLine();

        }
    }
}
