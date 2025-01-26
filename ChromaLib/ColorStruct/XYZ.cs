﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaLib.ColorStruct
{
    public struct XYZ
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public XYZ(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }
    }

}
