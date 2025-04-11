using BethanysPieShopHRM.HR;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShopHRM
{
    public class Utilities
    {
        private static string directory = Path.Combine(Environment.CurrentDirectory, "data");

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
            string path = $"{directory}{fileName}";
            bool existingFileFound = File.Exists(path);

            if (existingFileFound)
            {
                Console.WriteLine("An existing file was found");
            }
            else
            {
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Directory is ready for saving files");
                    Console.ResetColor();

                }
            }
        }
        internal static void ViewAllEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                Console.WriteLine($"Employees ({employees.Count}):");
                employees[i].DisplayEmployeeDetails();
            }
        }

        internal static void LoadEmployees(List<Employee> employees)
        {
            string path = Path.Combine(directory, fileName);
            if (File.Exists(path))
            {
                employees.Clear();

                string[] employeesAsString = File.ReadAllLines(path);
                for (int i = 0; i < employeesAsString.Length; i++)
                {
                    string[] employeeSplits = employeesAsString[i].Split(";");
                    string firstName = employeeSplits[0].Substring(employeeSplits[0].IndexOf(":") + 1);
                    string lastName = employeeSplits[1].Substring(employeeSplits[1].IndexOf(":") + 1);
                    string email = employeeSplits[2].Substring(employeeSplits[2].IndexOf(":") + 1);
                    DateTime birthDay = DateTime.Parse(employeeSplits[3].Substring(employeeSplits[3].IndexOf(":") + 1));
                    double hourlyRate = double.Parse(employeeSplits[4].Substring(employeeSplits[4].IndexOf(":") + 1));
                    string employeeType = employeeSplits[5].Substring(employeeSplits[5].IndexOf(":") + 1);

                    Employee employee = null;

                    switch (employeeType)

                    {
                        case "1":
                            employee = new Employee(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                        case "2":
                            employee = new Manager(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                        case "3":
                            employee = new StoreManager(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                        case "4":
                            employee = new Researcher(firstName, lastName, email, birthDay, hourlyRate);
                            break;
                        case "5":
                            employee = new JuniorResearcher(firstName, lastName, email, birthDay, hourlyRate);
                            break;

                    }

                    employees.Add(employee);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Loaded {employees.Count} employees!\n\n");
                Console.ResetColor();
            }
        }

        private static string GetEmployeeType(Employee employee)
        {
            if (employee is Manager)
                return "2";
            else if (employee is StoreManager)
                return "3";
            else if (employee is Researcher)
                return "4";
            else if (employee is JuniorResearcher)
                return "5";
            else if (employee is Employee)
                return "1";
            return "0";

        }
        internal static void SaveEmployees(List<Employee> employees)
        {
            string path = Path.Combine(directory, fileName);
            StringBuilder sb = new StringBuilder();
            foreach (Employee employee in employees)
            {
                string type = GetEmployeeType(employee);
                sb.Append($"firstName:{employee.FirstName};");
                sb.Append($"lastName:{employee.LastName};");
                sb.Append($"email:{employee.Email};");
                sb.Append($"Birthday:{employee.Birthday.ToShortDateString()};");
                sb.Append($"hourlyRate:{employee.HourlyRate};");
                sb.Append($"type:{type}");
                sb.Append(Environment.NewLine);
            }
            File.WriteAllText(path, sb.ToString());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Saved employees was successful completed!");
            Console.ResetColor();
        }
    }
}
