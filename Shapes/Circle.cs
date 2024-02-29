using System;

namespace ShapesCalculator.Shapes
{
    [ShapeType(Type = ShapeType.Circle)]
    class Circle : IShape
    {
        public double Radius { get; set; }

        public double GetAreaSize() => Math.PI * Radius * Radius;

        public Circle(double r) =>
            Radius = r;
    }

}
