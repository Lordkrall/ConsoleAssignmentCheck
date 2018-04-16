using ConsoleAssignmentCheck;
using System;

namespace Execise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercises ex = new Exercises();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Exercise 1 \n2. Exercise 2 \n3. Exercise 3 \n4. Exercise 4 \n" +
               "5. Exercise 5 \n6. Exercise 6 \n7. Exercise 7 \n8. Exercise 8 \n9. Exercise 9 \n10. Exercise 10 \n11. Exercise 11 \n12. Exercise 12 \n" +
               "13. Exercise 13 \nWhich exercise do you want to check? (-1 to exit)");

                bool validNumber = int.TryParse(Console.ReadLine(), out int selection);
                if (!validNumber)
                    selection = 0;

                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        ex.Exercise1();
                        break;
                    case 2:
                        Console.Clear();
                        ex.Exercise2();
                        break;
                    case 3:
                        Console.Clear();
                        ex.Exercise3();
                        break;
                    case 4:
                        Console.Clear();
                        ex.Exercise4();
                        break;
                    case 5:
                        Console.Clear();
                        ex.Exercise5();
                        break;
                    case 6:
                        Console.Clear();
                        ex.Exercise6();
                        break;
                    case 7:
                        Console.Clear();
                        ex.Exercise7();
                        break;
                    case 8:
                        Console.Clear();
                        ex.Exercise8();
                        break;
                    case 9:
                        Console.Clear();
                        ex.Excercise9();
                        break;
                    case 10:
                        Console.Clear();
                        ex.Exercise10();
                        break;
                    case 11:
                        Console.Clear();
                        ex.Exercise11();
                        break;
                    case 12:
                        Console.Clear();
                        ex.Exercise12();
                        break;
                    case 13:
                        Console.Clear();
                        ex.Exercise13();
                        break;
                    case 14:
                        break;
                    case 15:
                        break;
                    case 16:
                        break;
                    case 17:
                        break;
                    case 18:
                        break;
                    case 19:
                        break;
                    case 20:
                        break;
                    case -1:
                        Console.Clear();
                        Console.WriteLine("Thank you for using our program, have a nice day!");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("{0}, is not a valid selection, please try again", selection);
                        break;
                }
            }


        }
    }
}