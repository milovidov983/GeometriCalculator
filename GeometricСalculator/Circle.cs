namespace GeometriCalculator {
	using System;
	/// <summary>
	/// A class implements the circle
	/// </summary>
	public class Circle : AbstractShape {
		private readonly string _errorMessage = "The radius must be greater than 0";

		private double _radius;
		public double Radius {
			get {
				return _radius;
			}
			set {
				if (value > 0) {
					_radius = value;
				} else {
					throw new ArgumentException(_errorMessage);
				}

			}
		}

		public override double Area {
			get {
				return _radius * _radius * Math.PI;
			}

		}

		/// <summary>
		/// The constructor of the сircle class
		/// </summary>
		/// <param name="radius">Circle radius</param>
		/// <exception cref="System.ArgumentException">
		/// Thrown when the radius is less than or equal to zero
		/// </exception>
		public Circle(double radius) {
			Radius = radius;
		}

	}
}
