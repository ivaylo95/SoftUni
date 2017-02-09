using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Comissions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("City: ");
            var city = Console.ReadLine().ToLower();
            Console.Write("Sales: ");
            var sales = double.Parse(Console.ReadLine());
            double comission = -1;

            
            if (city == "sofia")
            {
                if (sales < 0) Console.WriteLine("error");
                else if (sales >= 0 && sales <= 500) comission = 0.05;
                else if (sales > 500 && sales <= 1000) comission = 0.07;
                else if (sales > 1000 && sales <= 10000) comission = 0.08;
                else comission = 0.12;
            }
            else if (city == "varna")
            {
                if (sales < 0) Console.WriteLine("error");
                else if (sales >= 0 && sales <= 500) comission = 0.045;
                else if (sales > 500 && sales <= 1000) comission = 0.075;
                else if (sales > 1000 && sales <= 10000) comission = 0.10;
                else comission = 0.13;
            }
            else if (city == "plovdiv")
            {
                if (sales < 0) Console.WriteLine("error");
                else if (sales >= 0 && sales <= 500) comission = 0.055;
                else if (sales > 500 && sales <= 1000) comission = 0.08;
                else if (sales > 1000 && sales <= 10000) comission = 0.12;
                else comission = 0.145;
            }
            else Console.WriteLine("error");

            if(comission>0)
            Console.WriteLine(Math.Round(comission* sales,2));

            Console.ReadLine();
        }
    }
}
