using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaLib.ColorStruct
{
    public struct LCH
    {
        public double L { get; set; } // Lightness (0-100)
        public double C { get; set; } // Chroma
        public double H { get; set; } // Hue (0-360)

        public LCH(double l, double c, double h)
        {
            L = l;
            C = c;
            H = h;
        }
    }

}
