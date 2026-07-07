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
        //static double CalculateArea(double length, double width)
        //{
        //    return length * width;
        //}
        //static double CalculatePerimeter(double length, double width)
        //{
        //    return 2 * (length + width);
        //}
        // -----------------------------------------------------
        // for task 7
        //static string GetGradeLetter(int score)
        //{
        //    if (score >= 90)
        //    {
        //        return "A";
        //    }
        //    else if (score >= 80)
        //    {
        //        return "B";
        //    }
        //    else if (score >= 70)
        //    {
        //        return "C";
        //    }
        //    else if (score >= 60)
        //    {
        //        return "D";
        //    }
        //    else
        //    {
        //        return "F";
        //    }
        //}
        // -----------------------------------------------------
        // for task 8
        //static void Countdown(int start)
        //{
        //    for (int i = start; i >= 1; i--)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}
        // -----------------------------------------------------
        // for task 9
        //static int Multiply(int a, int b)
        //{
        //    return a * b;
        //}
        //static double Multiply(double a, double b)
        //{
        //    return a * b;
        //}
        //static int Multiply(int a, int b, int c)
        //{
        //    return a * b * c;
        //}
        // -----------------------------------------------------
        // for task 10
        // Overload 1: Calculate area of a square
        //static double CalculateArea(double side)
        //{
        //    return side * side;
        //}
        //static double CalculateArea(double length, double width)
        //{
        //    return length * width;
        //}
        //-----------------------------------------------------
        // for task 11
        //static double Add(double num1, double num2)
        //{
        //    return num1 + num2;
        //}

        //static double Subtract(double num1, double num2)
        //{
        //    return num1 - num2;
        //}

        //static double MultiplyNumbers(double num1, double num2)
        //{
        //    return num1 * num2;
        //}
        //static double DivideNumbers(double num1, double num2)
        //{
        //    try
        //    {
        //        if (num2 == 0)
        //        {
        //            throw new DivideByZeroException();
        //        }

        //        return num1 / num2;
        //    }
        //    catch (DivideByZeroException)
        //    {
        //        Console.WriteLine("Cannot divide by zero.");
        //        return 0;
        //    }
        //}
        //static void DisplayResult(string operation, double result)
        //{
        //    Console.WriteLine(operation + " Result: " + result);
        //}
        // -----------------------------------------------------
        // for task 12
        // Function to calculate the average
        // Function to calculate the average
        static double CalculateAverage(double score1, double score2, double score3)
        {
            return (score1 + score2 + score3) / 3;
        }
        static string GetGradeLetter(double average)
        {
            if (average >= 90)
            {
                return "A";
            }
            else if (average >= 80)
            {
                return "B";
            }
            else if (average >= 70)
            {
                return "C";
            }
            else if (average >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
        static void PrintReportCard(string name, double average, string grade)
        {
            Console.WriteLine("Student Report Card");
            Console.WriteLine("Student Name : " + name);
            Console.WriteLine("Average : " + average);
            Console.WriteLine("Grade : " + grade);
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
                //Console.Write("Enter the length: ");
                //double length = double.Parse(Console.ReadLine());

                //Console.Write("Enter the width: ");
                //double width = double.Parse(Console.ReadLine());

                //double area = CalculateArea(length, width);
                //double perimeter = CalculatePerimeter(length, width);

                //Console.WriteLine("Area: " + area);
                //Console.WriteLine("Perimeter: " + perimeter);

                // --------------------------------------
                // Task 7 - Grade Letter Function
                //Console.Write("Enter your score: ");
                //int score = int.Parse(Console.ReadLine());
                //string grade = GetGradeLetter(score);
                //Console.WriteLine("Grade: " + grade);

                // --------------------------------------
                // Task 8 - Countdown Function
                //Console.Write("Enter a starting number: ");
                //int start = int.Parse(Console.ReadLine());

                //Countdown(start);

                // --------------------------------------
                // Task 9 - Overloaded Multiply Function
                //int result1 = Multiply(5, 4);
                //double result2 = Multiply(2.5, 3.2);
                //int result3 = Multiply(2, 3, 4);

                //Console.WriteLine("Multiply(int, int): " + result1);
                //Console.WriteLine("Multiply(double, double): " + result2);
                //Console.WriteLine("Multiply(int, int, int): " + result3);

                // --------------------------------------
                // Task 10 - Overloaded Area Calculator
                //Console.WriteLine("Choose a shape:");
                //Console.WriteLine("1. Square");
                //Console.WriteLine("2. Rectangle");
                //Console.Write("Enter your choice: ");

                //int choice = int.Parse(Console.ReadLine());

                //if (choice == 1)
                //{
                //    Console.Write("Enter the side of the square: ");
                //    double side = double.Parse(Console.ReadLine());

                //    double area = CalculateArea(side);

                //    Console.WriteLine("Square Area: " + area);
                //}
                //else if (choice == 2)
                //{
                //    Console.Write("Enter the length of the rectangle: ");
                //    double length = double.Parse(Console.ReadLine());

                //    Console.Write("Enter the width of the rectangle: ");
                //    double width = double.Parse(Console.ReadLine());

                //    double area = CalculateArea(length, width);

                //    Console.WriteLine("Rectangle Area: " + area);
                //}
                //else
                //{
                //    Console.WriteLine("Invalid choice");
                //}

                // --------------------------------------
                // Task 11 - Function-Based Calculator
                //bool running = true;

                //while (running)
                //{
                //    Console.WriteLine("\nCalculator Menu");
                //    Console.WriteLine("1. Add");
                //    Console.WriteLine("2. Subtract");
                //    Console.WriteLine("3. Multiply");
                //    Console.WriteLine("4. Divide");
                //    Console.WriteLine("5. Exit");
                //    Console.Write("Choose an operation: ");

                //    int choice = int.Parse(Console.ReadLine());

                //    if (choice == 5)
                //    {
                //        running = false;
                //        Console.WriteLine("Calculator exited.");
                //        break;
                //    }

                //    Console.Write("Enter first number: ");
                //    double num1 = double.Parse(Console.ReadLine());

                //    Console.Write("Enter second number: ");
                //    double num2 = double.Parse(Console.ReadLine());

                //    double result = 0;
                //    string operation = "";

                //    switch (choice)
                //    {
                //        case 1:
                //            result = Add(num1, num2);
                //            operation = "Addition";
                //            break;

                //        case 2:
                //            result = Subtract(num1, num2);
                //            operation = "Subtraction";
                //            break;

                //        case 3:
                //            result = MultiplyNumbers(num1, num2);
                //            operation = "Multiplication";
                //            break;

                //        case 4:
                //            result = DivideNumbers(num1, num2);
                //            operation = "Division";
                //            break;

                //        default:
                //            Console.WriteLine("Invalid choice.");
                //            continue;
                //    }

                //    DisplayResult(operation, result);
                //}

                // --------------------------------------
                // Task 12 - Student Report Card Generator
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                Console.Write("Enter score for Subject 1: ");
                double score1 = double.Parse(Console.ReadLine());

                Console.Write("Enter score for Subject 2: ");
                double score2 = double.Parse(Console.ReadLine());

                Console.Write("Enter score for Subject 3: ");
                double score3 = double.Parse(Console.ReadLine());

                double average = CalculateAverage(score1, score2, score3);

                string grade = GetGradeLetter(average);

                PrintReportCard(name, average, grade);
        }
    }
}
