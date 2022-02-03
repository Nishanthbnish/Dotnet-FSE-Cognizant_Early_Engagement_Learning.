using System;

namespace Builder
{
    class ChildPackageBuilder : Builder
    {
        private Package _product = new Package();

        public override void BuildSweet()
        {
            _product.AddSweet(2);
        }

        public override void BuildSavory()
        {
            _product.AddSavory(1);
        }

        public override Package GetResult()
        {
            return _product;
        }
    }
}