using System.Collections.Generic;
using Shapes.General;

namespace Shapes.Abstract
{
    public abstract class Shape
    {
        public List<Point> Points { get; }

        protected Shape(List<Point> points)
        {
            Points = points;
        }

        public string Name => GetType().Name;
    }
}
