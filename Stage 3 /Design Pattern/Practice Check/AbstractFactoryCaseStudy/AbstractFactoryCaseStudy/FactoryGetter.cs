using System;

namespace AbstractFactoryCaseStudy
{
    public class FactoryGetter
    {
        public void GetCar(CarType carType, Location location)
        {
            if (carType == CarType.LUXURY)
            {
                var car = new LuxuryCar(carType, location);
            }
            else if (carType == CarType.MICRO)
            {
                var car = new MicroCar(carType, location);
            }
            else if (carType == CarType.MINI)
            {
                var car = new MicroCar(carType, location);
            }
        }
    }
}
