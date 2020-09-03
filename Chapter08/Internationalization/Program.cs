using System;
using System.Globalization;
using static System.Console;
namespace Internationalization
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo globalization = CultureInfo.CurrentCulture;
            CultureInfo localization = CultureInfo.CurrentUICulture;

            WriteLine("The current globalization culture is {0}: {1}",
                globalization.Name, globalization.DisplayName);
            WriteLine("The current localization culture is {0}: {1}",
                localization.Name, localization.DisplayName);
            WriteLine();

            WriteLine("en-US: English (United States)") ;
            WriteLine("da-DK: Danish (Denmark)") ;
            WriteLine("fr-CA: French (Canada))") ;
            Write("Type an ISO culture code and press Enter: ");
            string newCulture = ReadLine();
            if (!string.IsNullOrEmpty(newCulture))
            {
                var ci = new CultureInfo(newCulture);
                CultureInfo.CurrentCulture = ci;
                CultureInfo.CurrentUICulture = ci;
            }
            WriteLine();

            Write("Type your name and press Enter: ");
            string name = ReadLine();
            Write("Type your date of birth and press Enter: ");
            string dob = ReadLine();
            Write("Type your salary and press Enter: ");
            string salary = ReadLine();

            DateTime date = DateTime.Parse(dob);
            int minutes = (int)DateTime.Today.Subtract(date).TotalMinutes;
            decimal earns = decimal.Parse(salary);

            WriteLine(
                "{0} was born on a {1:dddd}, is {2:N0} minutes old, and earns {3:C}",
                name, date, minutes, earns
            );
            

        }
    }
}
