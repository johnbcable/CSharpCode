using System;
using static System.Console;

namespace BooleanOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            WriteLine($"AND   | a     | b     ");
            WriteLine($"a     | {a & a, -5} | {a & b, -5}");
            WriteLine($"b     | {b & a, -5} | {b & b, -5}");
            WriteLine("");
            WriteLine($"OR    | a     | b     ");
            WriteLine($"a     | {a | a, -5} | {a | b, -5}");
            WriteLine($"b     | {b | a, -5} | {b | b, -5}");
            WriteLine("");
            WriteLine($"XOR   | a     | b     ");
            WriteLine($"a     | {a ^ a, -5} | {a ^ b, -5}");
            WriteLine($"b     | {b ^ a, -5} | {b ^ b, -5}");
            WriteLine("");
            WriteLine("Single and (&) function executes");
            WriteLine($"a & DoStuff() = {a & DoStuff()}");
            WriteLine($"b & DoStuff() = {b & DoStuff()}");
            WriteLine("Double and (&&) function does not execute for b");
            WriteLine($"a && DoStuff() = {a && DoStuff()}");
            WriteLine($"b && DoStuff() = {b && DoStuff()}");    // Function does not execute!

        }
        private static bool DoStuff() 
        {
            WriteLine("I am doing some stuff.");
            return true;
        }
    }
}
