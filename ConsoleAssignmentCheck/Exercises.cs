using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Timers;

namespace ConsoleAssignmentCheck
{
    public class Exercises
    {
        public static string inputPath = @"C:\Excercise\input.txt";
        public static string outputPath = @"C:\Excercise\output.txt";
        public static int nr = 1;
        public void ExerciseSpecial()
        {
            //Console.WriteLine("Please insert the message you want to save:");
            //string message = Console.ReadLine();
            ////using (StreamReader sr = new StreamReader(inputPath))
            ////{
            ////    string line = sr.ReadToEnd();
            ////    string[] strArr = line.Split(new Char[] { '\n', '\r',',' }, StringSplitOptions.RemoveEmptyEntries);

            ////Array.Reverse(strArr);
            ////foreach (var item in strArr)
            ////{
            ////    Console.WriteLine(item);
            ////}             


            ////string[] strArr = message.Split(new Char[] { '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries);
            ////if (File.Exists(outputPath))
            ////{
            ////    //using (StreamWriter writer = new StreamWriter(outputPath))
            ////    //{
            ////        //foreach (string str in strArr)
            ////        //{
            ////        //    File.AppendAllText(outputPath, str);
            ////        //    //writer.WriteLine(str);
            ////        //    //writer.WriteLine("---");
            ////        //}
            ////    //}
            //if (message == "Clear" || message == "clear")
            //{
            //    File.Delete(outputPath);
            //}
            //else
            //{
            //    File.AppendAllText(outputPath,DateTime.Now + " || " + message + Environment.NewLine);
            //    Process.Start(outputPath);
            //}

            Timer timer = new Timer
            {
                Interval = 10000
            };
            timer.AutoReset = true;
            timer.Elapsed += new ElapsedEventHandler(WriteToFile);
            timer.Start();
            Console.WriteLine("Press any key to cancel logging (Press L to check log)");
            var input = Console.ReadKey();
            if (input.Key == ConsoleKey.L)
            {
                File.AppendAllText(outputPath, Environment.NewLine + "Number of iterations: " + (nr - 1) + Environment.NewLine + "----------------------------------------------------" + Environment.NewLine);
                Process.Start(outputPath);
            }
            else
            {
                File.AppendAllText(outputPath, Environment.NewLine + "Number of iterations: " + (nr - 1) + Environment.NewLine + "----------------------------------------------------" + Environment.NewLine);
                return;
            }
        }

        private void WriteToFile(object sender, ElapsedEventArgs e)
        {
            File.AppendAllText(outputPath, nr + " || " + DateTime.Now + Environment.NewLine);
            nr++;
        }

        public void Exercise1()
        {
            string firstName = "Jonathan";
            string lastName = "Krall";
            Console.WriteLine("Hello {0} {1}! I'm glad to inform you that you are the test subject of my very first assignment!", firstName, lastName);
            List<string> firstList = new List<string>() { "kalle", "krall", "sven" };

            //List<string> secondList = new List<string>();

            //Console.WriteLine("First list: ");
            //foreach (var item in firstList)
            //{
            //    Console.WriteLine(item);
            //}
            //secondList.AddRange(firstList);

            //Console.WriteLine("Second list: ");
            //foreach (var item in secondList)
            //{
            //    Console.WriteLine(item);
            //}
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
            Console.Write("The sum of the added numbers are: {0} \nThe average of the added numbers is: {1}", listOfNumbers.Sum(), listOfNumbers.Average());
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
                if (number % i == 0)
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
        public void Exercise18()
        {
            int[] intArr = new int[10];
            double[] doubleArr = new double[10];
            Random rnd = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < intArr.Length; i++)
            {
                intArr[i] = rnd.Next(100);
            }
            for (int i = 0; i < intArr.Length; i++)
            {
                doubleArr[i] = 1 / (double)intArr[i];

            }
            Console.WriteLine("Int-array");
            foreach (var item in intArr)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Double-array");
            foreach (var item in doubleArr)
            {
                Console.WriteLine(item);
            }


            //foreach (var item in intArr)
            //{
            //    Console.WriteLine(item);
            //}
            Console.ReadKey();
        }
        public void Exercise19()
        {


            //int[] moneyArr = new int[] { 1, 2, 5, 10, 50, 100, 200, 500, 1000 };
            //Random rnd = new Random(DateTime.Now.Millisecond);
            //int amountToPay = rnd.Next(1000);
            //Console.WriteLine("The amount to pay is: {0}",amountToPay);
            ////1,2,5,10,20,50,100,200,500,1000
            //Console.Write("Money to insert: ");

            //int.TryParse(Console.ReadLine(),out int money);

            //var change = money - amountToPay;
            //int numberOfCurrency= 0;

            //    Console.WriteLine("{0}x{1}SEK", numberOfCurrency, moneyArr[i]);
            //    numberOfCurrency = 0;


            //Console.WriteLine("You received a total of {0}SEK in change",change);

            //Console.ReadKey();

        } //TODO: Complete method
        public void Exercise20()
        {
            int[] intArrA = new int[10];
            int[] intArrB = new int[10];
            Random rnd = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < intArrA.Length; i++)
            {
                intArrA[i] = rnd.Next(100);
            }


