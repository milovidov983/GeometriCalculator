using GeometriCalculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ShapesTests {
	[TestClass]
	public class CalcualtorTests {
		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void GetArea_SetWrongTrinagle_0x1x1_ThrowArgumentException() {
			var result = Calculator.GetArea(0, 1, 1);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void GetArea_SetWrongCricle_R0_ThrowArgumentException() {
			var result = Calculator.GetArea(0);
		}

		[TestMethod]
		public void GetArea_SetTrinagle_1x1x1_ReturnValidArea() {
			AbstractShape shape = new Triangle(1, 1, 1);

			var result = Calculator.GetArea(shape);

			Assert.AreEqual(0.4, result);
		}

		[TestMethod]
		public void GetArea_SetCircle_R15_ReturnValidArea() {
			AbstractShape shape = new Circle(15);

			var result = Calculator.GetArea(shape);

			Assert.AreEqual(706.858347057703, result, 0.000000000001);
		}

		[DataTestMethod]
		[DataRow(3, 4, 5)]
		[DataRow(4, 3, 5)]
		[DataRow(5, 4, 3)]
		public void IsRectangular_SetRectangularTriangle_ReturnTrue(double a, double b, double c) {

			Triangle triangle = new Triangle(a, b, c);

			var result = Calculator.IsRectangular(triangle);

			Assert.IsTrue(result);
		}

		[DataTestMethod]
		[DataRow(1, 4, 1)]
		[DataRow(2, 3, 2)]
		[DataRow(3, 4, 3)]
		[DataRow(3, 1, 4)]
		[DataRow(4, 2, 5)]
		[DataRow(5, 3, 6)]
		[DataRow(3, 1, 7)]
		[DataRow(4, 2, 8)]
		[DataRow(5, 3, 9)]
		public void IsRectangular_SetNotRectangularTriangle_ReturnFalse(double a, double b, double c) {

			Triangle triangle = new Triangle(a, b, c);

			var result = Calculator.IsRectangular(triangle);

			Assert.IsFalse(result);
		}

		[DataTestMethod]
		[DataRow(3, 4, 5)]
		[DataRow(4, 3, 5)]
		[DataRow(5, 4, 3)]
		public void IsRectangular_SetRectangularTriangle_SideVersion_ReturnTrue(double a, double b, double c) {

			var result = Calculator.IsRectangular(a, b, c);

			Assert.IsTrue(result);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentNullException))]
		public void IsRectangular_SetNullArgument_ThrowArgumentNullException() {
			var result = Calculator.IsRectangular(null);
		}

		[TestMethod]
		[ExpectedException(typeof(ArgumentException))]
		public void IsRectangular_SetWrongSide_ThrowArgumentException() {
			var result = Calculator.IsRectangular(0, 0, 1);
		}
	}
}