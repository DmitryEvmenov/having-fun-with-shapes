using Shapes.Abstract;
using Shapes.General;

namespace Shapes.Concrete
{
    public class Line : Polyline
    {
        public Line(params Point[] points) : base(points)
        {
        }
    }
}
