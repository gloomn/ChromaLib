using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaLib.ColorStruct
{
    public struct YUV
    {
        public double Y { get; set; }
        public double U { get; set; }
        public double V { get; set; }

        public YUV(double y, double u, double v)
        {
            Y = y;
            U = u;
            V = v;
        }
    }

}
