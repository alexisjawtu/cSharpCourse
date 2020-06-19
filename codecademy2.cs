using System;

namespace GettingInput
{
    class Program
    {
        static void Main()
        {
            // Asks for the age and prints it back
            Console.WriteLine("Age? ");
            string input = Console.ReadLine();
            Console.WriteLine($"You are {input} years old.");
        }
    }
}