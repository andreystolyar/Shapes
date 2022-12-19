using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// Represents the Circle class.
    /// </summary>
    /// <param name="r">Radius</param>
    public sealed class Circle : Shape
    {
        double _radius;
        public Circle(double r)
        {
            if (r < 0)
                throw new ArgumentOutOfRangeException
                        ("Radius cannot be negative");
            _radius = r;
        }

        // Площадь круга равна: число Пи умноженное на радиус в квадрате
        public override double Area
        {
            get => Math.PI * Math.Pow(_radius, 2);
        }
    }
}
