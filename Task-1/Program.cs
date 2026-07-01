namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            string Name = "Mohammed";
            int Age = 23;
            double hight = 175;
            bool student = true;

            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(hight);
            Console.WriteLine(student);

            // Task 2
            Console.WriteLine("Enter the length");
            float length = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the width");
            float width = float.Parse(Console.ReadLine());

            float Area = length * width;
            float Perimeter = 2 * (length + width);

            Console.WriteLine("Area: " + Area);
            Console.WriteLine("Perimeter: " + Perimeter);
        }
    }
}
