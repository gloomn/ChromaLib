using System;
using System.Collections.Generic;
using System.Text;

namespace ChromaLib.ColorStruct
{
    public struct RGB
    {
        public double R { get; set; }
        public double G { get; set; }
        public double B { get; set; }

        public RGB(double r, double g, double b)
        {
            R = r;
            G = g;
            B = b;
        }

        // 기본 ToString() - RGB 형식으로 출력
        public override string ToString()
        {
            return ToString(default); // 기본 형식으로 호출
        }

        // 형식에 따라 다르게 출력
        public string ToString(string format)
        {
            switch (format.ToLower())
            {
                case "full":
                    return $"RGB({R}, {G}, {B})"; // RGB 값 형식
                case "numbers":
                    return $"{R}, {G}, {B}"; // 숫자만 출력
                default:
                    return $"{R}, {G}, {B}"; // 기본 형식
            }
        }
    }
}
