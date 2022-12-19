using Shapes;

namespace TestShapes
{
    public class CircleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Constructor_RadiusIsNegative_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [Test]
        public void Area_RadiusIsZero()
        {
            var c = new Circle(0);
            Assert.AreEqual(c.Area, 0);
        }

        [Test]
        public void Area_RadiusIsZeroPointOne()
        {
            var c = new Circle(0.1);
            Assert.AreEqual(c.Area, 0.031415926535897934);
        }

        [Test]
        public void Area_RadiusIsOne()
        {
            var c = new Circle(1);
            Assert.AreEqual(c.Area, 3.141592653589793);
        }

        [Test]
        public void Area_RadiusIsTen()
        {
            var c = new Circle(10);
            Assert.AreEqual(c.Area, 314.1592653589793);
        }

        [Test]
        public void Area_RadiusIsMaxValue()
        {
            var c = new Circle(double.MaxValue);
            Assert.AreEqual(c.Area, double.PositiveInfinity);
        }
    }
}