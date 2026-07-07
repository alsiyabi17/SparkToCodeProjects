namespace Task_4
{
    internal class Program
    {
        // For task 1
        //static void PrintWelcome(string name)
        //{
        //    Console.WriteLine("Welcome, " + name + "!");
        //    Console.WriteLine("We're glad to have you here.");
        //}
        // -----------------------------------------------------
        // For task 2
        //static int Square(int number)
        //{
        //    return number * number;
        //}
        // -----------------------------------------------------
        // for task 3
        //static double CelsiusToFahrenheit(double celsius)
        //{
        //    return (celsius * 9 / 5) + 32;
        //}
        // -----------------------------------------------------
        // For task 4
        //static void DisplayMenu()
        //{
        //    Console.WriteLine("MENU ");
        //    Console.WriteLine("1. Start");
        //    Console.WriteLine("2. Help");
        //    Console.WriteLine("3. Exit");
        //}
        // -----------------------------------------------------
        // For task 5
        //static bool IsEven(int number)
        //{
        //    return number % 2 == 0;
        //}
        // -----------------------------------------------------
        // For task 6
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }
        static double CalculatePerimeter(double length, double width)
        {
            return 2 * (length + width);
        }

        static void Main(string[] args)
        {
            // Task 1 - Personalized Welcome Function
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();

            //PrintWelcome(name);
            // ---------------------------------------
            // Task 2 - Square Number Function 
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //int result = Square(number);

            //Console.WriteLine("The square is: " + result);
            // ---------------------------------------
            // Task 3 - Celsius to Fahrenheit Function
            //Console.Write("Enter the temperature in Celsius: ");
            //double celsius = double.Parse(Console.ReadLine());

            //double fahrenheit = CelsiusToFahrenheit(celsius);
            //Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
            // ---------------------------------------
            // Task 4 - Fixed Menu Display Function
            //DisplayMenu();
            // --------------------------------------

            // Task 5 - Even or Odd Function
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());

            //if (IsEven(number))
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            // --------------------------------------
            // Task 6 - Rectangle Area & Perimeter Functions
            Console.Write("Enter the length: ");
            double length = double.Parse(Console.ReadLine());

            Console.Write("Enter the width: ");
            double width = double.Parse(Console.ReadLine());

            double area = CalculateArea(length, width);
            double perimeter = CalculatePerimeter(length, width);

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Perimeter: " + perimeter);
        }
    }
}
