using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class PhoneOrder : IPhoneOrder
    {
        public void ProcessOrder(string modelName)
        {
            Console.WriteLine($"{modelName} order accepted!");
        }
    }
}
