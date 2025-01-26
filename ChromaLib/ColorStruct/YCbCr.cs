using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaLib.ColorStruct
{
    public struct YCbCr
    {
        public double Y { get; set; }
        public double Cb { get; set; }
        public double Cr { get; set; }

        public YCbCr(double y, double cb, double cr)
        {
            Y = y;
            Cb = cb;
            Cr = cr;
        }
    }

