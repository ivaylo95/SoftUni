using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            if (n < 2 || n > 100)
                Console.WriteLine("Error");
            int k = 2;
            int p = 1;
            for (int i = 0; i < (n+1)/2; i++)
            {
                if (n % 2 == 0)
                {

                    string stars = new string('*', k);
                    string tire = new string('-', (n + 1) / 2 - i - 1);
                    Console.Write(tire);
                    Console.Write(stars);
                    Console.Write(tire);
                    k += 2;
                }
                else
                {
                    string stars = new string('*', p);
                    string tire = new string('-', (n + 1) / 2 - i - 1);
                    Console.Write(tire);
                    Console.Write(stars);
                    Console.Write(tire);
                    p += 2;
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n / 2 ; i++)
            {
                string lines = new string('|', 1);
                string stars = new string('*', n-2);
                Console.Write(lines);
                Console.Write(stars);
                Console.Write(lines);
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
