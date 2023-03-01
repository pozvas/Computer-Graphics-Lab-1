using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class GreyWorldFIlter : Filters
    {
        private int _avgR;
        private int _avgB;
        private int _avgG;
        public GreyWorldFIlter(Bitmap image)
        {
            findAvg(image);
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color color = sourceImage.GetPixel(i, j);
            int avg = (_avgR + _avgB + _avgG) / 3;
            Color result = Color.FromArgb(Clamp(color.R * avg / _avgR, 0, 255),
                                          Clamp(color.G * avg / _avgG, 0, 255), 
                                          Clamp(color.B * avg / _avgB, 0, 255));
            return result;
        }
        private void findAvg(Bitmap source)
        {
            for(int i = 0; i < source.Width; i++)
                for(int j = 0; j < source.Height; j++)
                {
                    Color color = source.GetPixel(i, j);
                    _avgR += color.R;
                    _avgB += color.B;
                    _avgG += color.G;
                }
            _avgR /= (source.Width * source.Height);
            _avgG /= (source.Width * source.Height);
            _avgB /= (source.Width * source.Height);
        }
    }
}
