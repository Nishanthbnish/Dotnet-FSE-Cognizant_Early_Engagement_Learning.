using System;

namespace Facade
{
    class ShapeMaker
    {
        private IShape _circle;
        private IShape _square;
        private IShape _rectangle;

        public ShapeMaker()
        {
            _circle = new Circle();
            _square = new Square();
            _rectangle = new Rectangle();
        }

        public void drawCircle()
        {
            _circle.Draw();
        }

        public void drawSquare()
        {
            _square.Draw();
        }
        
        public void drawRectangle()
        {
            _rectangle.Draw();
        }
    }
}
