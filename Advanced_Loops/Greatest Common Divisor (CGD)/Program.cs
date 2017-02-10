using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greatest_Common_Divisor__CGD_
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var nod = 0;
            bool isNOD = true;
            int j=0, k=0;
            while (isNOD)
            {
                if (a == b)
                {
                    nod = a;
                    isNOD = false;
                }
                else
                {
                    if (a > b)
                    {
                        a = a - b;
                    }
                    else
                    {
                        b = b - a;
                    }
                }
            }

            Console.WriteLine(nod);
            Console.ReadLine();
                
        }
    }
}
