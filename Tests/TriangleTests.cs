using System;
using GeometriCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShapesTests
{
    [TestClass]
    public class TriangleTests
    {
        [DataTestMethod]
        [DataRow(-1, -1, -1)]
        [DataRow(0, 1, 1)]
        [DataRow(1, 0, 1)]
        [DataRow(1, 1, 0)]
        [ExpectedException(typeof(ArgumentException))]
        public void CreateTriangle_SetWrongSides_ThrowArgumentException(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a,b,c);
        }

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [ExpectedException(typeof(ArgumentException))]
        public void SetWrongEpsilon_ThrowArgumentException(double epsilon)
        {
            Triangle triangle = new Triangle(1, 1, 1)
            {
                Epsilon = epsilon
            };
        }

        [DataTestMethod]
        [DataRow(0.1)]
        [DataRow(0.000000000001)]
        public void SetValidEpsilon_ReturnValidEpsilon(double epsilon)
        {
            Triangle triangle = new Triangle(1, 1, 1)
            {
                Epsilon = epsilon
            };

            Assert.AreEqual(epsilon, triangle.Epsilon);
        }

        [TestMethod]
        public void CreateTriangle_SetSides_1x1x1_ReturnValidSide()
        {
            Triangle triangle = new Triangle(1,2,3);

            Assert.AreEqual(1, triangle.ASide);
            Assert.AreEqual(2, triangle.BSide);
            Assert.AreEqual(3, triangle.CSide);
        }

        [TestMethod]
        public void CreateTriangle_SetSides_1x1x1_ReturnValidArea()
        {
            Triangle triangle = new Triangle(1,1,1);

            var result = triangle.Area;

            Assert.AreEqual(0.4, result);
        }
    }
}
