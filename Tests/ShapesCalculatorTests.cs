using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ShapesCalculator.Tests
{
    internal class ShapesCalculatorTests
    {
        [Fact]
        bool TestCircleAreaSize()
        {
            return ShapesCalculator.GetAreaSize(ShapeType.Circle, 10) == Math.PI * 10 * 10;
            // this allows for a slight error
            return Math.Abs(ShapesCalculator.GetAreaSize(ShapeType.Circle, 10) - Math.PI * 10 * 10) < 0.0001;
        }

        [Fact]
        bool TestRectangleAreaSize()
        {
            return ShapesCalculator.GetAreaSize(ShapeType.Triangle, 3, 4, 5) == 6;
        }

        [Fact]
        bool TriangleShouldBe90()
        {
            return ShapesCalculator.IsTriangle90deg(3, 4, 5);
        }
    }
}
