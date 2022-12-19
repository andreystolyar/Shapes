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

        /// <summary>
        /// Represents the area of a circle.
        /// </summary>
        public override double Area
        {
            // The area of a circle is Pi times radius squared
            get => Math.PI * Math.Pow(_radius, 2);
        }
    }
}
