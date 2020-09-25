using System;

namespace Day_3_Prog
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment

            //1.
            
            for (int blastTimer = 10; blastTimer >= 1; blastTimer--)
                {
                    Console.WriteLine(blastTimer);
                }
                    Console.WriteLine("Blast off");
            
            //2.
            /*
            Console.WriteLine("How Many Hollydays have you taken?");
            int hollyDaysUsed = Convert.ToInt32(Console.ReadLine());
            int hollyDaysInYear = 28;
            int hollyDaysLeft = hollyDaysInYear - hollyDaysUsed;

            Console.WriteLine("You have " + hollyDaysLeft + " days left to use.");
            */
            
            //3.
            /*
            Console.WriteLine("I am thinking of a number between 1 and 5");
            int numberGuess =Convert.ToInt32 (Console.ReadLine());

            
            switch (numberGuess)
            {
                case 1:
                    Console.WriteLine("Not my number! \nSorry!");
                        break;
                case 2:
                    Console.WriteLine("Not my number! \nSorry!");
                        break;
                case 3:
                    Console.WriteLine("Not my number! \nSorry!");
                        break;
                case 4:
                    Console.WriteLine("Correct! \nWell done!");
                        break;
                case 5:
                    Console.WriteLine("Not my number! \nSorry!");
                        break;
                default:
                    Console.WriteLine("Dumbass");
                        break;
            }
            */
            // 4.
            Console.WriteLine(505 - (12 / 2));


            //5.
            
           string firstName = "Eric", nickName = "\"The King\"", lastName = "Cantona";
           Console.WriteLine("And the final goal was scored by " + firstName + " " + nickName + " " + lastName);


            //6.
            /*
            Console.WriteLine(44.90 > 14.60);
            Console.WriteLine(189 < 100);

            if (44.90 > 14.60 && 189 < 100)
            {
                Console.WriteLine("The answer is TRUE"); //WIll NEVER work.
            }
            */

            //7.
            /*
            Console.WriteLine("Please submit two numbers.");
            int numberOne = Convert.ToInt32 (Console.ReadLine());
            int numberTwo = Convert.ToInt32(Console.ReadLine());

            if (numberOne > numberTwo)
            {
                Console.WriteLine(numberOne + " Is the biggest number");
            }
            else
            {
                Console.WriteLine(numberTwo + " Is the biggest number.");
            }
            */
            //8.
            /*
            Console.WriteLine("What is your age?");
            int userAge = Convert.ToInt32 (Console.ReadLine());

            if (userAge < 18)
            {
                Console.WriteLine("You are too young.");
                Console.WriteLine("Do you want to book another movie?");
            }
                else if (userAge >= 18)
                {
                Console.WriteLine("You are old enough.");
                Console.WriteLine(" Would you like to be taken to the booking screen?");
                }
            */
            //9.

         
            //10.
            /*
            int bottle = 10;
            do
            {
                Console.WriteLine(bottle + " green bottles sitting on the wall,\n \t" + bottle + "green bottles sitting on the wall,\n " +
                 "\tAnd if one green bottle should accidentally fall,\n \tThere will be" + --bottle + " Green bottles sitting on the wall");

            }
            while (bottle > 1);
            Console.WriteLine(bottle + " green bottle sitting on the wall,\n \t" + bottle + " green bottle sitting on the wall,\n " +
                 "\tAnd if one green bottle should accidentally fall,\n \tThere will be no green bottles sitting on the wall");
            
            */
            

           
        }
    }
}
