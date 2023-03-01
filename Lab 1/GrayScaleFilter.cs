using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class GrayScaleFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color color = sourceImage.GetPixel(i, j);
            Color result = Color.FromArgb(Clamp((int)(color.R * 0.36 + color.G * 0.53 + color.B * 0.11), 0, 255),
                                          Clamp((int)(color.R * 0.36 + color.G * 0.53 + color.B * 0.11), 0, 255),
                                          Clamp((int)(color.R * 0.36 + color.G * 0.53 + color.B * 0.11), 0, 255));
            return result;
        }
    }
}
