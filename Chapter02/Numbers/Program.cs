using System;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // unsigned integer means positive whole number
            // including 0
            uint naturalNumber = 23;

            // integer means negative or positive whole number
            // including 0
            int integerNumber = -23;

            // float means single precision floating point
            // F suffix makes it a float literal
            float realNumber = 2.3F;

            // double means double precision floating point
            double anotherRealNumber = 2.3;   // double literal

            // three variables that store the number 2 million
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
            int hexadecimalNotation = 0x_001E_8480;

            // check the tthree variables have the same value 
            // both statements output True
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

            // Statements to show size of various numbers
            Console.WriteLine($"int uses {sizeof(int)} bytes and can store nubers in the range {int.MinValue:N0} to {int.MaxValue:N0}.");
            Console.WriteLine($"double uses {sizeof(double)} bytes and can store nubers in the range {double.MinValue:N0} to {double.MaxValue:N0}.");
            Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can store nubers in the range {decimal.MinValue:N0} to {decimal.MaxValue:N0}.");



        }
    }
}
