using System;
using System.Text.RegularExpressions;
using static System.Console;

namespace WorkingWithRegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("What is your age: ");
            string input = ReadLine();

            // var ageChecker = new Regex(@"\d");
            // var ageChecker = new Regex(@"^\d$");
            // add in a + to mean one or more digits
            var ageChecker = new Regex(@"^\d+$");
            if (ageChecker.IsMatch(input))
            {
                WriteLine("Thank you!");
            }
            else 
            {
                WriteLine($"This is not a valid age: {input}");
            }
            // Splitting complex comma separated strings
            string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";
            string[] filmsDumb = films.Split(',');
            WriteLine("Dumb attempt at splitting ---------------------:");
            foreach(string film in filmsDumb)
            {
                WriteLine(film);
            }

            WriteLine("--------------------------------------------------");
            var csv = new Regex(
                "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");

            MatchCollection filmsSmart = csv.Matches(films);
            WriteLine("Smart attempt at splitting ---------------------:");
            foreach(Match film in filmsSmart)
            {
                WriteLine(film.Groups[2].Value);
            }
            WriteLine("--------------------------------------------------");
        }
    }
}
