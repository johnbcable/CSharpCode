﻿using System;
using System.Numerics;
using static System.Console;

namespace WorkingWithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var largest = ulong.MaxValue;

            WriteLine($"{largest, 40:N0}");

            var atomsInTheUniverse = BigInteger.Parse("123456789012345678901234567890");
            WriteLine($"{atomsInTheUniverse, 40:N0}");

            // Complex numbers
            var c1 = new Complex(4, 2);
            var c2 = new Complex(3, 7);
            var c3 = c1 + c2;  
            WriteLine($"{c1} added to {c2} is {c3}");

            
        }
    }
}
