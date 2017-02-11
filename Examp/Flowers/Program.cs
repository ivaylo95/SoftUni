using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemum = int.Parse(Console.ReadLine());
            int rose = int.Parse(Console.ReadLine());
            int tulip = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string yesOrNo = Console.ReadLine();
            double chrysanthemumPrice = 0;
            double rosePrice = 0;
            double tulipPrice = 0;
            double price = 0;
            int count = chrysanthemum + rose + tulip;
            double totalPrice = 0;

            if(season == "Summer" ||season == "Spring")
            {
                chrysanthemumPrice = 2.00;
                rosePrice = 4.10;
                tulipPrice = 2.50;
            }
            else
            {
                chrysanthemumPrice = 3.75;
                rosePrice = 4.50;
                tulipPrice = 4.15;
            }

            price = chrysanthemum * chrysanthemumPrice + rose * rosePrice + tulip * tulipPrice;
            if (yesOrNo == "Y")
            {
                price += price * 0.15;
            }
            if (tulip > 7 && season == "Spring")
            {
                price -= price * 0.05;
            }
            if (rose >= 10 && season == "Winter")
            {
                price -= price * 0.1;
            }
            if (count > 20)
            {
                price -= price * 0.2;
            }
            totalPrice = price + 2;
            
            Console.WriteLine("{0:f2}",Math.Round(totalPrice,2));
            Console.ReadLine();
        }
    }
}
