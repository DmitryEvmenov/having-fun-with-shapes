using System.Collections.Generic;

namespace Shapes
{
    public abstract class Shape
    {
        public List<Point> Points { get; }

        protected Shape(List<Point> points)
        {
            Points = points;
        }
    }
}
