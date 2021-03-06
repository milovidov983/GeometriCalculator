﻿namespace GeometriCalculator {
	using System;
	/// <summary>
	/// A class implements the triangle
	/// </summary>
	public class Triangle : AbstractShape {
		private readonly string _sidesErrorMessage = "The side of the triangle must be greater than 0";
		private readonly string _epsilonErrorMessage = "The error must be greater than 0";

		private double _epsilon = 0.000000000001;
		/// <summary>
		/// Error in calculating the squareness
		/// default value is 0.000000000001
		/// </summary>
		public double Epsilon {
			get {
				return _aAside;
			}
			set {
				if (value > 0) {
					_aAside = value;
				} else {
					throw new ArgumentException(_epsilonErrorMessage);
				}

			}
		}


		private double _aAside;
		public double ASide {
			get {
				return _aAside;
			}
			set {
				if (value > 0) {
					_aAside = value;
				} else {
					throw new ArgumentException(_sidesErrorMessage);
				}

			}
		}

		private double _bSide;
		public double BSide {
			get {
				return _bSide;
			}
			set {
				if (value > 0) {
					_bSide = value;
				} else {
					throw new ArgumentException(_sidesErrorMessage);
				}

			}
		}

		private double _cSide;
		public double CSide {
			get {
				return _cSide;
			}
			set {
				if (value > 0) {
					_cSide = value;
				} else {
					throw new ArgumentException(_sidesErrorMessage);
				}

			}
		}

		public override double Area {
			get {
				var i = (ASide + BSide + CSide) / 2.0;
				return Math.Round(Math.Sqrt(i * (i - ASide) * (i - BSide) * (i - CSide)), 1);
			}
		}

		public bool IsRectangular {
			get {
				///It is clear that here you can do micro optimization, 
				///but it seemed to me that readability is more important
				var result_A_hypotenuse = Math.Abs((CSide * CSide + BSide * BSide) - (ASide * ASide));
				var result_B_hypotenuse = Math.Abs((CSide * CSide + ASide * ASide) - (BSide * BSide));
				var result_C_hypotenuse = Math.Abs((ASide * ASide + BSide * BSide) - (CSide * CSide));

				if ((result_A_hypotenuse < _epsilon) ||
					 (result_B_hypotenuse < _epsilon) ||
					 (result_C_hypotenuse < _epsilon)) {
					return true;
				}
				return false;
			}
		}

		/// <summary>
		/// The constructor of the triangle class
		/// </summary>
		/// <param name="a">side a</param>
		/// <param name="b">side b</param>
		/// <param name="c">side c</param>
		/// <exception cref="System.ArgumentException">
		/// Thrown when one of the parameters is less than or equal to zero
		/// </exception>
		public Triangle(double a, double b, double c) {
			ASide = a;
			BSide = b;
			CSide = c;
		}

	}
}
