using mindbox;
using mindbox.Circle;
using mindbox.Triangle;

namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        private const double AREA_TOLERANCE = 0.00000001;

        [TestMethod]
        [DataRow(1,Math.PI)]
        [DataRow(2, 4*Math.PI)]
        public void TestCircleArea(double r, double result)
        {
            var area = new Circle(r).Area();
            Assert.IsTrue(Math.Abs(result - area) < AREA_TOLERANCE);
        }

        [TestMethod]
        [DataRow(3,5,4,6)]
        public void TestTriangleArea(double x, double y, double z, double result)
        {
            var area = new Triangle(x, y, z).Area();
            Assert.IsTrue(Math.Abs(result - area) < AREA_TOLERANCE);
        }

        [TestMethod]
        [DataRow(3,5,4,true)]
        [DataRow(1,1,3,false)]
        public void TestIsTriangleRight(double x, double y, double z, bool result)
        {
            var right = new Triangle(x, y, z).IsRightTriangle();
            Assert.IsTrue(right==result);
        }
    }
}