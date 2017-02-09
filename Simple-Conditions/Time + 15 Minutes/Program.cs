using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time___15_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hours: ");
            var hours = int.Parse(Console.ReadLine());
            Console.Write("Minutes: ");
            var minutes = int.Parse(Console.ReadLine());
            if (hours >= 0 && hours <= 23)
            {
                if (minutes >= 0 && minutes <= 59)
                {
                    minutes += 15;
                    if (minutes > 59)
                    {
                        if (hours == 23)
                        {
                            hours = 0;
                            minutes -= 60; 
                            if (minutes < 10)
                            {
                                Console.WriteLine("{0}:0{1}", hours, minutes);
                            }
                            else
                            {
                                Console.WriteLine("{0}:{1}", hours, minutes);
                            }
                        }
                        else
                        {
                            hours += 1;
                            minutes -= 60;
                            if (minutes < 10)
                            {
                                Console.WriteLine("{0}:0{1}", hours, minutes);
                            }
                            else
                            {
                                Console.WriteLine("{0}:{1}", hours, minutes);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("{0}:{1}", hours, minutes);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
