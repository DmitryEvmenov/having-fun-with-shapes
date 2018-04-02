using System.Collections.Generic;

namespace Shapes.Concrete
{
    public class Ellipsis : Circle
    {
        public double StretchingX { get; }
        public double StretchingY { get; }

        public Ellipsis(int centerX, int centerY, int radius, double stretchingX, double stretchingY) : base(centerX, centerY, radius)
        {
            StretchingX = stretchingX;
            StretchingY = stretchingY;
        }

        public override IDictionary<string, object> CustomDrawObjects
        {
            get
            {
                var fromBase = base.CustomDrawObjects;
                fromBase.Add(nameof(StretchingX), StretchingX);
                fromBase.Add(nameof(StretchingY), StretchingY);

                return fromBase;
            }
        }
    }
}
