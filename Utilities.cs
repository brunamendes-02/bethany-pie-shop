using BethanysPieShopHRM.HR;
using System.Collections.Generic;

namespace BethanysPieShopHRM
{
    public class Utilities
    {
        private static string directory = @"D:\data\BethanysPieShopHRM\";
        private static string fileName = "employees.txt";

        internal static void RegisterEmployee(List<Employee> employees)
        {
            Console.WriteLine("Creating an Employee");
            Console.WriteLine("What type of employee do you want to register?");
            Console.WriteLine("\n1. Employee\n2. Manager\n3. Store Manager\n4. Researcher\n5. Junior Researcher");
            string employeeType = Console.ReadLine();

            if (employeeType != "1" && employeeType != "2" && employeeType != "3" && employeeType != "4" && employeeType != "5")
            {
                Console.WriteLine("Invalid selection!");
                return;
            }

            Console.WriteLine("Enter the first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter the last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter the email:");
            string email = Console.ReadLine();

            Console.WriteLine("Enter the birth date:");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the hourly rate:");
            string hourlyRate = Console.ReadLine();
            double rate = double.Parse(hourlyRate);


            Employee employee = null;
            switch (employeeType)
            {
                case "1":
                    employee = new Employee(firstName, lastName, email, birthDate, rate);
                    break;
                case "2":
                    employee = new Manager(firstName, lastName, email, birthDate, rate);
                    break;
                case "3":
                    employee = new StoreManager(firstName, lastName, email, birthDate, rate);
                    break;
                case "4":
                    employee = new Researcher(firstName, lastName, email, birthDate, rate);
                    break;
                case "5":
                    employee = new JuniorResearcher(firstName, lastName, email, birthDate, rate);
                    break;
            }

            employees.Add(employee);
            Console.WriteLine("Employee created!");
        }

        internal static void CheckForExistingEmployeeFile()
        {
            // Lógica para verificar se o arquivo de funcionários existe
        }

        internal static void ViewAllEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine("Employees " + employees);

                employees[i].DisplayEmployeeDetails();
            }
        }

        internal static void LoadEmployees(List<Employee> employees)
        {
            // Lógica para carregar os dados dos funcionários do arquivo
        }

        internal static void SaveEmployees(List<Employee> employees)
        {
            // Lógica para salvar os dados dos funcionários no arquivo
        }
    }
}
