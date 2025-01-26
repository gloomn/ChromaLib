using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaLib.ColorStruct
{
    public struct CMYK
    {
        public double C { get; set; } // Cyan (0-1)
        public double M { get; set; } // Magenta (0-1)
        public double Y { get; set; } // Yellow (0-1)
        public double K { get; set; } // Black (0-1)

        public CMYK(double c, double m, double y, double k)
        {
            C = c;
            M = m;
            Y = y;
            K = k;
        }
    }

}
}
