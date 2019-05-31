using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTest
{
    public enum enShape
    {
        Rectangle,
        Triangle,
        Circle,
    }
    public static class ShapeMath
    {
        public static double GetArea(enShape shape, double length1 = 0, double length2 = 2)
        {
            switch(shape)
            {
                case enShape.Rectangle: return length1 * length2;
                case enShape.Triangle: return length1 * length2/2;
                case enShape.Circle: return Math.PI * Math.Pow(length1, length2);
                default: return 0;
            }
        }
    }
}
