using Shapes.General;

namespace Shapes.Concrete
{
    public class Rectangle : Polygon
    {
        public Rectangle(int startX, int startY, int width, int height)
        : base(new Point(startX, startY),
            new Point(startX + width, startY),
            new Point(startX + width, startY + height),
            new Point(startX, startY + height))
        {
        }
    }
}
