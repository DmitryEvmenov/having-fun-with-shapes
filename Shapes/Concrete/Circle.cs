using System.Collections.Generic;
using Shapes.Abstract;
using Shapes.General;

namespace Shapes.Concrete
{
    public class Circle : Polyline, ICustomDrawable
    {
        public int Radius { get; }

        public Circle(int centerX, int centerY, int radius)
        : base(new Point(centerX, centerY))
        {
            Radius = radius;
        }

        public virtual IDictionary<string, object> CustomDrawObjects =>
            new Dictionary<string, object> {{nameof(Radius), Radius}};
    }
}
