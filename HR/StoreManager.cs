using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal class StoreManager : Employee
    {
        public StoreManager(string firstName, string lastName, string email, DateTime birthDate, double hourlyRate) : base(firstName, lastName, email, birthDate, hourlyRate)
        {
        }
    }
}
