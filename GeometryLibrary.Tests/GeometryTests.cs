using GeometryLibrary.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GeometryLibrary.Tests
{
    [TestClass]
    public class GeometryTests
    {
        [TestMethod]
        public void TestCircleAreaWithPositiveRadius()
        {
            var circle = ShapeFactory.CreateCircle(5);
            Assert.AreEqual(Math.PI * 5 * 5, circle.Area, 1e-10);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCircleWithNegativeRadius()
        {
            var circle = ShapeFactory.CreateCircle(-5);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCircleWithNullRadius()
        {
            var circle = ShapeFactory.CreateCircle(0);
        }


        [TestMethod]
        public void TestTriangleArea()
        {
            var triangle = ShapeFactory.CreateTriangle(3, 4, 5);
            Assert.AreEqual(6, triangle.Area, 1e-10);
        }

        
        [TestMethod]
        public void TestRightAngledTriangle()
        {
            var triangle = ShapeFactory.CreateTriangle(3, 4, 5);
            Assert.IsTrue(((Triangle)triangle).IsRightAngled());
        }


        [TestMethod]
        public void TestNotRightAngledTriangle()
        {
            var triangle = ShapeFactory.CreateTriangle(5, 6, 7);
            Assert.IsFalse(((Triangle)triangle).IsRightAngled());
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidTriangle()
        {
            ShapeFactory.CreateTriangle(1, 2, 3);
        }
    }
}
