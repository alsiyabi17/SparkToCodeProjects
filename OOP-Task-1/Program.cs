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
        static BankAccount account2 = new BankAccount { AccountNumber = 2, HolderName = "Ali", Balance = 1000 };

        static Student student1 = new Student { Name = "Mohammed", Address = "Muscat", Grade = 65 };
        static Student student2 = new Student { Name = "omar", Address = "Muscat", Grade = 70 };

        static Product product1 = new Product { ProductName = "Laptop", Price = 5.500, StockQuantity = 10 };
        static Product product2 = new Product { ProductName = "Mobile", Price = 70.500, StockQuantity = 20 };

        static void Main(string[] args)
        {

            bool exitApp = false;

            while (exitApp == false)
            {
                Console.WriteLine("\n===== OOP Part 1 - Bank / Student / Product Manager =====");
                Console.WriteLine(" 1. View Account Details");
                Console.WriteLine(" 2. Update Student Address");
                Console.WriteLine(" 3. Make a Deposit");
                Console.WriteLine(" 4. Make a Withdrawal");
                Console.WriteLine(" 5. View Product Details");
                Console.WriteLine(" 6. Register a Student");
                Console.WriteLine(" 7. Compare Two Account Balances");
                Console.WriteLine(" 8. Restock Product & Stock Level Check");
                Console.WriteLine(" 9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade (Validated)");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening (Parameterized Constructor)");
                Console.WriteLine("17. Total Students Counter (Static Field & Method)");
                Console.WriteLine("18. Overdrawn Account Check (Read-Only Property)");
                Console.WriteLine("19. Set Student Security PIN (Write-Only Property)");
                Console.WriteLine("20. Exit");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 20.");
                    continue;
                }

                switch (choice)
                {
                    case 1: ViewAccountDetails(); break;
                    case 2: UpdateStudentAddress(); break;
                    case 3: MakeDeposit(); break;
                    case 4: MakeWithdrawal(); break;
                    case 5: ViewProductDetails(); break;
                    case 6: RegisterStudent(); break;
                    case 7: CompareAccountBalances(); break;
                    case 8: RestockProduct(); break;
                    case 9: TransferBetweenAccounts(); break;
                    case 10: UpdateStudentGrade(); break;
                    case 11: StudentReportCard(); break;
                    case 12: AccountHealthStatus(); break;
                    case 13: BulkSaleWithRevenue(); break;
                    case 14: ScholarshipEligibilityCheck(); break;
                    case 15: FullBalanceTopUpFlow(); break;
                    case 20:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 20.");
                        break;
                }
                if (!exitApp)
                {
                    Console.WriteLine("\nPress Enter to return to the menu...");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }

        static BankAccount ChooseAccount()
        {
            Console.WriteLine("Choose an account:");
            Console.WriteLine("1. " + account1.HolderName);
            Console.WriteLine("2. " + account2.HolderName);
            int choice = int.Parse(Console.ReadLine());
            return choice == 1 ? account1 : account2;
        }

        static Student ChooseStudent()
        {
            Console.WriteLine("Choose a student:");
            Console.WriteLine("1. " + student1.Name);
            Console.WriteLine("2. " + student2.Name);
            int choice = int.Parse(Console.ReadLine());
            return choice == 1 ? student1 : student2;
        }

        static Product ChooseProduct()
        {
            Console.WriteLine("Choose a product:");
            Console.WriteLine("1. " + product1.ProductName);
            Console.WriteLine("2. " + product2.ProductName);
            int choice = int.Parse(Console.ReadLine());
            return choice == 1 ? product1 : product2;
        }

        // Case 1
        static void ViewAccountDetails()
        {
            BankAccount account = ChooseAccount();
            account.CheckBalance();
        }

        // Case 2
        static void UpdateStudentAddress()
        {
            Student student = ChooseStudent();
            Console.WriteLine("Enter new Address: ");
            student.Address = Console.ReadLine();
            Console.WriteLine("Address is successfully updated to " + student.Address);
        }
        // Case 3
        static void MakeDeposit()
        {
            BankAccount account = ChooseAccount();
            Console.WriteLine("Enter the amount that you want to deposit: ");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
            Console.WriteLine("Card holder's name: " + account.HolderName);
            Console.WriteLine("Updated Balance after the deposit: " + account.Balance);
        }
        // Case 4
        static void MakeWithdrawal()
        {
            BankAccount account = ChooseAccount();
            Console.WriteLine("Enter the amount that you want to withdraw: ");
            double amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
            Console.WriteLine("Updated Balance after the Withdrawal: " + account.Balance);
        }
        // Case 5
        static void ViewProductDetails()
        {
            Product product = ChooseProduct();
            Console.WriteLine("Total Inventory Value: " + product.GetInventoryValue());
        }

        // Case 6
        static void RegisterStudent()
        {
            Student student = ChooseStudent();
            Console.WriteLine("Enter your Email: ");
            string email = Console.ReadLine();
            student.Register(email);
            Console.WriteLine("you have registered successfully. your email will not be revealed anywhere");
        }
        // Case 7
        static void CompareAccountBalances()
        {
            double account1Balance = account1.Balance;
            double account2Balance = account2.Balance;
            if (account1Balance > account2Balance)
            {
                Console.WriteLine("Bank account 1 holds more money than Bank account 2");
            }
            else if (account2Balance > account1Balance)
            {
                Console.WriteLine("Bank account 2 holds more money than Bank account 1");
            }
            else
            {
                Console.WriteLine("Bank account 1 and 2 hold equal amount of money");
            }
        }
        // Case 8
        static void RestockProduct()
        {
            Product product = ChooseProduct();
            Console.WriteLine("Enter the quantity of product you want to restock: ");
            int quantity = int.Parse(Console.ReadLine());
            product.Restock(quantity);

            int stockQuantity = product.StockQuantity;
            if (stockQuantity < 10 && stockQuantity >= 0)
            {
                Console.WriteLine("Stock level is low");
            }
            else if (stockQuantity >= 10 && stockQuantity <= 49)
            {
                Console.WriteLine("Stock level is moderate");
            }
            else
            {
                Console.WriteLine("Stock level is well stocked");
            }
        }
        // Case 9
        static void TransferBetweenAccounts()
        {
            Console.WriteLine(" you will choose your source and destination account ");

            Console.WriteLine("Source =>");
            BankAccount source = ChooseAccount();

            Console.WriteLine("destination =>");
            BankAccount destination = ChooseAccount();

            Console.WriteLine("Enter the amount you want to transfer: ");
            double amount = double.Parse(Console.ReadLine());

            if (source.Balance >= amount)
            {
                source.Withdraw(amount);
                destination.Deposit(amount);
            }
            else
            {
                Console.WriteLine("insufficient balance");
            }
        }
        // Case 10
        static void UpdateStudentGrade()
        {
            try
            {
                Student student = ChooseStudent();

                Console.WriteLine("Enter the new Grade: ");
                int grade = int.Parse(Console.ReadLine());

                if (grade >= 0 && grade <= 100)
                {
                    student.Grade = grade;
                    Console.WriteLine("Grade successfully updated");
                }
                else
                {
                    Console.WriteLine("the number you entered is out of the range of (0-100)");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("input must be a whole number");
            }

        }
        // Case 11
        static void StudentReportCard()
        {
            Student student = ChooseStudent();
            Console.WriteLine("### Student Information ###");
            Console.WriteLine("Student Name: " + student.Name);
            Console.WriteLine("Student Address: " + student.Address);
            Console.WriteLine("Student Grade: " + student.Grade);

            if (student.Grade >= 60 && student.Grade <= 100)
            {
                Console.WriteLine("Student " + student.Name + " Passed");
            }
            else if (student.Grade < 60 && student.Grade >= 0)
            {
                Console.WriteLine("Student " + student.Name + " Failed");
            }
            else
            {
                Console.WriteLine("Invalid Grade");
            }
        }
        // Case 12
        static void AccountHealthStatus()
        {
            BankAccount account = ChooseAccount();
            if (account.Balance < 50)
            {
                Console.WriteLine("Bank account has a Low Balance");
            }
            else if (account.Balance >= 50 && account.Balance <= 1000)
            {
                Console.WriteLine("Bank account has a Healthy Balance");
            }
            else
            {
                Console.WriteLine("Bank account has a Premium Balance");
            }
        }

        // Case 13
        static void BulkSaleWithRevenue()
        {
            Product product = ChooseProduct();
            Console.WriteLine("Enter the quantity to sell: ");
            int quantity = int.Parse(Console.ReadLine());
            if (product.StockQuantity >= quantity)
            {
                product.Sell(quantity);
                double revenue = quantity * product.Price;
                Console.WriteLine("Total Revenue = " + revenue);
            }
            else
            {
                Console.WriteLine(Math.Abs(product.StockQuantity - quantity) + " additional units would be needed to fulfill the order");
            }
        }
        // Case 14
        static void ScholarshipEligibilityCheck()
        {
            Student student = ChooseStudent();
            BankAccount account = ChooseAccount();
            if (student.Grade >= 80)
            {
                if (account.Balance >= 100)
                {
                    Console.WriteLine("Eligible for shcolarship");
                }
                else
                {
                    Console.WriteLine("Not Eligible for shcolarship because account balance is not 100 or above");
                }
            }
            else
            {
                Console.WriteLine("Not Eligible for shcolarship because student grade is not 80 or above");
            }
        }

        // Case 15
        static void FullBalanceTopUpFlow()
        {
            BankAccount account = ChooseAccount();
            if (account.Balance >= 50)
            {
                Console.WriteLine("no top-up is needed");
            }
            else
            {
                Console.WriteLine("Balance before deposit the needed amount to reach 100: " + account.Balance);
                double neededBalance = Math.Abs(100 - account.Balance);
                account.Deposit(neededBalance);
                Console.WriteLine("Balance after deposit: " + account.Balance);
            }
        }
        // Case 16
        static void QuickAccountOpening()
        {
            Console.Write("Enter Account Number: ");
            int accountNum = int.Parse(Console.ReadLine());
            Console.Write("Enter Holder Name: ");
            string holderName = Console.ReadLine();
            Console.Write("Enter Starting Balance: ");
            double balance = double.Parse(Console.ReadLine());
            BankAccount B3 = new BankAccount(accountNum, holderName, balance);

            Console.WriteLine("### Newly added Bank Account Info ###");
            Console.WriteLine("Account Number: " + B3.AccountNumber);
            Console.WriteLine("Holder Name: " + B3.HolderName);
            Console.WriteLine("Balance: " + B3.Balance);
        }
        // Case 17
        static void TotalStudentsCounter()
        {
            Console.WriteLine("Number of student objects created  = " + Student.CountStudentObjects());
        }
        // Case 18
        static void OverdrawnAccountCheck()
        {
            BankAccount account = ChooseAccount();
            Console.WriteLine("### Account Status ###");
            Console.WriteLine("Holder Name: " + account.HolderName);
            Console.WriteLine("Balance: " + account.Balance);
            if (account.isOverdrawn)
            {
                Console.WriteLine("Warning: This account is CURRENTLY OVERDRAWN!");
            }
            else
            {
                Console.WriteLine("Status: Account is in good standing.");
            }
        }
        // Case 19
        static void SetStudentSecurityPin()
        {
            Student student = ChooseStudent();
            Console.WriteLine("Enter your security PIN: ");
            string PIN = Console.ReadLine();
            student.pin = PIN;
            Console.WriteLine("The PIN for " + student.Name + " has been securely updated.");
        }
    }

}