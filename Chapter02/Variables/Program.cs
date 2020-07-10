using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88;                   // storing a double in an object
            object name = "Amir";                   // storing a string in an object
            var population = 66_000_000;            // 66 million in UK
            var weight = 1.8;                       // in kilograms
            var price = 4.99M;                      // in pounds sterling
            var fruit = "Apples";                   // strings use double quotes
            var letter = 'Z';                       // single characters use single quotes
            var happy = true;                       // Booleans have the value true or false

            Console.WriteLine($"{name} is {height} metres tall");

            // int length1 = name.Length;                  // should give compile error
            int length2 = ((string)name).Length;        // tell compiler it is a string

            Console.WriteLine($"{name} has {length2} characters");

            // storing a string in a dynamic object
            dynamic anotherName = "Ahmed";

            // this compioes but will throw an exception at run-time
            // if you later store a data type that does not have a 
            // property named Length
            int length = anotherName.Length;

            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");
        }
    }
}
