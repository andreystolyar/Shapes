using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    /// <summary>
    /// Represents the Triangle class.
    /// </summary>
    /// <param name="a">First side</param>
    /// <param name="b">Second side</param>
    /// <param name="c">Third side</param>
    public sealed class Triangle : Shape
    {
        double _sideA, _sideB, _sideC;
        public Triangle(double a, double b, double c)
        {
            // Sides of a triangle cannot be less than zero
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException
                        ("Sides of a triangle cannot be negative");

            // Two sides of a triangle together must be greater than the third
            if ((a + b) < c || (a + c) < b || (b + c) < a)
                throw new ArgumentException
                    ("This is not a correct triangle");

            (_sideA, _sideB, _sideC) = (a, b, c);
        }

        public bool IsRightAngled => CheckIfRightAngled(_sideA, _sideB, _sideC);

        /// <summary>
        /// This method checks if a triangle is right-angled or not.
        /// </summary>
        /// <param name="a">First side</param>
        /// <param name="b">Second side</param>
        /// <param name="c">Third side</param>
        bool CheckIfRightAngled(double a, double b, double c)
        {
            // Figuring out the hypotenuse
            double biggest = (new double[] { a, b, c }).Max();

            /*
                In a right-angled triangle the square of the hypotenuse
                is equal to the sum of the squares of the other two sides.
                Since we don't know yet which side is hypotenuse we can count
                all three sides on the right and take an extra square of the
                hypotenuse on the left
            */
            return (Math.Pow(biggest, 2) * 2) ==
                Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);
        }

        /// <summary>
        /// Represents the area of a triangle.
        /// </summary>
        public override double Area
        {
            get
            {
                // sp - semiperimeter
                double sp = (_sideA + _sideB + _sideC) / 2;
                
                // Heron's formula
                return Math.Sqrt
                    (sp * (sp - _sideA) * (sp - _sideB) * (sp - _sideC));
            }
        }
    }
}
