using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int br = 1;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", br);
                    if (br == n)
                    {
                        goto Foo;
                    }
                    br++;
                    
                }
                Console.WriteLine();
                
            }
            Foo:
            Console.ReadLine();
        }
    }
}
