using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class GlassFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            Random rand = new Random();
            int value = rand.Next(0, 3);
            int resX = (int)(x + (value - 0.5) * 10);
            int resY = (int)(y + (value - 0.5) * 10);
            Color resultColor = sourceImage.GetPixel(Clamp(resX, 0, sourceImage.Width - 1), Clamp(resY, 0, sourceImage.Height - 1));
            return resultColor;
        }
        
    }
}
