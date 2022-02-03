using System;

namespace AbstractFactoryCaseStudy
{
    class MicroCar : Car
    {
        public MicroCar(CarType carType, Location location)
            : base(CarType.MICRO, location)
        {
            Construct();
        }
        public override void Construct()
        {
            Console.WriteLine("Connecting to micro car");
            Console.WriteLine(base.ToString());
        }
    }
}
