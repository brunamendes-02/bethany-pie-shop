using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.Accounting
{
    internal record Account
    {
        private string accountNumber;

        public Account(string accountNumber)
        {
            this.accountNumber = accountNumber;
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set
            {
                accountNumber = value;
            }
        }

    }
    // public record Account(string AccountNumber);
}
