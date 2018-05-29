// ==++==
// 
//   Copyright (c) Milovidov V.A.  All rights reserved.
// 
// ==--==
/*============================================================
**
** Class:  Calculator
** 
**
**
** Purpose: Class containing static functions for calculating 
**          the area of geometric shapes
**
** 
===========================================================*/
namespace GeometriCalculator
{
    using System;
    /// <summary>
    /// If you want to add a new shape,
    /// It is necessary to inherit it from the Shape class,
    /// after which it can be passed the functions Calculator.GetArea(),
    /// which is the main function of calculating the area.
    /// </summary>
    public class Calculator
    {
        /// <summary>
        /// The function of calculating the area, regardless of the type of figure
        /// </summary>
        public static double GetArea(Shape shape)
        {
            return shape.Area;
        }

        /// <summary>
        /// The function of calculating the area of the circle along the radius
        /// </summary>
        /// <param name="r">Circle radius</param>
        /// <exception cref="System.ArgumentException">
        /// Thrown when the radius is less than or equal to zero
        /// </exception>
        /// <returns>
        /// Area of geometric shapes
        /// </returns>
        public static double GetArea(double r)
        {
            Shape shape = new Circle(r);
            return shape.Area;
        }

        /// <summary>
        /// The function calculates the area of the triangle on three sides
        /// </summary>
        /// <param name="a">side a</param>
        /// <param name="b">side b</param>
        /// <param name="c">side c</param>
        /// <exception cref="System.ArgumentException">
        /// Thrown when one of the parameters is less than or equal to zero
        /// </exception>
        /// <returns>
        /// Area of geometric shapes
        /// </returns>
        public static double GetArea(double a, double b, double c)
        {
            Shape shape = new Triangle(a, b, c);
            return shape.Area;
        }

        /// <summary>
        /// The function determines whether the triangle is right-angled
        /// </summary>
        /// <exception cref="System.ArgumentNullException">
        /// Thrown when the parameters is null
        /// </exception>
        /// <returns>
        /// true if the triangle is right-angled
        /// otherwise false
        /// </returns>
        public static bool IsRectangular(Triangle triangle)
        {
            if (triangle == null)
                throw new ArgumentNullException("The value can not be null");

            return triangle.IsRectangular;
        }

        /// <summary>
        /// The function determines whether the triangle is right-angled
        /// </summary>
        /// <exception cref="System.ArgumentException">
        /// Thrown when one of the parameters is less than or equal to zero
        /// </exception>
        /// <returns>
        /// true if the triangle is right-angled
        /// otherwise false
        /// </returns>
        public static bool IsRectangular(double a, double b, double c)
        {
            Triangle triangle = new Triangle(a, b, c);
            return IsRectangular(triangle);
        }
    }
}
