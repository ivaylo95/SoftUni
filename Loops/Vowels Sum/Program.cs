using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            var sum = 0;
            for (int a = 0; a < s.Length; a++)
            {
                if (s[a] == 'a') sum += 1;
                else if (s[a] == 'e') sum += 2;
                else if (s[a] == 'i') sum += 3;
                else if (s[a] == 'o') sum += 4;
                else if (s[a] == 'u') sum += 5;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
