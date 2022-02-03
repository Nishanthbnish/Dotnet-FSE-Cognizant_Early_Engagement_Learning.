using System;

namespace AbstractFactory
{
    class AudiFactory : Factory
    {
        public override Headlight MakeHeadLight()
        {
            return new AudiHeadlight();
        }

        public override Tire MakeTire()
        {
            return new AudiTire();
        }
    }
}
