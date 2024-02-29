using ShapesCalculator.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ShapesCalculator
{
    public enum ShapeType
    {
        Circle,
        Triangle
    }

    public class ShapesCalculator
    {
        static List<Type> shapeClasses = Assembly.GetExecutingAssembly().GetTypes()
                                            .Where(t => t.GetInterfaces().Contains(typeof(IShape)))
                                            .ToList();

        static Type FindShapeClass(ShapeType type)
        {
            var shapeClass = shapeClasses.FirstOrDefault(x => x.GetCustomAttribute<ShapeTypeAttribute>().Type == type);
            if (shapeClass == null)
                throw new Exception($"no class for shape type '${type}' found");
            return shapeClass;
        }

        static public double GetAreaSize(ShapeType type, params double[] @params)
        {
            var shapeClass = FindShapeClass(type);
            var constru = shapeClass.GetConstructor(@params.Select(x => typeof(double)).ToArray());
            if (constru == null)
                throw new ArgumentException("wrong number of arguments for this shape");

            var shape = (IShape)constru.Invoke(@params.OfType<object>().ToArray());
            return shape.GetAreaSize();
        }

        static public bool IsTriangle90deg(double a, double b, double c)
        {
            // swap sides until a is the biggest
            while (a < b || a < c)
            {
                var x = a;
                a = b;
                b = c; 
                c = x;
            }

            return a * a == b * b + c * c;
        }
    }
}
