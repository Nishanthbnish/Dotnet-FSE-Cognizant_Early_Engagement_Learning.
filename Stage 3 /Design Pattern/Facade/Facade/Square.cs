using System;

namespace Facade
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Draw Square");
        }
    }
}
