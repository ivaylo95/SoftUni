using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine().ToLower());
            char lastLetter = char.Parse(Console.ReadLine().ToLower());
            char missingLetter = char.Parse(Console.ReadLine().ToLower());
            int count = 0;
            for (char i = firstLetter; i <= lastLetter; i++)
            {
                for (char j = firstLetter; j <= lastLetter; j++)
                {
                    for (char k = firstLetter; k <= lastLetter; k++)
                    {
                        
                        if (i == missingLetter)
                        {
                            
                        }
                        else if (j == missingLetter)
                        {
                            
                        }
                        else if (k == missingLetter)
                        {
                            
                        }
                        else
                        {
                            Console.Write(i + "" + j + "" + k + " ");
                            count++;
                        }
                        
                    }
                }
            }

            Console.WriteLine(count);

            Console.ReadLine();
        }
    }
}
