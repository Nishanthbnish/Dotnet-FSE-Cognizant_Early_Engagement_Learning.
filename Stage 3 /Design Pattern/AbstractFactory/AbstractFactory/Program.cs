using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "Mercedes";

            var factory = FactoryGetter(type);

            var headlight = factory.MakeHeadLight();
            Console.WriteLine(headlight);

            var tire = factory.MakeTire();
            Console.WriteLine(tire);
        }

        static Factory FactoryGetter(string type)
        {
            if (type == "Mercedes")
            {
                return new MercedesFactory();
            }
            else if (type == "Audi")
            {
                return new AudiFactory();
            }
            else
            {
                return null;
            }
        }
    }
}
