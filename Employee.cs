using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM
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

        public Employee(string first, string last, string em, DateTime bd) : this(first, last, em, bd, 0)
        {
        }

        public Employee(string first, string last, string em, DateTime bd, double rate)
        {
            firstName = first;
            lastName = last;
            email = em;
            birthday = bd;
            hourlyRate = rate;

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

        public double ReceiveWage(bool resetHours = true)
        {
            wage = numberOfHoursWorked * hourlyRate;

            Console.WriteLine($"{firstName} has received a wage of {wage} fro {numberOfHoursWorked} hours of work");

            if (resetHours)
                numberOfHoursWorked = 0;

            return wage;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine($"\nFirst name: {firstName}\nLast name: {lastName}\nEmail: {email}\nBirthday: {birthday.ToShortDateString()}");
        }

    }
}
