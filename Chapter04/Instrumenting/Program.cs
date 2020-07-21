using System;
using System.Diagnostics;

namespace Instrumenting
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.WriteLine("Debug says - I am watching!");
            Trace.WriteLine("Trace says - I am watching!");        
        }
    }
}
