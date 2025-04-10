using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Employee
    {
        private string firstName;
        private string lastName;
        private string email;
        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;
        private DateTime birthday;
        private const int minimalHoursWorded = 1;
        private EmployeeType employeeType;
        private static double taxRate = 0.15;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public int NumberOfHoursWorked
        {
            get { return numberOfHoursWorked; }
            private set { numberOfHoursWorked = value; }
        }
        public double Wage
        {
            get { return wage; }
            private set { wage = value; }
        }
        public double HourlyRate
        {
            get { return hourlyRate; }
            set
            {
                if (hourlyRate < 0) { hourlyRate = 0; } else { hourlyRate = value; }

            }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }
        public EmployeeType EmployeeType
        {
            get { return employeeType; }
            set { employeeType = value; }
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDate) : this(firstName, lastName, email, birthDate, 0, EmployeeType.StoreManager)
        {
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDate, double hourlyRate, EmployeeType employeeType)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthday = birthDate;
            HourlyRate = hourlyRate;
            EmployeeType = employeeType;
        }
        public void PerformWork()
        {
            PerformWork(minimalHoursWorded);
        }

        public void PerformWork(int numberOfHOurs)
        {
            NumberOfHoursWorked += numberOfHOurs;
            Console.WriteLine($"{FirstName} has worked for {numberOfHOurs} hours");
        }

        public int CalculateBonus(int bonus)
        {
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }


        public int CalculateBonusAndTax(int bonus, int bonusTax)
        {
            if (NumberOfHoursWorked > 10)
                bonus *= 2;

            if (bonus >= 200)
            {
                bonusTax = bonus / 10;
                bonus -= bonusTax;
            }

            Console.WriteLine($"The employee got a bonus of {bonus} and the bonus tax is {bonusTax}");
            return bonus;
        }

        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = 0.0;
            if (EmployeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added since {FirstName} is a manager!");
                Wage = NumberOfHoursWorked * hourlyRate * 1.25;
            }
            else
            {
                Wage = NumberOfHoursWorked * hourlyRate;
            }
            double taxAmount = wageBeforeTax * taxRate;
            Wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{FirstName} has received a wage of {Wage} for {NumberOfHoursWorked} hours of work");

            if (resetHours)
                NumberOfHoursWorked = 0;

            return Wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {FirstName}\nLast name: {LastName}\nEmail: {Email}\nBirthday: {Birthday.ToShortDateString()}\nTax rate: {taxRate}");
        }

    }
}
