using System;
using System.Collections.Generic;
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

            var customShape = InitCustomShape();
            if (customShape != null)
            {
                shapeList.Add(customShape);
                drawer.DrawShapesInto(shapeList, Console.Out);
            }

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

        private static Shape InitCustomShape()
        {
            Console.WriteLine("Would you like to enter a custom shape? (y/n)");
            var answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.WriteLine("Please enter the shape name:");
                var shapeName = Console.ReadLine();
                Console.WriteLine("Please enter the shape points count:");
                var shapePointsCount = int.Parse(Console.ReadLine());

                var points = new List<Point>();
                for (int i = 1; i <= shapePointsCount; i++)
                {
                    var point = new Point();

                    Console.WriteLine($"Please enter Point{i} X:");
                    point.X = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Please enter Point{i} Y:");
                    point.Y = int.Parse(Console.ReadLine());

                    points.Add(point);
                }

                return CustomShapeTypeBuilder.CreateNewShape(shapeName, points);
            }

            return null;
        }
    }
}
