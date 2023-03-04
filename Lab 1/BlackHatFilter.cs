using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class BlackHatFilter : Filters
    {
        private bool[,] kernel;
        private int centerX;
        private int centerY;
        private Bitmap imageAfterErosion;
        private bool erosionCompleted = false;
        public BlackHatFilter(bool[,] _kernel, int _centerX, int _centerY)
        {
            kernel = _kernel;
            centerX = _centerX;
            centerY = _centerY;
        }
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            bool colorNew = colorToBool(openingColor(sourceImage, i, j));
            bool colorOld = colorToBool(sourceImage.GetPixel(i, j));
            if (colorNew && !colorOld) return Color.White;
            else return Color.Black;


        }
        private Color openingColor(Bitmap sourceImage, int i, int j)
        {
            if (!erosionCompleted)
            {
                imageAfterErosion = new Bitmap(sourceImage.Width, sourceImage.Height);
                for (int a = 0; a < sourceImage.Width; a++)
                {
                    for (int b = 0; b < sourceImage.Height; b++)
                        imageAfterErosion.SetPixel(a, b, erosionColor(sourceImage, a, b));
                }
                erosionCompleted = true;
            }


            bool pixelColor = colorToBool(imageAfterErosion.GetPixel(i, j));
            if (kernel[centerX, centerY] == pixelColor)
            {
                int radiusX = kernel.GetLength(0) / 2;
                int radiusY = kernel.GetLength(1) / 2;
                for (int l = -radiusY; l <= radiusY; l++)
                    for (int k = -radiusX; k <= radiusX; k++)
                    {
                        int idX = Clamp(i + k, 0, imageAfterErosion.Width - 1);
                        int idY = Clamp(j + l, 0, imageAfterErosion.Height - 1);
                        if (!kernel[k + radiusX, l + radiusY]) resultImage.SetPixel(idX, idY, Color.Black);
                    }
            }
            return resultImage.GetPixel(i, j);
        }

        private Color erosionColor(Bitmap sourceImage, int i, int j)
        {
            int radiusX = kernel.GetLength(0) / 2;
            int radiusY = kernel.GetLength(1) / 2;

            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {

                    int idX = Clamp(i + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(j + l, 0, sourceImage.Height - 1);
                    bool pixelColor = colorToBool(sourceImage.GetPixel(idX, idY));
                    if (pixelColor != kernel[k + radiusX, l + radiusY])
                    {
                        return Color.White;
                    }
                }
            return Color.Black;
        }

        private bool colorToBool(Color color)
        {
            if (color.R >= 250 && color.G >= 250 && color.B >= 250) return true;
            return false;
        }
    }
}
