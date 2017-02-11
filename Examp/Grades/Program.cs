using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            double twoPlus = 0;
            double threePlus = 0;
            double fourPlus = 0;
            double fivePlus = 0;
            for (int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sum += grade;
                if (grade >= 2.00 && grade <= 2.99)
                    twoPlus++;
                else if (grade >= 3.00 && grade <= 3.99)
                    threePlus++;
                else if (grade >= 4.00 && grade <= 4.99)
                    fourPlus++;
                else if (grade >= 5.00 && grade <= 6.00)
                    fivePlus++;
                else
                    Console.WriteLine("Incorrect grade!");
            }
            Console.WriteLine("Top students: {0:f2}%", fivePlus / n * 100);
            Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", fourPlus / n * 100);
            Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", threePlus / n * 100);
            Console.WriteLine("Fail: {0:f2}%", twoPlus / n * 100);
            Console.WriteLine("Average: {0:f2}", sum / n);
            Console.ReadLine();
        }
    }
}
