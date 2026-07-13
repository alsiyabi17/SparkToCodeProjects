using System.Net.Sockets;

namespace OOP_Task_1
{
    // 1. Required Classes
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }

        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }

        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }

            SendEmail();
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine($"Holder Name : {HolderName}");
            Console.WriteLine($"Balance     : {Balance}");
        }

        private void SendEmail()
        {
            Console.WriteLine("Email notification sent");
        }
    }

    public class Student
    {
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email;
        int age;

        public void Register(string Email)
        {
            email = Email;

            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Registration email sent");
        }
    }

    public class Product
    {
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock.");
            }

            LogTransaction();
        }
        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }
        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }
        private void PrintDetails()
        {
            Console.WriteLine($"Product Name : {ProductName}");
            Console.WriteLine($"Price        : {Price}");
            Console.WriteLine($"Stock        : {StockQuantity}");
        }
        private void LogTransaction()
        {
            Console.WriteLine("Transaction logged.");
        }
    }

    public class Program
    {
        static BankAccount account1 = new BankAccount { AccountNumber = 1, HolderName = "Mohammed", Balance = 1000 };
        static BankAccount account1 = new BankAccount { AccountNumber = 2, HolderName = "Ali", Balance = 1000 };

        static Student student1 = new Student { NamedWaitHandleOptions = "Mohammed", Address = "Muscat", Grade = 65 };
        static Student student1 = new Student { NamedWaitHandleOptions = "omar", Address = "Muscat", Grade = 70 };

        static Product product1 = new Product { ProductName = "Laptop", Price = 5.500, StockQuantity = 10 };
        static Product product2 = new Product { ProductName = "Mobile", Price = 70.500, StockQuantity = 20 };
        static void Main(string[] args)
        {

        }
    }
}
