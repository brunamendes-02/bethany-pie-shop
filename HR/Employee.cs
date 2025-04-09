using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Employee
    {
        public string firstName;
        public string lastName;
        public string email;
        public int numberOfHoursWorked;
        public double wage;
        public double hourlyRate;
        public DateTime birthday;
        const int minimalHoursWorded = 1;
        public EmployeeType employeeType;
        public static double taxRate = 0.15;

        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0, EmployeeType.StoreManager)
        {
        }

        public Employee(string first, string last, string em, DateTime bd, double rate, EmployeeType emType)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthday = bd;
            hourlyRate = rate;
            employeeType = emType;
        }
        public void PerformWork()
        {
            PerformWork(minimalHoursWorded);
            // numberOfHoursWorked++;
            // Console.WriteLine($"{firstName} has worked for {numberOfHoursWorked}");
        }

        public void PerformWork(int numberOfHOurs)
        {
            numberOfHoursWorked += numberOfHOurs;
            Console.WriteLine($"{firstName} has worked for {numberOfHOurs}");
        }

        public int CalculateBonus(int bonus)
        {
            if (numberOfHoursWorked > 10)
                bonus *= 2;

            Console.WriteLine($"The employee got a bonus of {bonus}");
            return bonus;
        }


        public int CalculateBonusAndTax(int bonus, int bonusTax)
        {
            if (numberOfHoursWorked > 10)
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
            if (employeeType == EmployeeType.Manager)
            {
                Console.WriteLine($"An extra was added since {firstName} is a manager!");
                wage = numberOfHoursWorked * hourlyRate * 1.25;
            }
            else
            {
                wage = numberOfHoursWorked * hourlyRate;
            }
            double taxAmount = wageBeforeTax * taxRate;
            wage = wageBeforeTax - taxAmount;

            Console.WriteLine($"{firstName} has received a wage of {wage} for {numberOfHoursWorked} hours of work");

            if (resetHours)
                numberOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {firstName}\nLast name: {lastName}\nEmail: {email}\nBirthday: {birthday.ToShortDateString()}\nTax rate: {taxRate}");
        }

    }
}
