using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM.HR
{
    internal struct WorkTask
    {
        public string description;
        public int hours;

        public WorkTask(string description, int hours)
        {
            this.description = description;
            this.hours = hours;
        }

        public void PerformWorkTask()
        {
            Console.WriteLine($"Task {description} of {hours} hours has been performed.");
        }
    }


}
