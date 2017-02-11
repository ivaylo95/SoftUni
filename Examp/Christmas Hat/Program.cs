using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Hat
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int rows =  4 * n + 1;
            int columns = 2 * n + 5;
            int spots = 2 * n - 1;
            int tire = 0;
            if (n < 3 || n > 100)
                return;
            Console.WriteLine("{0}/|\\{0}",new string('.', 2 * n - 1));
            Console.WriteLine("{0}\\|/{0}", new string('.', 2 * n - 1));

            for (int i = 0; i < n*2; i++)
            {
                
                Console.WriteLine("{0}*{1}*{1}*{0}", new string('.', spots), new string('-', tire));
                spots--;
                tire++;

            }
            Console.WriteLine(new string('*', 4 * n + 1));
            for (int j = 0; j <= ((4 * n + 1) / 2) - 1; j++)
            {
                Console.Write("{0}{1}", new string('*', 1), new string('.', 1));
            }
            Console.Write("{0}", new string('*', 1));
            Console.WriteLine();
            Console.WriteLine(new string('*', 4 * n + 1));
            Console.ReadLine();
        }
    }
}
