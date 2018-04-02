using Shapes.Abstract;
using Shapes.General;

namespace Shapes.Concrete
{
    public class Polygon : Polyline
    {
        public Polygon(params Point[] points) : base(points)
        {
            
        }
    }
}
