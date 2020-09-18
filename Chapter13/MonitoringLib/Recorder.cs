using System;
using System.Diagnostics;
using static System.Console;
using static System.Diagnostics.Process;

namespace Packt.Shared
{
    public class Recorder
    {
        static Stopwatch timer = new Stopwatch();
        static long bytesPhysicalBefore = 0;
        static long bytesVirtualBefore = 0;
        static long bytesPhysicalAfter = 0;
        static long bytesVirtualAfter = 0;
        
        public static void Start()
        {
            // forve two grabage collections to release memory that is
            // no longer referenced but has not been released yet
            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();

            // store the current physical and virtual memory use
            bytesPhysicalBefore = GetCurrentProcess().WorkingSet64;
            bytesVirtualBefore = GetCurrentProcess().VirtualMemorySize64;
            timer.Restart();

        }

        public static void Stop()
        {
            timer.Stop();
            bytesPhysicalAfter = GetCurrentProcess().WorkingSet64;
            bytesVirtualAfter = GetCurrentProcess().VirtualMemorySize64;

            WriteLine("{0:N0} physical bytes used.",
            bytesPhysicalAfter - bytesPhysicalBefore);

            WriteLine("{0:N0} virtual bytes used.",
            bytesVirtualAfter - bytesVirtualBefore);

            WriteLine("{0} time span elapsed.",timer.Elapsed);

            WriteLine("{0:N0} total milliseconds elapsed.",
            timer.ElapsedMilliseconds);
        }
    }
}
