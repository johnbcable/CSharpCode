using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names;     // can reference an array of strings

            // allocate memory for 4 strings
            names = new string[4];

            // storing items at index positions
            names[0] = "Kate";
            names[1] = "Jack";
            names[2] = "Rebecca";
            names[3] = "Tom";

            // Loop through names
            for (int i =0; i < names.Length; i++)
            {
                // output the item at the index position
                Console.WriteLine(names[i]);
            }
        }
    }
}
