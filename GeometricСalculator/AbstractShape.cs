namespace GeometriCalculator {
	/// <summary>
	/// Base class for all shapes
	/// </summary>
	public abstract class AbstractShape {
		/// <summary>
		/// This property implements the mechanism of calculating the area of the figure.
		/// </summary>
		public abstract double Area { get; }
	}
}
