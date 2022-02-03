using System;

namespace AbstractFactory
{
    class MercedesFactory : Factory
    {
        public override Headlight MakeHeadLight()
        {
            return new MercedesHeadlight();
        }

        public override Tire MakeTire()
        {
            return new MercedesTire();
        }
    }
}
