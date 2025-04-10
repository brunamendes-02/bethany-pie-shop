using System;

namespace BethanysPieShopHRM.HR
{
    internal class Employee: IEmployee
    {
        private string firstName;
        private string lastName;
        private string email;
        private int numberOfHoursWorked;
        private double wage;
        private double hourlyRate;
        private DateTime birthday;
        private Address address;
        private const int minimalHoursWorded = 1;
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
            protected set { numberOfHoursWorked = value; }
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
                if (value < 0) { hourlyRate = 0; } else { hourlyRate = value; }
            }
        }

        public DateTime Birthday
        {
            get { return birthday; }
            set { birthday = value; }
        }

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public Employee(string firstName, string lastName, string email, DateTime birthDate, double hourlyRate = 0)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Birthday = birthDate;
            HourlyRate = hourlyRate;
        }


        public Employee(string firstName, string lastName, string email, DateTime birthDate, double hourlyRate, string street, string houseNumber, string zipCode, string city)
            : this(firstName, lastName, email, birthDate, hourlyRate)
        {
            Address = new Address(street, houseNumber, zipCode, city);
        }

        public void PerformWork()
        {
            PerformWork(minimalHoursWorded);
        }

        public void PerformWork(int numberOfHours)
        {
            NumberOfHoursWorked += numberOfHours;
            Console.WriteLine($"{FirstName} has worked for {numberOfHours} hours");
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

        public virtual void GiveBonus() {
            Console.WriteLine($"{FirstName} {LastName} received a generic bonus of 100!");
        }

        public double ReceiveWage(bool resetHours = true)
        {
            double wageBeforeTax = NumberOfHoursWorked * HourlyRate;
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

            if (Address != null)
            {
                Console.WriteLine($"Address: {Address.Street}, {Address.HouseNumber}, {Address.ZipCode}, {Address.City}");
            }


        }

        public void GiveCompliment()
        {
            Console.WriteLine($"You've done a great job, {FirstName}!");
        }
    }
}
