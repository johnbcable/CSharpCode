using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        private static void Harry_Shout(object sender, EventArgs eventArgs) 
        {
            Person p = (Person)sender;
            WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
        }

        static void Main(string[] args)
        {
            var harry = new Person { Name  = "Harry" };
            var mary = new Person { Name = "Mary" };
            var jill = new Person { Name = "Jill" };

            // call instance method
            var baby1 = mary.ProcreateWith(harry);

            // call static method
            var baby2 = Person.Procreate(harry, jill);

            // call an operator
            var baby3 = harry * mary;

            WriteLine($"{harry.Name} has {harry.Children.Count} children.");
            WriteLine($"{mary.Name} has {mary.Children.Count} children.");
            WriteLine($"{jill.Name} has {jill.Children.Count} children.");

            WriteLine(
                format: "{0}'s first child is named \"{1}\".",
                arg0: harry.Name,
                arg1: harry.Children[0].Name);

            // local functions
            WriteLine($"5! is {Person.Factorial(5)}");

            // delegates and events
            harry.Shout += Harry_Shout;
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();

            // interfaces
            Person[] people = 
            {
                new Person { Name = "Simon" },
                new Person { Name = "Jenny" },
                new Person { Name = "Adam" },
                new Person { Name = "Richard" }
            };
            WriteLine("Initial list of people: ");
            foreach(var person in people) 
            {
                WriteLine($"    {person.Name}");
            }
            WriteLine("Use Person's IComparable implementation to sort.");
            Array.Sort(people);
            foreach(var person in people) 
            {
                WriteLine($"    {person.Name}");
            }
            WriteLine("Use PersonComparer's IComparer implementation to sort.");
            Array.Sort(people, new PersonComparer());
            foreach(var person in people) 
            {
                WriteLine($"    {person.Name}");
            }

        }
    }
}
