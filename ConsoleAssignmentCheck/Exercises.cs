using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignmentCheck
{
    public class Exercises
    {

        public void Exercise1()
        {
            string firstName = "Jonathan";
            string lastName = "Krall";
            Console.WriteLine("Hello {0} {1}! I'm glad to inform you that you are the test subject of my very first assignment!", firstName, lastName);
            Console.ReadKey();
        }
        public void Exercise2()
        {
            DateTime yesterday = DateTime.Now.Date.AddDays(-1);
            DateTime today = DateTime.Now.Date;
            DateTime tomorrow = DateTime.Now.Date.AddDays(1);

            Console.WriteLine("Todays date is: {0} \nTomorrows date is: {1} \nYesterdays date was {2}", today.ToShortDateString(), tomorrow.ToShortDateString(), yesterday.ToShortDateString());
            Console.ReadKey();

        }
        public void Exercise3()
        {
            Console.Write("Please enter your first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter your last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine(firstName + " " + lastName);
            Console.ReadKey();
        }
        public void Exercise4()
        {
            string originalText = "The quick fox Jumped Over the DOG";
            string changedText = "";
            changedText = originalText.ToLower();
            changedText = changedText.Remove(0, 1);
            changedText = changedText.Insert(0, "T");
            changedText = changedText.Replace("quick", "brown");
            int indexOfDog = changedText.IndexOf("dog");
            changedText = changedText.Insert(indexOfDog, "lazy ");

            Console.WriteLine(originalText);
            Console.WriteLine(changedText);
            Console.ReadKey();

        }
        public void Exercise5()
        {
            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            str = str.Substring(str.IndexOf("["), 11);
            str = str.Insert(str.Length - 1, ",6,7,8,9,10");
            str = str.Replace("2,3,", "");
            Console.WriteLine(str);
            Console.ReadLine();
        }
        public void Exercise6()
        {
            Console.Write("Please write a number: ");
            bool ba = int.TryParse(Console.ReadLine(), out int a);
            Console.Write("Please write another number: ");
            bool bb = int.TryParse(Console.ReadLine(), out int b);
            int biggest;
            int smallest;

            if (a > b)
            {
                biggest = a;
                smallest = b;
            }
            else
            {
                biggest = b;
                smallest = a;
            }
            double sum = a + b;
            double product = a * b;
            double difference = a - b;
            double ratio = a / b;


            Console.WriteLine("The smallest: {0}\nThe biggest: {1}\nThe sum: {2}\nThe difference: {3}\nThe product: {4}\nThe ratio: {5}", smallest, biggest, sum, difference, product, ratio);
            Console.ReadKey();

        }
        public void Exercise7()
        {
            Console.Write("Please input the radius: ");
            bool possible = double.TryParse(Console.ReadLine(), out double input);

            double circleArea = Math.PI * Math.Pow(input, 2);
            double sphereVolume = (4.0 / 3) * Math.PI * Math.Pow(input, 3);
            Console.WriteLine("Area of the circle is: {0}\nVolume of the sphere is: {1}", circleArea, sphereVolume);
            Console.ReadKey();
        }
        public void Exercise8()
        {
            Console.Write("Input a decimal value: ");
            double.TryParse(Console.ReadLine(), out double input);
            double sqrt = Math.Sqrt(input);
            double pow2 = Math.Pow(input, 2);
            double pow10 = Math.Pow(input, 10);

            Console.WriteLine("The square root of {0} is: {1}\nThe power of 2 is:{2}\nThe power of 10 is:{3}", input, sqrt, pow2, pow10);
            Console.ReadKey();
        }
        public void Excercise9()
        {
            Console.WriteLine("There is no exercise 9");
            Console.ReadKey();
        }
        public void Exercise10()
        {
            bool isAlive = true;
            while (isAlive)
            {
                Console.Clear();
                Console.WriteLine("Hello user, please select one of these three options:\n1:Division \n2:Exercise 4 \n3:Change foreground color\n-1 to exit");
                bool valid = int.TryParse(Console.ReadLine(), out int input);
                if (!valid)
                    Console.WriteLine("Please select a number!");

                switch (input)
                {
                    case 1:
                        Console.Write("Please give me a number: ");
                        int.TryParse(Console.ReadLine(), out int a);
                        Console.Write("Please give me another number: ");
                        int.TryParse(Console.ReadLine(), out int b);
                        Console.Write(Division(a, b));
                        Console.ReadKey();
                        break;
                    case 2:
                        Exercise4();
                        break;
                    case 3:
                        ChangeForegroundColor();
                        break;
                    case -1:
                        isAlive = false;
                        break;
                    default:
                        break;
                }
            }


        }
        public void Exercise11()
        {
            Console.Write("Please enter a number: ");

            if (int.TryParse(Console.ReadLine(), out int input))
            {
                IterationMethod(input);
            }
            else
                Console.WriteLine("Please enter a numeric value");

            Console.ReadKey();
            Console.ResetColor();
        }
        public void Exercise12()
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int x = 1; x <= 10; x++)
                {
                    Console.Write(i * x + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public void Exercise13()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int randomNumber = rnd.Next(1, 500);
            bool correctGuess = false;
            int numberOfGuesses = 0;
            while (!correctGuess)
            {

                Console.Write("Please guess a number between 1 and 500: ");
                int.TryParse(Console.ReadLine(), out int guess);

                if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess of {0} was too high, please try again!", guess);
                    numberOfGuesses++;
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess of {0} was too low, please try again!", guess);
                    numberOfGuesses++;
                }
                else
                {
                    numberOfGuesses++;
                    Console.WriteLine("Your guess of {0} is correct!! It took you {1} tries!", guess, numberOfGuesses);
                    Console.ReadKey();
                    correctGuess = true;
                }
            }
        }
        public void Exercise14()
        {
            List<int> listOfNumbers = new List<int>();
            bool isAlive = true;
            int numberOfNumbers = 0;
            while (isAlive)
            {
                Console.Write("Please enter a number:");
                bool isAllowed = int.TryParse(Console.ReadLine(), out int number);

                if (!isAllowed)
                    number = 0;
                if (number != -1)
                {
                    listOfNumbers.Add(number);
                    numberOfNumbers++;
                }
                else
                    isAlive = false;
            }
            Console.Write("The sum of the added numbers are: {0} \nThe average of the added numbers is: {1}", listOfNumbers.Sum(),listOfNumbers.Average());
            Console.ReadKey();


        }
        public void Exercise15()
        {
            int number = 0;
            int sum = 0;
            Console.Write("Please input a number:");
            int.TryParse(Console.ReadLine(), out number);
            for (int i = 1; i < number; i++)
            {
                if(number % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("----------------------------------------------");
            for (int i = 1; i < number; i++)
            {
                sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        sum = sum + j;
                    }
                }
                if (sum == i)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
        public void Exercise16()
        {
            int a = 0;
            int b = 1;
            int c = 0;
            int number = 0;
            Console.Write("Please insert a number:");
            int.TryParse(Console.ReadLine(), out number);          
            
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < number; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
        public void Exercise17()
        {
            Console.Write("Input a string to check if it is a palindrome: ");
            string input = Console.ReadLine();
           string inputToLower = input.ToLowerInvariant();
            if (inputToLower.SequenceEqual(inputToLower.Reverse()))
                Console.Write("{0} is a palindrome", input);
            else
                Console.Write("{0} is NOT a palindrome", input);

            Console.ReadKey();
        }

        private void IterationMethod(int input)
        {
            if (input > 0)
            {
                for (int i = 0; i < input + 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(i);
                }
                Console.WriteLine("----------------");
                for (int i = input; i > 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(i);
                }
            }
            else
                Console.WriteLine("Please enter a number that is greater than 0");
        }

        private void ChangeForegroundColor()
        {
            if (Console.ForegroundColor == ConsoleColor.Gray)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
            }
        }

        private string Division(int a, int b)
        {
            string resultString;
            if (b == 0)
            {
                resultString = "You cannot divide by zero!";
            }
            else
            {
                int result = a / b;
                resultString = string.Format("{0}/{1} = {2}", a, b, result);
            }
            return resultString;
        }
    }
}
