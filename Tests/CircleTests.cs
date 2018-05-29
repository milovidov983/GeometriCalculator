using System;
using GeometriCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesTests
{
    [TestClass]
    public class CircleTests
    {
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateCircle_SetWrongRadius_ThrowArgumentException(double r)
        {
            Shape circle = new Circle(r);
        }

        [TestMethod]
        public void CreateCircle_SetRadius1_CheckRadius()
        {
            Circle circle = new Circle(1);

            Assert.AreEqual(1, circle.Radius);
        }


        [TestMethod]
        public void CreateCircle_SetRadius1_ReturnValidArea()
        {
            Shape shape = new Circle(1);

            var result = Calculator.GetArea(shape);

            Assert.AreEqual(3.14159265358979, result, 0.000000000001);
        }
    }
}
