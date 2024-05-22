using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLDGY0
{
    internal class Work
    {

        //private fields
        private readonly string name;
        private readonly int requiredTimeMinutes;
        private readonly decimal materialCosts;

     
        public string Name { get { return name; } }
        public int RequiredTimeMinutes { get { return requiredTimeMinutes; } }
        public decimal MaterialCosts { get { return materialCosts; } }

      
        public Work(string name, int requiredTimeMinutes, decimal materialCosts)
        {
            this.name = name;
            this.requiredTimeMinutes = requiredTimeMinutes;
            this.materialCosts = materialCosts;
        }




        //  calculate the total service time in minutes
        public int TotalServiceTimeMinutes => RequiredTimeMinutes;

        //  calculate the total service time in hours
        public int TotalServiceTimeHours => TotalServiceTimeMinutes / 60;

        //  calculate the remaining minutes after calculating hours
        public int RemainingServiceTimeMinutes => TotalServiceTimeMinutes % 60;


    }

     
}
