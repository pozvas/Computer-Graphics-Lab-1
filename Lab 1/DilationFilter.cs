using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class DilationFilter : Filters
    {
        private bool[,] kernel;
        private int centerX;
        private int centerY;
        public DilationFilter(bool[,] _kernel, int _centerX, int _centerY)
        {
            kernel = _kernel;
            centerX = _centerX;
            centerY = _centerY;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            bool pixelColor = colorToBool(sourceImage.GetPixel(i, j));
            if (kernel[centerX, centerY] == pixelColor)
            {
                int radiusX = kernel.GetLength(0) / 2;
                int radiusY = kernel.GetLength(1) / 2;
                for (int l = -radiusY; l <= radiusY; l++)
                    for (int k = -radiusX; k <= radiusX; k++)
                    {
                        int idX = Clamp(i + k, 0, sourceImage.Width - 1);
                        int idY = Clamp(j + l, 0, sourceImage.Height - 1);
                        if (!kernel[k + radiusX, l + radiusY]) resultImage.SetPixel(idX, idY, Color.Black);
                    }
            }
            return resultImage.GetPixel(i, j);
        }
        private bool colorToBool(Color color)
        {
            if (color.R >= 250 && color.G >= 250 && color.B >= 250) return true;
            return false;
        }
    }
}
