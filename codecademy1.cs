using System;

namespace GettingInput
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Name? ");
            string input = Console.ReadLine();
            Console.WriteLine($"Ur name is {input}");
        }
    }
}