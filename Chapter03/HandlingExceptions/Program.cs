using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Before parsing");

            Write("What is your age?   ");
            string input = ReadLine();

            try
            {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old");

            } 
            catch(OverflowException) 
            {
                WriteLine("The age you entered was a valid number format but was either too big or too small");
            }
            catch(FormatException) 
            {
                WriteLine("The age you entered was not a valid number format");
            }
            catch(Exception ex) 
            {
                WriteLine($"{ex.GetType()} says {ex.Message}");
            }
            WriteLine("After parsing");
        }
    }
}
