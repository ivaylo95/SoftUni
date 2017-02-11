 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var speed = double.Parse(Console.ReadLine());
            if (speed < 1 || speed > 300)
            {
                Console.WriteLine("Error");
                return;
            }
            var time1 = double.Parse(Console.ReadLine());
            if (time1 < 1 || time1 > 1000)
            {
                Console.WriteLine("Error");
                return;
            }

            var time2 = double.Parse(Console.ReadLine());
            if (time2 < 1 || time2 > 1000)
            {
                Console.WriteLine("Error");
                return;
            }
            var time3 = double.Parse(Console.ReadLine());

            if (time3 < 1 || time3 > 1000)
            {
                Console.WriteLine("Error");
                return;
            }
            time1 = time1 / 60;
            time2 = time2 / 60;
            time3 = time3 / 60;
            double finalTime = 0;

            finalTime = speed * time1;
            speed += speed * 0.1;
            finalTime += speed * time2;
            speed -= speed * 0.05;
            finalTime += speed * time3;
            
            Console.WriteLine(string.Format("{0:0.00}",Math.Round(finalTime, 2)));
            Console.ReadLine();
        }
    }
}
