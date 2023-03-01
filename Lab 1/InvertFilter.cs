using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class InvertFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color color = sourceImage.GetPixel(i, j);
            Color result = Color.FromArgb(255 - color.R, 255 - color.G, 255 - color.B);
            return result;
        }
    }
}
