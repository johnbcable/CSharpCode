using System;
using static System.Console;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                checked 
                {
                    Write("Enter a number between 0 and 255:  ");
                    string a = ReadLine();
                    Write("Enter another number between 0 and 255:  ");
                    string b = ReadLine();

                    int x = int.Parse(a);
                    int y = int.Parse(b);

                    WriteLine($"{a} divided by {b} is {x/y}");
                }
            } 
            catch(FormatException ex) 
            {
                WriteLine($"FormatException: {ex.Message}");
            }
            catch(Exception ex2) 
            {
                WriteLine($"{ex2.Source}: {ex2.Message}");
            }
        }
    }
}
