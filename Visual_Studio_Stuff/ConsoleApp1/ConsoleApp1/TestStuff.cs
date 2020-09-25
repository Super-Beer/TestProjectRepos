using System;
using System.Runtime.InteropServices;
using System.Windows.Markup;
using System.Xml.Schema;

namespace ConsoleApp1
{
    class TestStuff
    {
        static void Main(string[] args)
        {
            /*
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

            Double x = 5 + 6 + 3;
            Console.WriteLine(x);

            Double math = 3 + (9 * 6);
            Console.WriteLine(math);

            Double subtract = 11 - 3;
            Console.WriteLine(subtract);

            Double iCantMath = 19 + 12 / 2;
            Console.WriteLine(iCantMath);

            Double moreSubtract = 15 - (2 * 6);
            Console.WriteLine(moreSubtract);

            int myAge = 20;
            int ageNextYear = 1;

            Console.WriteLine(myAge + ageNextYear);

            int yourAge = 25;
            int numberOfMonthsInYear = 12;
            int yourAgeInMonth = yourAge * numberOfMonthsInYear;
            Console.WriteLine(yourAgeInMonth);


            Console.WriteLine(1 == 1);

            
            Console.WriteLine("When were you born?");
            var answer = Console.ReadLine();
            Console.WriteLine(answer.GetType());
            Console.WriteLine(2020 - Convert.ToInt32(answer));

            // Ternary Operator
            /*
            int gregAge = 27;
            string voteable = (gregAge < 18) ? "Too young" : "Old Enough";
            Console.WriteLine(voteable);
            */
            // LA05
            /*
            Console.WriteLine(10 > 4);

            Console.WriteLine(-12 == 12);

            Console.WriteLine(85.4 >= 4);

            Console.WriteLine("Goalkeeeper" == "Goalie");

            Console.WriteLine(12 == 11);

            string colour;
            colour = "red";

            
            if (colour == "red")
            {
                Console.WriteLine("Red is the colour");
            }

            Console.WriteLine("Was it over the line?");
            var lineAnswer = Console.ReadLine();

            if (lineAnswer == "yes")
            {
                Console.WriteLine("GOOOOOOOOAAAAAL");

            }
            else
            {
                Console.WriteLine("So Close!");
            }
            
           
            
            Console.WriteLine("What is your name?");
            var nameAnswer = Console.ReadLine();
            Console.WriteLine("Hello " + nameAnswer + " How are you today?");
            
            
            Console.WriteLine("Please enter your gender.");
            var genderAnswer = Console.ReadLine();
            switch(genderAnswer)
            {
                case "male":
                    Console.WriteLine("Hello Sir.");
                    break;

                default:
                    Console.WriteLine("Aight thanks.");
                    break;
            }
            

            var goalScore = 2;
            if (goalScore == 1)
            {
                Console.WriteLine( goalScore + "goal");
            }
            else if (goalScore == 2)
            {
                Console.WriteLine( goalScore + "goals!");
            }
            else
            {
                Console.WriteLine("Screw it. The game sucked anyways.");
            }

            int joeAge = 17;
            string voteable = (joeAge <= 18) ?
                "Chris hansen wants a word." : "Can vote";
            Console.WriteLine(voteable);
            */
            /*
            Console.WriteLine(10 > 4 && 4 < 1);

            Console.WriteLine(10 > 55.60 || 89 < 100);

            Console.WriteLine(50 == 55.60);

            Console.WriteLine(100 < 101 && 68 == 33 * 2);

            Console.WriteLine("What is the best colour? Red or Blue?");
            string color = Console.ReadLine();
            if (color == "Red" || color == "Blue")
            {
                Console.WriteLine("You`re right. " + color + " is the best color.");
            }
            // You're right. Red is the best color.
            // You're right. Blue is the best color

            string takenEmailAddress = "Espen.Stenerud@email.com";
            Console.WriteLine("Write your email address");
            string userEmailAddress = Console.ReadLine();
            if (userEmailAddress == takenEmailAddress)
            {
                Console.WriteLine("Sorry" + userEmailAddress + "is being used by another user.");
            }
            else
            {
                Console.WriteLine("yes " + userEmailAddress + " is available for you.");
            }

            Console.WriteLine("Please enter your gender.");
            var genderAnswer = Console.ReadLine();
            */
            /*
            if (genderAnswer == "male" ||
                (genderAnswer == "Male" ||
                (genderAnswer == "MALE" ||
                (genderAnswer == "man" ||)
            {

            }
            else if ()
            {

            }
            else ()
            {

            }

            switch (genderAnswer)
            {
                case "Male":
                case "male":
                case "MALE":
                case "man":
                    Console.WriteLine("Hello Sir.");
                    break;

                default:
                    Console.WriteLine("Aight thanks.");
                    break;
            }
            */
            /*
            for(int a = 1; a < 11; a++)
            {
                Console.WriteLine(a);
            }

            for(int b = 10; b > 0; b--)
            {
                Console.WriteLine(b);
            }

            for (int c = 0; c < 100; c+=2)
            {
                Console.WriteLine(c);
            }

            for (int d = 99; d > 1; d -= 2)
            {
                Console.WriteLine(d);
            }

            for (int e = 1; e < 21; e++)
            {
                if (e % 2 == 0)
                { Console.WriteLine(e + " Is even."); }
                else
                {
                    Console.WriteLine(e + " Is odd");
                }

             
            }

            Console.WriteLine("Enter a number between 0 and 10.");
            int usernumber = Convert.ToInt32(Console.ReadLine());
            for (int f = 1; f <= 10; f++)
            {
                Console.WriteLine(f + " * " + usernumber + " = " + (f * usernumber));
            }

            //LA07-7
            Console.WriteLine("Give me a number.");
            int numberForFactors = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Here are the factors of " + numberForFactors + ":");
            for (int candidateFactor = 2; candidateFactor <= numberForFactors; candidateFactor++)
            {
                if (numberForFactors % candidateFactor ==0)
                {
                    Console.WriteLine(candidateFactor);
                }
            }

            /*

            //LA07-8
            /*
            int g = 1;
            while(g <= 10)
            {
                Console.WriteLine(g);
                g++;
            }

            int h = 10;
            while(h>=1)
            {
                Console.WriteLine(h);
                h--;
            }

            int x = 0;
            while(x<5)
            {
                Console.WriteLine("Hello");
                x++;
            }

            int numberA = 100;
            while (numberA >= 1)
            {
                if (numberA % 2 != 0)
                    Console.WriteLine(numberA);

                numberA--;
            }
            
            */

           // LA-10 Do everything again.
           
            // 1.
            /*
           for (int blastCount = 10; blastCount >= 0; blastCount-- )
            {
              if (blastCount == 0)
                {
                    Console.WriteLine("Blast off!");
                }
              else
                {
                    Console.WriteLine(blastCount);
                }
            }
           // 2.

            Console.WriteLine("How many holidays have you taken?");
            int holiDaysUsed = Convert.ToInt32(Console.ReadLine());
            int holidaysInYear = 28;

            int holiDaysLeft = holidaysInYear - holiDaysUsed;
            Console.WriteLine("You have " + holiDaysLeft + " Days left to use");
            */

            Console.WriteLine("I am thinking of a number between 1 and 5 try and guess it.");
            string numberGuess = Console.ReadLine();
            switch(numberGuess)
            {
                case "1":
                    Console.WriteLine("Not my number \n Sorry!");
                    break;
                case "2":
                    Console.WriteLine("Not my number \n Sorry!");
                    break;
                case "3":
                    Console.WriteLine("Correct! \n Well done!");
                    break;
                case "4":
                    Console.WriteLine("Not my number \n Sorry!");
                    break;
                case "5":
                    Console.WriteLine("Not my number \n Sorry!");
                    break;
                default:
                    Console.WriteLine("Dumbass...");
                    break;
            }


        }
    }
}
