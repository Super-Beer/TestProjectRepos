using System;
using System.Windows.Markup;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            string firstName;
            firstName = "Espen";

            string lastName;
            lastName = "Johansen";

            Console.WriteLine($" Your Name is {firstName} {lastName}");

            // 2.
            string homeTeam, awayTeam;
           
            homeTeam = "Storhamar";
            awayTeam = "Loosers";

            Console.WriteLine($"{ homeTeam} vs {awayTeam}");

            // 3.

            string Month;

            int Year;

            Year = 2020;

            int Date;

            Month = "September";

            Date = 09;

            Console.WriteLine($"{Date} {Month} {Year}");

            // 4.

            Console.WriteLine($"Today's date is {Date}th {Month} {Year}");

            // 5.

            string carOwned, carWant;

            carOwned = "Legs";
            carWant = "Tesla";

            Console.WriteLine($"I own {carOwned} I would like a {carWant}");

            // LA03 1.

            Console.WriteLine("These\nAre\nNew\nLines");

            Console.WriteLine("My favorite movie quote is \"I'll never let you go jack!\"");

            Console.WriteLine("From this day forvard, Jake Roberts shall be known as :\n Jake \"The Snake\" Roberts.");

            string nickName;
            nickName = "GodGamer";

            Console.WriteLine("From this day forvard, Espen shall be known as\n" + nickName);

            // Math I guess

           






        }
    }
}
