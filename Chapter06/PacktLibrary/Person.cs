using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person
    {
        // fields
        public string Name;
        public DateTime DateOfBirth;
        public List<Person> Children = new List<Person>();

        // methods
        public void WriteToConsole() 
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }
    }
}
