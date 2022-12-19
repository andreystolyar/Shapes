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
            // Стороны треугольника не могут быть меньше нуля
            if (a < 0 || b < 0 || c < 0)
                throw new ArgumentOutOfRangeException
                        ("Sides of triangle cannot be negative");

            // Две стороны треугольника в сумме должны быть больше третьей
            if ((a + b) < c || (a + c) < b || (b + c) < a)
                throw new ArgumentException
                    ("This is not a correct triangle");

            (_sideA, _sideB, _sideC) = (a, b, c);
        }

        public bool IsRightAngled => CheckIfRightAngled(_sideA, _sideB, _sideC);

        bool CheckIfRightAngled(double a, double b, double c)
        {
            // Находим гипотенузу
            double biggest = (new double[] { a, b, c }).Max();

            /*
                В прямоугольном треугольнике квадрат гипотенузы равен
                сумме квадратов катетов. Так как мы заранее не знаем,
                какая из сторон наибольшая, с правой стороны считаем
                все три стороны а с левой берём квадрат гипотенузы
                в двойном количестве
            */
            return (Math.Pow(biggest, 2) * 2) ==
                Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2);
        }

        public override double Area
        {
            get
            {
                // sp - semiperimeter
                double sp = (_sideA + _sideB + _sideC) / 2;
                
                // формула Герона
                return Math.Sqrt
                    (sp * (sp - _sideA) * (sp - _sideB) * (sp - _sideC));
            }
        }
    }
}
