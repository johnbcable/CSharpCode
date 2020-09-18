using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace LinqInParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            var watch = Stopwatch.StartNew();
            Write("Press Enter to start: ");
            ReadLine();
            watch.Start();

            IEnumerable<int> numbers = Enumerable.Range(1,200_000_000);

            var squares = numbers.AsParallel().Select(number => number * number).ToArray();

            watch.Stop();
            WriteLine("{0:#,##0} elapsed milliseconds.",
                watch.ElapsedMilliseconds);
        }
    }
}
