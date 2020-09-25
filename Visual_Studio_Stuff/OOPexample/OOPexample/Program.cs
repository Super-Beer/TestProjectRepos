using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOPexample
{   
    class First
    {
        string name;
        int age;
        private int pinNo = 1234;

        public static string greetings = "Have a great day!";

        public First()
        {

        }

        public First(string _name, int _age, int _pin)
        {
            name = _name;
            age = _age;
            pinNo = _pin;
            PrintMessage();
            creditCardPin();
        }

        public First(int _pin)
        {
            
            pinNo = _pin;
            creditCardPin();
        }
        public void PrintMessage()
        {
            Console.WriteLine("Hello, my name is " + name + ".\nMy age is " + age + ".");
        }

        public void PrintMessage(string _name, int _age)
        {
            Console.WriteLine("Hello, my name is " + _name + ".\nMy age is " + _age + ".");
        }

        public void creditCardPin()
        {
            Console.WriteLine("My default credit card pin is " + pinNo);
        }

    }


    class Vehicle
    {
       public string brand;
       public string model;
       public string energy;
       public string color;

        public string GetColor()
        {
            return color;
        }
        public string GetBrand()
        {
            return brand;
        }
        public string GetModel()
        {
            return model;
        }
        public string GetEnergy()
        {
            return energy;
        }

    }


    class Plane : Vehicle
    {
        int numberOfWings;
        string cabinColor;
        string cockpitColor;

        public Plane(string _brand, string _model, string _energy, string _color)
        {
            brand = _brand;
            model = _model;
            energy = _energy;
            color = _color;
        }

        public void setNumberOfWings (int _numberOfWings)
        {
            numberOfWings = _numberOfWings;
        }
        public void SetColor(string _cabinColor)
        {
            cabinColor = _cabinColor;
        }

        public void SetCockPitColor(string _cockPitColor)
        {
          cockpitColor = _cockPitColor;
        }

        public int GetNumberOfWings()
        {
            return numberOfWings;
        }
    }   



    class Car : Vehicle
    {        
        public Car(string _brand, string _model, string _energy, string _color)
        {
            brand = _brand;
            model = _model;
            energy = _energy;
            color = _color;
        }

        public string GetColor()
        {
            return color;
        }
        public string GetBrand()
        {
            return brand;
        }
        public string GetModel()
        {
            return model;
        }
        public string GetEnergy()
        {
            return energy;
        }


    }

    class Program
    {
        static void Main(string[] args)

        {
            /*
            Car myFirstCar = new Car("Ford", "Mustang", "Gas", "Blue");
            Console.WriteLine("My first car is a" + myFirstCar.GetBrand() + " " + myFirstCar.GetModel() + "\n " + myFirstCar.GetColor() + " " + myFirstCar.GetEnergy());

            Plane airbusA380 = new Plane("Airbus", "A380", "Gas", "White");
            airbusA380.setNumberOfWings(2);
            Console.WriteLine("there are " + airbusA380.GetNumberOfWings());

            WrtiteSplashScreen("David", 44);
            WrtiteSplashScreen("John", 20);

            //1.
            
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            WrtiteSplashScreen(name, age);
            
            void WrtiteSplashScreen(string _name, int _age)
           {
              Console.WriteLine("User is " + _name + " and is " + _age + " years old");
           }

            // 2.

            Console.WriteLine("What is the current year?");
            int currentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("When were you born? (year)");
            int birthYear = Convert.ToInt32(Console.ReadLine());
            CalculateAge(currentYear, birthYear);

            void CalculateAge(int _currentYear, int _birthYear)
            {
                Console.WriteLine("We are in " + _currentYear + " You were born in " + _birthYear + " so you are " + (_currentYear - _birthYear) + " years old.");
            }
            */

            // 3.
            /*
            int first = 10;
            int second = 5;
            int third = 20;
            int fourth = 25;
            int sum = first + second + third + fourth;
            calculationOfNumbers(first, second, third, fourth, sum);

            void calculationOfNumbers(int _first, int _second, int _third, int _fourth, int _sum)
            {
                Console.WriteLine("First number is " + _first + " Second number is" + _second + " Third number is " + _third + " Fourth number is " + _fourth + " sum total is " + _sum);
            }
            */
            
            //Better way

            CalculateNumbers(4, 7, 3, 8);
            
            void CalculateNumbers(int firstNumber, int secondNumber, int thirdNumber, int fourthNumber)
            {
                int sum = firstNumber + secondNumber + thirdNumber + fourthNumber;
                Console.WriteLine("The sum of " + firstNumber + " + " + secondNumber + " + "+ thirdNumber + " + "+ fourthNumber + " is " + sum);
            }

            

            //4.
            /*
            Console.WriteLine("How old is your dog?");
            int userDogYear = Convert.ToInt32(Console.ReadLine());
            int totalDogyear = (userDogYear * 7);
            calculationOfDogyears(userDogYear, totalDogyear);
            
            void calculationOfDogyears(int _userDogYear, int _totalDogyear)
            {
                Console.WriteLine("Your dog is " + userDogYear + " human years old. And is " + totalDogyear + " dog years old");
            }
            */
            
            /*
            //Other way
            Console.WriteLine("How old is your dog?");
            int dogAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your dog is " + calculateDogAge(dogAge) + " years old in \" human years\" ");

            int calculateDogAge(int _dogAge)
            {
                return _dogAge * 7;
            }
            */
            
            //6
            /*
            void GetOddorEven(int _counter)
            {
                if (_counter % 2 == 0)
                    Console.WriteLine(_counter + " Even");
                else
                    Console.WriteLine(_counter + " Odd");

            }
            
            int counterC = 1;
            while (counterC <= 20)
            {
                GetOddorEven(counterC)

                counterC++;
            }

            */


            //7
            /*
            Console.WriteLine("Please add the hight of your room.");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please add the width of your room.");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please add the length of your room.");
            int length = Convert.ToInt32(Console.ReadLine());

            calcRoomVolume(height, width, length);
            
            void calcRoomVolume(int _height, int _width, int _length)
            {
                // Can also use return _length * _width * _height;
                int totalVolume = height * width * length;
                Console.WriteLine("Height = " + _height + " Width= " + _width + " Length =" + _length + " The total volume of your rom is " + totalVolume);
            }
            */


            //8.
            
            Console.WriteLine("How much Euros do you want to convert?");
            float amountInEuros = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("In wich currency do you want to convert NOK,GBP,USD?");
            string currency = Console.ReadLine();
            float convertedMoney = ConvertMoney(amountInEuros, currency);
            
            Console.WriteLine("You will recieve " + convertedMoney + " " + currency);

            float ConvertMoney(float _amount, string _currency)
            {
                float convertedAmount = 0f;
                switch (currency)
                {
                   
                    case "NOK":
                        convertedAmount = _amount * 11;
                        break;
                    case "GBP":
                        convertedAmount = _amount * 1.16f;
                        break;
                    case "USD":
                        convertedAmount = _amount * 1.16f;
                        break;
                    default:
                        Console.WriteLine("This is not vallid currency");
                        break;
                }
                return convertedAmount;
               
            }   
            


            // 9.

            int numberOfTIcketsAvailable = 100;
            int numberOfTicketsRequiredByUser;

           //First user
            Console.WriteLine("How manu tickets do you want?");
            numberOfTicketsRequiredByUser = Convert.ToInt32(Console.ReadLine());

            checkTicketsAvailability(numberOfTicketsRequiredByUser);
            //Second User
            
            Console.WriteLine("How manu tickets do you want?");
            numberOfTicketsRequiredByUser = Convert.ToInt32(Console.ReadLine());
            checkTicketsAvailability(numberOfTicketsRequiredByUser);

            void checkTicketsAvailability(int _requiredTickets)
            {
                if (_requiredTickets > numberOfTIcketsAvailable)
                {
                    Console.WriteLine("There is not enough tickets available.");
                }
                else
                {
                    Console.WriteLine(_requiredTickets + " Tickets are booked for you.");
                    numberOfTIcketsAvailable -= _requiredTickets;
                    ConfirmTicketsPrinting(_requiredTickets);

                }
            }
            void ConfirmTicketsPrinting(int _requiredTickets)
            {
                Console.WriteLine("We can confirm that " + _requiredTickets + " Will be printed and sent out.");
                Console.WriteLine("Remaining tickets available: " + numberOfTIcketsAvailable);
                
            }



            Thread.Sleep(60000);

        }

        
    }
}
