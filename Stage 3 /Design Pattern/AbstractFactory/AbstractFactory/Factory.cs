using System;

namespace AbstractFactory
{
    abstract class Factory
    {
        public abstract Headlight MakeHeadLight();

        public abstract Tire MakeTire();
    }
}
