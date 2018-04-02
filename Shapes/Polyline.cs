using System.Linq;

namespace Shapes
{
    public abstract class Polyline : Shape
    {
        protected Polyline(params Point[] points) : base(points.ToList())
        {
        }
    }
}
