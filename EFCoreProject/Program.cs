using EFCoreProject.Models;

namespace EFCoreProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProjectContext context = new ProjectContext();

            // add data on table employee
            //Employee e1 = new Employee();
            //e1.EmployeeName = "Mohammed";
            //e1.EmployeeSalary = 1000;
            //e1.EmployeeAge = 23;
            //context.Employees.Add(e1);
            //context.SaveChanges();


            // case 1 register employee
            //Console.WriteLine("Register employee");

            //Employee e1 = new Employee();

            //Console.WriteLine("Enter Employee Name");
            //e1.EmployeeName = Console.ReadLine();

            //Console.WriteLine("Enter Employee Salary");
            //e1.EmployeeSalary = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Employee Age");
            //e1.EmployeeAge = Convert.ToInt32(Console.ReadLine());

            //context.Employees.Add(e1);
            //context.SaveChanges();

            // case 2 delete employee
            //Console.WriteLine("enter employee ID to delete");
            //int employeeId = Convert.ToInt32(Console.ReadLine());

            //Employee employee = context.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);
            //if (employee == null)
            //{
            //    Console.WriteLine("Employee not found");
            //}
            //else
            //{
            //    context.Employees.Remove(employee);
            //    context.SaveChanges();
            //    Console.WriteLine("Employee deleted successfully");
            //}

            // case 3 update employee
            Console.WriteLine("enter employee ID to update");
            int employeeIdToUpdate = Convert.ToInt32(Console.ReadLine());

            Employee employeeToUpdate = context.Employees.FirstOrDefault(e => e.EmployeeId == employeeIdToUpdate);
            if (employeeToUpdate == null)
            {
                Console.WriteLine("Employee not found");
            }
            else
            {
                Console.WriteLine("Enter Employee Name");
                employeeToUpdate.EmployeeName = Console.ReadLine();
                Console.WriteLine("Enter Employee Salary");
                employeeToUpdate.EmployeeSalary = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter Employee Age");
                employeeToUpdate.EmployeeAge = Convert.ToInt32(Console.ReadLine());
                context.SaveChanges();
                Console.WriteLine("Employee updated successfully");
            }
        }
    }
}
