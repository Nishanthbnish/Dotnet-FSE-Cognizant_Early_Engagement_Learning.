using System;

namespace Builder
{
    abstract class Builder
    {
        public abstract void BuildSweet();

        public abstract void BuildSavory();

        public abstract Package GetResult();
    }
}