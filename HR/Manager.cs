using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class Manager : Employee
    {
        public Manager(string firstName, string lastName, string email, DateTime birthDate, double hourlyRate) : base(firstName, lastName, email, birthDate, hourlyRate)
        {
        }

        public void AttendManagementMeeting() {
            NumberOfHoursWorked += 10;
            Console.WriteLine($"Manager {FirstName} is now attending a long meeting");
            
        }
    }
}
