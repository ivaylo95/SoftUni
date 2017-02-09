using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            var score = double.Parse(Console.ReadLine());
            double bonusScore = 0;
            double totalScore = 0;
            if (score % 2 == 0)
            {
                bonusScore += 1;
            }
            if (score % 5 == 0 && score % 2 != 0)
            {
                bonusScore += 2;
            }
            if (score <= 100)
            {
                bonusScore += 5;
            }
            else if (score > 100 && score <= 1000)
            {
                bonusScore += score * 20 / 100;
            }
            else
            {
                bonusScore += score * 10 / 100;
            }
            totalScore = score + bonusScore;
            Console.WriteLine("Bonus Score: {0}", bonusScore);
            Console.WriteLine("Total Score: {0}", totalScore);
            Console.ReadLine();
        }
    }
}
