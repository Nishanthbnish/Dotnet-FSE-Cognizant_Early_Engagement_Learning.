using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class AccessoryRepair : IAccessoryRepair
    {
        public void ProcessAccessoryRepair(string accessoryType)
        {
            Console.WriteLine($"{accessoryType} reapir accepted!");
        }
    }
}
