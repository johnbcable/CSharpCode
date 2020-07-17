using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = 500;
            try 
            {
                byte prev = 0;
                for (byte i = 0; i < max; i++) 
                {
                    WriteLine(i);
                    if (prev > i)
                    {
                        break;
                    };
                    prev = i;
                }
            }
            catch(Exception ex) 
            {
                WriteLine($"{ex.Source} - {ex.Message}");
            }
        }
    }
}
