using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaLib.ColorStruct
{
    public struct HSL
    {
        public double H { get; set; }
        public double S { get; set; }
        public double L { get; set; }

        public HSL(double h, double s, double l)
        {
            H = h;
            S = s;
            L = l;
        }
    }
}
