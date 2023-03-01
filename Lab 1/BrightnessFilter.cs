using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class BrightnessFilter : Filters
    {
        private int brightness;
        public BrightnessFilter(int brightness)
        {
            this.brightness = brightness;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color color = sourceImage.GetPixel(i, j);
            return Color.FromArgb(Clamp(color.R + brightness, 0, 255), Clamp(color.G + brightness, 0, 255), Clamp(color.B + brightness, 0, 255));
        }
    }
}
