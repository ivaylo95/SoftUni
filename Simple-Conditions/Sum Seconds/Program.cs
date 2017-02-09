using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input time a: ");
            var a = int.Parse(Console.ReadLine());
            Console.Write("Input time b: ");
            var b = int.Parse(Console.ReadLine());
            Console.Write("Input time c: ");
            var c = int.Parse(Console.ReadLine());
            var time = a + b + c;
            var minutes = time / 60;
            var seconds = time - minutes * 60; 
            if(seconds>9)
                Console.WriteLine("{0}:{1}", minutes, seconds);
            else
                Console.WriteLine("{0}:0{1}", minutes, seconds);

             Console.ReadLine();
        }
    }
}
