using System;

namespace Adapter
{
    public class MovableAdapterImpl : MovableAdapter
    {
        private Movable _luxuryCar;

        public MovableAdapterImpl(Movable luxuryCar)
        {
            _luxuryCar = luxuryCar;
        }

        public double GetPrice()
        {
            return ConvertUSDtoEuro(_luxuryCar.GetPrice());
        }

        public double GetSpeed()
        {
            return ConvertMPHtoKPH(_luxuryCar.GetSpeed());
        }

        private double ConvertMPHtoKPH(double mph)
        {
            return mph * 1.60934;
        }

        private double ConvertUSDtoEuro(double usd)
        {
            return usd * 1.19;
        }
    }
}
