using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class PerfectReflector : Filters
    {
        private int _maxR;
        private int _maxB;
        private int _maxG;
        public PerfectReflector(Bitmap image)
        {
            _maxR = 0;
            _maxG = 0;
            _maxB = 0;
            findMax(image);
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color color = sourceImage.GetPixel(i, j);
            Color result = Color.FromArgb(Clamp(color.R * 255 / _maxR, 0, 255),
                                          Clamp(color.G * 255 / _maxB, 0, 255),
                                          Clamp(color.B * 255 / _maxG, 0, 255));
            return result;
        }
        private void findMax(Bitmap source)
        {
            for (int i = 0; i < source.Width; i++)
                for (int j = 0; j < source.Height; j++)
                {
                    Color color = source.GetPixel(i, j);
                    if (_maxR < color.R)
                        _maxR = color.R;

                    if (_maxG < color.G)
                        _maxG = color.G;

                    if (_maxB < color.B)
                        _maxB = color.B;

                }

        }
    }
}
