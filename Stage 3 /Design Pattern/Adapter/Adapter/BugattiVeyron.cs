using System;

namespace Adapter
{
    public class BugattiVeyron : Movable
    {
        public double GetPrice()
        {
            return 1500000;
        }

        public double GetSpeed()
        {
            return 268;
        }
    }
}
