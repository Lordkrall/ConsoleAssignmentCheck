using ConsoleAssignmentCheck;
using System;
using System.Text;

namespace Execise4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.Unicode;
            Exercises ex = new Exercises();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("1. Exercise 1 \n2. Exercise 2 \n3. Exercise 3 \n4. Exercise 4 \n" +
               "5. Exercise 5 \n6. Exercise 6 \n7. Exercise 7 \n8. Exercise 8 \n9. Exercise 9 \n10. Exercise 10 \n11. Exercise 11 \n12. Exercise 12 \n" +
               "13. Exercise 13 \n14. Exercise 14 \n15. Exercise 15 \n16. Exercise 16 \n17. Exercise 17 \n18. Exercise 18 \n19. Exercise 19 \n20. Exercise 20" +
               "\n21. Exercise 21 \n22. Exercise 22 \n23. Exercise 23 \nWhich exercise do you want to check? (-1 to exit)");

                bool validNumber = int.TryParse(Console.ReadLine(), out int selection);
                if (!validNumber)
                    selection = 0;

                switch (selection)
                {
                    case 0:
                        Console.Clear();
                        ex.ExerciseSpecial();
                        break;
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
                        Console.Clear();
                        ex.Exercise14();
                        break;
                    case 15:
                        Console.Clear();
                        ex.Exercise15();
                        break;
                    case 16:
                        Console.Clear();
                        ex.Exercise16();
                        break;
                    case 17:
                        Console.Clear();
                        ex.Exercise17();
                        break;
                    case 18:
                        Console.Clear();
                        ex.Exercise18();
                        break;
                    case 19:
                        Console.Clear();
                        ex.Exercise19();
                        break;
                    case 20:
                        Console.Clear();
                        ex.Exercise20();
                        break;
                    case 21:
                        Console.Clear();
                        ex.Exercise21();
                        break;
                    case 22:
                        Console.Clear();
                        ex.Exercise22();
                        break;
                    case 23:
                        Console.Clear();
                        ex.Exercise23();
                        break;
                    case 24:
                        Console.Clear();
                        ex.Exercise24();
                        break;
                    case 25:
                        Console.Clear();
                        ex.Exercise25();
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