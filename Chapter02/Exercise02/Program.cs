using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("----------------------------------------------------------------------");
            WriteLine("Type\tBytes of Memory                    Min                               Max");
            WriteLine("----------------------------------------------------------------------");
            WriteLine($"sbyte\t{sizeof(sbyte)}\t{sbyte.MinValue,30:F0}\t{sbyte.MaxValue,30:F0}");
            WriteLine($"byte\t{sizeof(byte)}\t{byte.MinValue,30:F0}\t{byte.MaxValue,30:F0}");
            WriteLine($"short\t{sizeof(short)}\t{short.MinValue,30:F0}\t{short.MaxValue,30:F0}");
            WriteLine($"ushort\t{sizeof(ushort)}\t{ushort.MinValue,30:F0}\t{ushort.MaxValue,30:F0}");
            WriteLine($"int\t{sizeof(int)}\t{int.MinValue,30:F0}\t{int.MaxValue,30:F0}");
            WriteLine($"uint\t{sizeof(uint)}\t{uint.MinValue,30:F0}\t{uint.MaxValue,30:F0}");
            WriteLine($"long\t{sizeof(long)}\t{long.MinValue,30:F0}\t{long.MaxValue,30:F0}");
            WriteLine($"ulong\t{sizeof(ulong)}\t{ulong.MinValue,30:F0}\t{ulong.MaxValue,30:F0}");
            WriteLine($"float\t{sizeof(float)}\t{string.Format("{0:0.##############E+00}", float.MinValue)}\t{float.MaxValue,30:F0}");
            WriteLine($"double\t{sizeof(double)}\t{double.MinValue,30:F0}\t{double.MaxValue,30:F0}");
            WriteLine($"decimal\t{sizeof(decimal)}\t{decimal.MinValue,30:F0}\t{decimal.MaxValue,30:F0}");
            WriteLine("----------------------------------------------------------------------");
         }
    }
}
