using Shapes;

namespace TestShapes
{
    public class ShapeTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Area_ShapeIsCircle()
        {
            Shape obj = new Circle(12.5);
            Assert.AreEqual(obj.Area, 490.8738521234052);
        }

        [Test]
        public void Area_ShapeIsTriangle()
        {
            Shape obj = new Triangle(10, 5, 9);
            Assert.AreEqual(obj.Area, 22.44994432064365);
        }
    }
}
