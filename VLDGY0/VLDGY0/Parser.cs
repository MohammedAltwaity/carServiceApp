using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VLDGY0
{
    internal class Parser
    {

        public Work Parse(string[] columns)
        {

            string name = columns[0];
            int requiredMinutes = int.Parse(columns[1]);
            decimal materialCost = int.Parse(columns[2]);
            return new Work(name, requiredMinutes, materialCost);
        }
    }
}
