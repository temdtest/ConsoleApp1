using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello User, please enter your name: ");
            // Comment section inserted

            var userInput = Console.ReadLine();
            Console.WriteLine($"Hello {userInput}!");

        }
    }
}
