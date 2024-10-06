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
            // arrange
            double r = 5;
            double expected = Math.PI * 5 * 5;

            // act
            var circle = ShapeFactory.CreateCircle(r);
            double actual = circle.Area;

            // assert
            Assert.AreEqual(expected, actual, 1e-10);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCircleWithNegativeRadius()
        {
            double r = -5;
            var circle = ShapeFactory.CreateCircle(r);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCircleWithNullRadius()
        {
            double r = 0;
            var circle = ShapeFactory.CreateCircle(0);
        }


        [TestMethod]
        public void TestTriangleArea()
        {
            // arrange
            double a = 3;
            double b = 4;
            double c = 5;
            double expected = 6;

            // act
            var triangle = ShapeFactory.CreateTriangle(a, b, c);
            double actual = triangle.Area;

            // assert
            Assert.AreEqual(expected, actual, 1e-10);
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
            // arrange
            double a = 5;
            double b = 6;
            double c = 7;

            // act
            var triangle = ShapeFactory.CreateTriangle(a, b, c);
            bool condition = ((Triangle)triangle).IsRightAngled();

            // assert
            Assert.IsFalse(condition);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestInvalidTriangle()
        {
            double a = 1;
            double b = 2;
            double c = 3;

            ShapeFactory.CreateTriangle(a, b, c);
        }
    }
}
