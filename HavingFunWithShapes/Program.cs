using System;
using HavingFunWithShapes.Drawing;
using Shapes.Abstract;
using Shapes.Concrete;
using Shapes.General;

namespace HavingFunWithShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var shapeList = GetDefaultShapeList();
            var drawer = new ShapeDrawer();
            drawer.DrawShapesInto(shapeList, Console.Out);

            Console.ReadLine();
        }

        private static ShapeList GetDefaultShapeList()
            => new ShapeList()
            {
                new Circle(0, 10, 25),
                new Ellipsis(5, 25, 10, 0.5, 1.25),
                new Line(new Point(10, 50), new Point(25, 60), new Point(0, 75)),
                new LineSegment(new Point(5, 5), new Point(5, 10)),
                new Rectangle(0, 0, 10, 25),
                new Square(0, 0, 5)
            };
    }
}
