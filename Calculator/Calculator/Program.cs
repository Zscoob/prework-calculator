using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu == true)
            {
                displayMenu = MainMenu();
            }

        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option");
            Console.WriteLine("1) Calculator");
            Console.WriteLine("2) Exit");
            string result = Console.ReadLine();
            if (result == "1")
            {
                Calculator();
                return true;

            }
            else if (result == "2")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private static void Calculator()
        {

        Console.WriteLine("Type a number, then press enter");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type a number, then press enter");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an operator");
            Console.WriteLine("\t+ - Addition");
            Console.WriteLine("\t- - Subtraction");
            Console.WriteLine("\t* - Multiplication");
            Console.WriteLine("\t/ - Division");
            Console.Write("What's it gonna be?");
            switch (Console.ReadLine())
            {
                case "+":
                    Console.WriteLine($"{a}+{b} = " + (a + b));
                    break;
                case "-":
                    Console.WriteLine($"{a}-{b} = " + (a - b));
                    break;
                case "*":
                    Console.WriteLine($"{a}*{b} = " + (a * b));
                    break;
                case "/":
                    Console.WriteLine($"{a}/{b} = " + (a / b));
                    break;
            }
            Console.Write("press any key to clear");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
