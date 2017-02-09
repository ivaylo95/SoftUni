using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concatenate_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("First name: ");
            var FirstName = Console.ReadLine();
            Console.Write("Last name: ");
            var LastName = Console.ReadLine();
            Console.Write("Age: ");
            var Age = int.Parse(Console.ReadLine());
            Console.Write("Town: ");
            var Town = Console.ReadLine();
            Console.WriteLine("You are {0} {1}, a {2}-years old person, from {3}." ,FirstName,LastName,Age,Town);
            Console.ReadLine();
        }
    }
}
