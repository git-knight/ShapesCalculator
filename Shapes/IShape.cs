using System;

namespace ShapesCalculator.Shapes
{
    interface IShape
    {
        double GetAreaSize();
    }

    class ShapeTypeAttribute : Attribute
    {
        public ShapeType Type { get; set; }
    }

}
