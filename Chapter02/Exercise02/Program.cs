using System;
using static System.Console;

namespace Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("------------------------------------------------------------");
            WriteLine("Type\tBytes of Memory          Min                     Max");
            WriteLine("------------------------------------------------------------");
            WriteLine($"sbyte\t{sizeof(sbyte)}\t{sbyte.MinValue,20:N0}\t{sbyte.MaxValue,20:N0}");
            WriteLine($"byte\t{sizeof(byte)}\t{byte.MinValue,20:N0}\t{byte.MaxValue,20:N0}");
            WriteLine($"short\t{sizeof(short)}\t{short.MinValue,20:N0}\t{short.MaxValue,20:N0}");
            WriteLine($"ushort\t{sizeof(ushort)}\t{ushort.MinValue,20:N0}\t{ushort.MaxValue,20:N0}");
            WriteLine($"int\t{sizeof(int)}\t{int.MinValue,20:N0}\t{int.MaxValue,20:N0}");
            WriteLine($"uint\t{sizeof(uint)}\t{uint.MinValue,20:N0}\t{uint.MaxValue,20:N0}");
            WriteLine($"long\t{sizeof(long)}\t{long.MinValue,20:N0}\t{long.MaxValue,20:N0}");
            WriteLine($"ulong\t{sizeof(ulong)}\t{ulong.MinValue,20:N0}\t{ulong.MaxValue,20:N0}");
            WriteLine($"float\t{sizeof(float)}\t{float.MinValue,20:N0}\t{float.MaxValue,20:N0}");
            WriteLine($"double\t{sizeof(double)}\t{double.MinValue,20:N0}\t{double.MaxValue,20:N0}");
            WriteLine($"decimal\t{sizeof(decimal)}\t{decimal.MinValue,20:N0}\t{decimal.MaxValue,20:N0}");
            WriteLine("------------------------------------------------------------");
         }
    }
}
