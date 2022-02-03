using System;

namespace Builder
{
    class SweetShop
    {
        public void Construct(Builder builder)
        {
            builder.BuildSweet();
            builder.BuildSavory();
        }
    }
}