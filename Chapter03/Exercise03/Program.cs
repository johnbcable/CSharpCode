using System;
using static System.Console;

namespace Exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 101; i++)
            {
                string message = string.Empty;
                if (i % 3 == 0)
                {
                    message+= "Fizz";
                }
                if (i % 5 == 0)
                {
                    message+= "Buzz";
                }
                if (message.Length < 1)
                {
                    message = i.ToString();
                }
                Write(message);
                if (i < 100) 
                {
                    Write(", ");
                }
                
                if (i % 10 == 0) 
                {
                    WriteLine();
                }
            }
        }
    }
}
