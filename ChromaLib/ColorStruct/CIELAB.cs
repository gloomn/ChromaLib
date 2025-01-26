using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaLib.ColorStruct
{
    public struct CIELAB
    {
        public double L { get; set; } // Lightness (0-100)
        public double A { get; set; } // Green-Red (-128 to 127)
        public double B { get; set; } // Blue-Yellow (-128 to 127)

        public CIELAB(double l, double a, double b)
        {
            L = l;
            A = a;
            B = b;
        }
    }
}
