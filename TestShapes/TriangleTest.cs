using Shapes;

namespace TestShapes
{
    public class TriangleTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Constructor_ASideIsNegative_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>
                (() => new Triangle(-2, 3, 4));
        }

        [Test]
        public void Constructor_BSideIsNegative_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>
                (() => new Triangle(3, -4, 5));
        }

        [Test]
        public void Constructor_CSideIsNegative_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>
                (() => new Triangle(5, 3, -4));
        }

        [Test]
        public void Constructor_AandBSideIsNegative_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>
                (() => new Triangle(-2, -6, 5));
        }
        [Test]
        public void Constructor_AandCSideIsNegative_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>
                (() => new Triangle(-5, 6, -4));
        }

        [Test]
        public void Constructor_BandCSideIsNegative_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>
                (() => new Triangle(6, -6, -4));
        }

        [Test]
        public void Constructor_AllSidesAreNegative_ThrowsException()
        {
            Assert.Throws<ArgumentOutOfRangeException>
                (() => new Triangle(-8, -6, -9));
        }

        [Test]
        public void Constructor_AAndBAreLessThanC_ThrowsException()
        {
            Assert.Throws<ArgumentException> (() => new Triangle(5, 6, 12));
        }

        [Test]
        public void Constructor_AAndCAreLessThanB_ThrowsException()
        {
            Assert.Throws<ArgumentException> (() => new Triangle(8, 25, 12));
        }

        [Test]
        public void Constructor_BAndCAreLessThanA_ThrowsException()
        {
            Assert.Throws<ArgumentException> (() => new Triangle(28, 5, 2));
        }

        [Test]
        public void Constructor_OneSideIsMaxValue_ThrowsException()
        {
            Assert.Throws<ArgumentException> (() =>
                    new Triangle(double.MaxValue, 5, 2));
        }

        [Test]
        public void Area_AAndBAreEqualC_ReturnsZero()
        {
            var c = new Triangle(28, 12, 40);
            Assert.AreEqual(c.Area, 0);
        }

        [Test]
        public void Area_TwoSidesAreMaxValue_ReturnsPositiveInfinity()
        {
            var c = new Triangle(1, double.MaxValue, double.MaxValue);
            Assert.AreEqual(c.Area, double.PositiveInfinity);
        }

        [Test]
        public void Area_AAndCAreEqualB_ReturnsZero()
        {
            var c = new Triangle(28, 68, 40);
            Assert.AreEqual(c.Area, 0);
        }

        [Test]
        public void Area_BAndCAreEqualA_ReturnsZero()
        {
            var c = new Triangle(100, 60, 40);
            Assert.AreEqual(c.Area, 0);
        }

        [Test]
        public void Area_SidesAreIntegers()
        {
            var c = new Triangle(5, 6, 7);
            Assert.AreEqual(c.Area, 14.696938456699069);
        }

        [Test]
        public void Area_SidesAreFloating()
        {
            var c = new Triangle(5.5, 6.1, 7.999);
            Assert.AreEqual(c.Area, 16.752476367227025);
        }

        [Test]
        public void IsRightAngled_RightAngled_ReturnTrue1()
        {
            var c = new Triangle(3, 4, 5);
            Assert.AreEqual(c.IsRightAngled, true);
        }

        [Test]
        public void IsRightAngled_RightAngled_ReturnTrue2()
        {
            var c = new Triangle(6, 8, 10);
            Assert.AreEqual(c.IsRightAngled, true);
        }

        [Test]
        public void IsRightAngled_RightAngled_ReturnTrue3()
        {
            var c = new Triangle(12.3, 45.6, 47.22975756871932);
            Assert.AreEqual(c.IsRightAngled, true);
        }

        [Test]
        public void IsRightAngled_RightAngled_ReturnFalse()
        {
            var c = new Triangle(23, 43, 48.765);
            Assert.AreEqual(c.IsRightAngled, false);
        }
    }
}
