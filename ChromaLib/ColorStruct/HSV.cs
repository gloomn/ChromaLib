using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaLib.ColorStruct
{
    public struct HSV
    {
        public double H { get; set; } // Hue (0-360)
        public double S { get; set; } // Saturation (0-1)
        public double V { get; set; } // Value (0-1)

        public HSV(double h, double s, double v)
        {
            H = h;
            S = s;
            V = v;
        }
    }
}