            Console.WriteLine("Array A");
            foreach (var item in intArrA)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Array B");
            foreach (var item in intArrB)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        } //TODO: Complete method
        public void Exercise21()
        {
            string[] stringArr;
            Console.Write("Please insert a string of comma seperated numbers: ");
            string input = Console.ReadLine();
            stringArr = input.Split(',');

            int[] intArr = new int[stringArr.Length];

            for (int i = 0; i < stringArr.Length; i++)
            {
                int.TryParse(stringArr[i], out int number);
                intArr[i] = number;
            }
            Console.WriteLine("Minimum value: {0}", intArr.Min());
            Console.WriteLine("Maximum value: {0}", intArr.Max());
            Console.WriteLine("Average value: {0}", intArr.Average());

            Console.ReadKey();
        }
        public void Exercise22()
        {
            string[] arrayOfWords = new string[] { "fuck", "shit", "hell", "dick", "cunt", "pussy", "asshole" };

            Console.Write("Please add a string: ");
            string newString = "";
            List<string> stringToCheck = Console.ReadLine().Split(' ').ToList();

            //int index = listofelements.IndexOf(oldValue);
            //if (index != -1)
            //    listofelements[index] = newValue;
            foreach (var item in stringToCheck)
            {
                if (arrayOfWords.Contains(item))
                {
                    int index = stringToCheck.IndexOf(item);
                    if (index != -1)
                        stringToCheck[index] = "kitten ";
                }
            }
            foreach (var item in stringToCheck)
            {
                Console.Write(" " + item + " ");
            }



            //newString = string.Join(" ", stringToCheck);


            Console.WriteLine(newString);
            Console.ReadKey();
        } //TODO: Complete method
        public void Exercise23()
        {
            Random rnd = new Random(DateTime.Now.Millisecond);
            int[] firstArr = new int[7];

            for (int i = 0; i < firstArr.Length; i++)
            {
                int numberToAdd = rnd.Next(1, 10);
                if (firstArr.Contains(numberToAdd))
                {
                    bool exists = true;
                    while (exists)
                    {
                        numberToAdd = rnd.Next(1, 10);
                        if (!firstArr.Contains(numberToAdd))
                        {
                            firstArr[i] = numberToAdd;
                            exists = false;
                        }
                    }
                }
                else
                    firstArr[i] = numberToAdd;

            }
            foreach (var item in firstArr)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
        public void Exercise24()
        {
            int[] deck = new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5, 6, 6, 6, 6, 7, 7, 7, 7, 8, 8, 8, 8, 9, 9, 9, 9, 10, 10, 10, 10, 11, 11, 11, 11, 12, 12, 12, 12, 13, 13, 13, 13 };
            int[] hand = new int[1];

            bool playing = true;
            while (playing)
            {
                Console.WriteLine("Do you want to draw a card? (y/n)");
                ConsoleKey pressedKey = Console.ReadKey().Key;
                Console.Clear();

                if (pressedKey == ConsoleKey.Y)
                {
                    if (deck.Length == 0)
                    {
                        Console.WriteLine("No more cards available!");
                        break;
                    }
                    ShuffleCards(ref deck);
                    int drawnCard = DrawCard(ref deck);
                    Console.WriteLine("You drew: {0}!", drawnCard);
                    hand[hand.Length - 1] = drawnCard;
                    Console.WriteLine("You currently have these cards in your hand: ");
                    foreach (var item in hand)
                    {
                        Console.Write(" " + item + " ");
                    }
                    Array.Resize(ref hand, hand.Length + 1);

                }
                else
                {
                    playing = false;
                }
            }
            Console.WriteLine("Thank you for playing!");
            Console.ReadKey();
        }
        public void Exercise25()
        {
            Console.Write("Please insert a number: ");
            int number = InsertNumber(Console.ReadLine());
            Console.WriteLine(number);
            Console.ReadKey();
            //            *
            //            *Create a separate function(from the exercise method) that asks the user to input a valid integer value. The function should keep executing until the user has inputted a valid integer
            //value.Use a Try -catch combined with a while-loop.If the user inputs a none - valid number, display
            // an error asking him / her to try again.
            //   Then in the exercise method, call the method you just wrote twice to retrieve 2 integers from the
            //   user and store them in variables.Then divide one of the number with the other and use a try-catch
            //to catch any potential division by zero.Display the result to the screen.

            //Note: Use the correct Exception type, example FormatException, DivideByZeroException and
            //ArgumentNullException and multiple catch-statements to display a friendly error message
            //depending on which error occurs.

        }

        static int InsertNumber(string number)
        {
            bool isCorrect = false;
            while (!isCorrect)
            {
                try
                {
                    int validNumber = int.Parse(number);
                    return validNumber;
                }
                catch (FormatException)
                {

                    Console.WriteLine("Not a number, please input a number");
                    Console.ReadKey();
                    continue;

                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("String is empty, please insert something");
                    Console.ReadKey();
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("The number is too large or too small");
                    Console.ReadKey();
                    continue;
                }
            }

            return 0;
        }
        static int DrawCard(ref int[] deck)
        {
            int card = 0;
            card = deck[0];
            deck.Reverse();
            Array.Resize(ref deck, deck.Length - 1);

            return card;
        }
        static void ShuffleCards(ref int[] deck)
        {
            Random r = new Random(DateTime.Now.Millisecond);
            for (int n = deck.Length - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                int temp = deck[n];
                deck[n] = deck[k];
                deck[k] = temp;
            }
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
