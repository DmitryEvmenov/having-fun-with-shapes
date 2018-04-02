using System.Collections.Generic;

namespace Shapes.General
{
    public interface ICustomDrawable
    {
        IDictionary<string, object> CustomDrawObjects { get; }
    }
}
