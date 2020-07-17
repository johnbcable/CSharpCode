using System;
using static System.Console;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;

            while (x < 10)
            {
                WriteLine(x);
                x++;
            }

            // string matching from input
            string password = string.Empty;

            do{
                Write("Enter your password and press Enter ...  ");
                password = ReadLine();
            }
            while (password != "Pa$$w0rd");
            WriteLine("Correct!)");

            // For loop
            WriteLine("\nNormal for loop .......\n");
            for (int y = 1; y <= 10; y++)
            {
                WriteLine(y);
            }

            // foreach statement
            WriteLine("\nforeach statement .......\n");
            string[] names = {"Adam","Barry","Charlie"};

            foreach (string name in names)
            {
                WriteLine($"{name} has {name.Length} characters.");
            }
        }
    }
}
