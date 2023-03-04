using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class TransferFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            if (sourceImage.Width - x < 51)
            {
                return Color.Black;
            }
            else
            {
                Color resultColor = sourceImage.GetPixel(x + 50, y);
                return resultColor;
            }

        }
    }
}
