using System;

namespace ShapesCalculator.Shapes
{
    [ShapeType(Type = ShapeType.Triangle)]
    class Triangle : IShape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double GetAreaSize()
        {
            var p = (A + B + C) / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
    }

}
