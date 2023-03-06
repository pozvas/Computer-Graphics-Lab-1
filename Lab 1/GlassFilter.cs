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
        private Random rand = new Random();
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
        {
            
            //int value = rand.Next(0, 2);
            int resX = (int)(x + (rand.Next(0, 5) - 2) * 1);
            int resY = (int)(y + (rand.Next(0, 5) - 2) * 1);
            return sourceImage.GetPixel(Clamp(resX, 0, sourceImage.Width - 1), Clamp(resY, 0, sourceImage.Height - 1));
        }
        
    }
}
