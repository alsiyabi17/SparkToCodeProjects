namespace CsharpPart1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Please Enter Your Name :");
            //string UserName = Console.ReadLine();

            //Console.WriteLine("Please Enter Your Age :");
            //int UserAge = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter your salary : ");
            //float UserSalary = float.Parse(Console.ReadLine());

            //Console.WriteLine("Hello My Name is " + UserName + ", And my age is " + UserAge + ", And my Salary is " + UserSalary);


            //Console.WriteLine("enter first number");
            //float Firstnumber = float.Parse(Console.ReadLine());

            //Console.WriteLine("enter first number");
            //float SecoundNumber = float.Parse(Console.ReadLine());

            //float AdditionResult = Firstnumber + SecoundNumber;
            //float SubtractionResult = Firstnumber - SecoundNumber;
            //float MultiplicationResult = Firstnumber * SecoundNumber;
            //float DivisionResult = Firstnumber / SecoundNumber;
            //float ReminderResult = Firstnumber % SecoundNumber;
            //bool ComparisonResult = Firstnumber == SecoundNumber;

            //// And : &&
            //// OR : ||
            //// Not : |

            //Console.WriteLine("Addition Result : " + AdditionResult);
            //Console.WriteLine("Subtraction Result : " + SubtractionResult);
            //Console.WriteLine("Multiplication Result : " + MultiplicationResult);
            //Console.WriteLine("Division Result : " + DivisionResult);
            //Console.WriteLine("Reminder Result : " + AdditionResult);
            //Console.WriteLine("Comparison Result : " + ComparisonResult);
            ///////////////////////////////////////////////////////////////////

            // if-Statement
            //Console.WriteLine("Enter your degree: ");
            //float degree = float.Parse(Console.ReadLine());

            //if(degree < 50)
            //{
            //    Console.WriteLine("Failed");
            //}
            //else if(degree >= 50 && degree < 60)
            //{
            //    Console.WriteLine("Passed with grade D");
            //}
            //else if(degree >= 60 && degree < 70)
            //{
            //    Console.WriteLine("Passed with grade C");
            //}
            //else if (degree >= 70 && degree < 80)
            //{
            //    Console.WriteLine("Passed with grade B");
            //}
            //else if (degree >= 80)
            //{
            //    Console.WriteLine("Passed with grade A");
            //}
            //else
            //{
            //    Console.WriteLine("Number not vaild");
            //}
            ///////////////////////////////////////////////////////////////////


            Console.WriteLine("welcome to main menu:");
            Console.WriteLine("1.Deposite");
            Console.WriteLine("2.Withdraw");
            Console.WriteLine("3.Balance check");

            Console.WriteLine("please choose an option: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("deposited");
                    break;


                case 2:
                    Console.WriteLine("withdrawed");
                    break;


                case 3:
                    Console.WriteLine("your balance = ");
                    break;

                default:
                    Console.WriteLine("please choose a correct option");
                    break;
            }
            
        }
    }
}
