using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_100._._._200
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number: ");
            var number = int.Parse(Console.ReadLine());
            if (number < 100)
            {
                Console.Write("Less than 100");
            }
            else if(number>=100 && number<=200)
            {
                Console.Write("Between 100 and 200");
            }
            else
            {
                Console.Write("Greater than 200");
            }
            Console.ReadLine();
        }
    }
}
