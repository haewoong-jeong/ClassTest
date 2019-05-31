using System;
using System.Collections.Generic;
using System.Text;

namespace ClassTest
{
    public static class ShapeMath
    {
        public static double GetArea(string shape ="", double length1 = 0, double length2 = 2)
        {
            if (String.Equals("Rectangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2;
            }
            else if (String.Equals("Triangle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return length1 * length2 / 2;
            }
            else if (String.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return Math.PI * Math.Pow(length1, length2);
            }
            return 0;
        }
    }
}
