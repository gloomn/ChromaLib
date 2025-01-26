using System;
using System.Collections.Generic;
using System.Text;
using ChromaLib;
using ChromaLib.ColorStruct;

namespace ChromaLib.ColorConverter
{
    public class RGBToHEXConverter : IChromaConverter<RGB, string>
    {
        public string Convert(RGB input)
        {
            // RGB 값을 HEX 문자열로 변환
            int r = (int)Math.Round(input.R);
            int g = (int)Math.Round(input.G);
            int b = (int)Math.Round(input.B);

            return $"#{r:X2}{g:X2}{b:X2}"; // HEX 문자열 반환
        }
    }
}

