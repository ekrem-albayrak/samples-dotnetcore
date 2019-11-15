using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace logic
{
    public class ColorHelper
    {

        // Returns the color of a RGB string
        private Color GetColorFromRGB(string color)
        {
            byte a = 255;
            byte r = (byte)(Convert.ToUInt32(color.Substring(1, 2), 16));

            byte g = (byte)(Convert.ToUInt32(color.Substring(3, 2), 16));
            byte b = (byte)(Convert.ToUInt32(color.Substring(5, 2), 16));

            return Color.FromArgb(a, r, g, b);
        }
    }
}
