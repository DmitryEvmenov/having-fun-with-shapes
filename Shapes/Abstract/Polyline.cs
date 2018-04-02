using System.Linq;
using Shapes.General;

namespace Shapes.Abstract
{
    public abstract class Polyline : Shape
    {
        protected Polyline(params Point[] points) : base(points.ToList())
        {
        }
    }
}
