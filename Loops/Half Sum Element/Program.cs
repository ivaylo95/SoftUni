using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int max = 0;
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max = num;
                }
                sum += num;
            }
            sum -= max;
            if (sum == max)
            {
                Console.WriteLine("Yes Sum = {0}", sum);
            }
            else
            {
                Console.WriteLine("No Diff = {0}", Math.Abs(max - sum));
            }
           
            Console.ReadLine();
        }
    }
}
