// ==++==
// 
//   Copyright (c) Milovidov V.A.  All rights reserved.
// 
// ==--==
/*============================================================
**
** Class:  Shape
** 
**
**
** Purpose: Base class for all shapes
**
** 
===========================================================*/
namespace GeometriCalculator
{
    abstract public class Shape
    {
        /// <summary>
        /// This property implements the mechanism of calculating the area of the figure.
        /// </summary>
        abstract public double Area { get; }
    }
}
