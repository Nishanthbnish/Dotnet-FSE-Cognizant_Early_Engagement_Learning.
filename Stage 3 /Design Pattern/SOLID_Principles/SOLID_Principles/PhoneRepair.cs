using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class PhoneRepair : IPhoneRepair
    {
        public void ProcessPhoneRepair(string modelName)
        {
            Console.WriteLine($"{modelName} repair accepted!");
        }
    }
}
