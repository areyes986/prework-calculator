using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator! Press ENTER to continue: ");
            Console.ReadLine();
            ShowMenu();
        }

        // ShowMenu() displays menu options for users to choose from and calls the methods. 
        private static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Press 1 for ADDITION");
            Console.WriteLine("Press 2 for SUBTRACTION");
            Console.WriteLine("Press 3 to MULTIPY");
            Console.WriteLine("Press 4 to DIVIDE");
           
            string userInput = Console.ReadLine();

            // User is instructed to enter first and second value.
            Console.Clear();
            Console.Write("first value: ");
            int x = int.Parse(Console.ReadLine());
       
            Console.Write("second value: ");
            int y = int.Parse(Console.ReadLine());

            if (userInput == "1")
            { 
                Add(x, y);
            }
            else if (userInput == "2")
            {
                Sub(x, y);
            }
            else if (userInput == "3")
            {
                Multiply(x, y);
            }
            else if (userInput == "4")
            {
                Divide(x, y);
            }
            else
            {
                Console.WriteLine("That was not a valid response!");
            }
            // User is asked to try again if they want after their problem has been solved. 
            Console.Write("Do you want to try again? yes or no pls: ");
            string again = Console.ReadLine();
            if (again == "yes")
            {
                ShowMenu();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        // These methods will either add, subtract, multipy, or divide the user inputs of x or y
        private static void Add(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("Awesome! " + x + " + " + y + " = " + sum);
        }

        private static void Sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("Awesome! " + x + " - " + y + " = " + sub);
        }

        private static void Multiply(int x, int y)
        {
            int mulitply = x * y;
            Console.WriteLine("Awesome! " + x + " * " + y + " = " + mulitply);
        }

        private static void Divide(int x, int y)
        {
            int divide = x/y;
            Console.WriteLine("Awesome! " + x + " % " + y + " = " + divide);
        }
    }
}