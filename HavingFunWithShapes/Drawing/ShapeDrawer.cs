using System.IO;
using Shapes.Abstract;
using Shapes.General;

namespace HavingFunWithShapes.Drawing
{
    public class ShapeDrawer
    {
        public void DrawShapeInto(Shape shape, TextWriter writer)
        {
            writer.WriteLine($"Drawing {shape.Name}");
            shape.Points.ForEach(p => DrawPointInto(p, writer));

            if (shape is ICustomDrawable drawable)
            {
                DrawCustomInto(drawable, writer);
            }

            writer.WriteLine("___________________________________________");
        }

        public void DrawShapesInto(ShapeList shapes, TextWriter writer) => shapes.ForEach(s => DrawShapeInto(s, writer));
        private void DrawPointInto(Point point, TextWriter writer) => writer.WriteLine($"({point.X}, {point.Y})");

        private void DrawCustomInto(ICustomDrawable customDrawable, TextWriter writer)
        {
            foreach (var toDraw in customDrawable.CustomDrawObjects)
            {
                writer.WriteLine($"{toDraw.Key}: {toDraw.Value}");
            }
        }
    }
}
