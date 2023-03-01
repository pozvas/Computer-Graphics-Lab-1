using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class SepiaFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color color = sourceImage.GetPixel(i, j);
            float intensity = color.R * 0.36f + color.G * 0.53f + color.B * 0.11f;
            float k = 10f;
            Color result = Color.FromArgb(Clamp((int)(intensity + 2 * k), 0, 255), 
                                          Clamp((int)(intensity + 0.5 * k), 0, 255), 
                                          Clamp((int)(intensity - k), 0, 255));
            return result;
        }
    }
}
