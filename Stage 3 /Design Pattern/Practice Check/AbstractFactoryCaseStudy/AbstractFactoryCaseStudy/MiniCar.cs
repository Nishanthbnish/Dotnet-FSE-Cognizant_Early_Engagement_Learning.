using System;

namespace AbstractFactoryCaseStudy
{
    class MiniCar : Car
    {
        public MiniCar(CarType carType, Location location)
            : base(CarType.MINI, location)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to mini car");
            Console.WriteLine(base.ToString());
        }
    }
}
