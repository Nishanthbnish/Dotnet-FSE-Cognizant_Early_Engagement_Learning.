using System;

namespace Builder
{
    public class Program
    {
        public static void Main()
        {
            var shop = new SweetShop();

            var childPackageBuilder = new ChildPackageBuilder();
            var adultPackageBuilder = new AdultPackageBuilder();

            shop.Construct(childPackageBuilder);
            var childPackage = childPackageBuilder.GetResult();
            childPackage.Show();

            shop.Construct(adultPackageBuilder);
            var adultPackage = adultPackageBuilder.GetResult();
            adultPackage.Show();
        }
    }
}