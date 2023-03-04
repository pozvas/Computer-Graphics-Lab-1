using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class SobelFilter : Filters
    {
        // применить обе матрицы и быбрать больший цвет
        float[,] kernelY = { { -1, -2, -1 }, { 0, 0, 0 }, { 1, 2, 1 } };
        float[,] kernelX = { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
        bool flag = true;
        public SobelFilter()
        {

        }
        public SobelFilter(bool _flag)
        {
            flag = _flag;
        }
        public SobelFilter(float[,] a, float[,] b)
        {
            kernelX = a;
            kernelY = b;
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            
            float resultRY = 0, resultGY = 0, resultBY = 0;
            int radiusX1 = kernelY.GetLength(0) / 2;
            int radiusY1 = kernelY.GetLength(1) / 2;
            
            float resultRX = 0, resultGX = 0, resultBX = 0;
            int radiusX2 = kernelX.GetLength(0) / 2;
            int radiusY2 = kernelX.GetLength(1) / 2;


            for (int l = -radiusY1; l <= radiusY1; l++)
            {
                for (int k = -radiusX1; k <= radiusX1; k++)
                {
                    int idX1 = Clamp(i + k, 0, sourceImage.Width - 1);
                    int idY1 = Clamp(j + l, 0, sourceImage.Height - 1);

                    Color neighborColor = sourceImage.GetPixel(idX1, idY1);

                    resultRY += neighborColor.R * kernelY[k + radiusX1, l + radiusY1];
                    resultGY += neighborColor.G * kernelY[k + radiusX1, l + radiusY1];
                    resultBY += neighborColor.B * kernelY[k + radiusX1, l + radiusY1];
                }
            }

            for (int l = -radiusY2; l <= radiusY2; l++)
            {
                for (int k = -radiusX2; k <= radiusX2; k++)
                {
                    int idX2 = Clamp(i + k, 0, sourceImage.Width - 1);
                    int idY2 = Clamp(j + l, 0, sourceImage.Height - 1);

                    Color neighborColor = sourceImage.GetPixel(idX2, idY2);

                    resultRX += neighborColor.R * kernelX[k + radiusX2, l + radiusY2];
                    resultGX += neighborColor.G * kernelX[k + radiusX2, l + radiusY2];
                    resultBX += neighborColor.B * kernelX[k + radiusX2, l + radiusY2];
                }
            }
            float resultR = (float)Math.Sqrt(Math.Pow(resultRX, 2) + Math.Pow(resultRY, 2));
            float resultG = (float)Math.Sqrt(Math.Pow(resultGX, 2) + Math.Pow(resultGY, 2));
            float resultB = (float)Math.Sqrt(Math.Pow(resultGX, 2) + Math.Pow(resultGY, 2));
            if (flag)
                return Color.FromArgb(
                    Clamp(
                        (int)(0.36 * resultR) +
                        (int)(0.53 * resultG) +
                        (int)(0.11 * resultB), 0, 255),
                    Clamp(
                        (int)(0.36 * resultR) +
                        (int)(0.53 * resultG) +
                        (int)(0.11 * resultB), 0, 255),
                    Clamp(
                        (int)(0.36 * resultR) +
                        (int)(0.53 * resultG) +
                        (int)(0.11 * resultB), 0, 255));
            else
                return Color.FromArgb(Clamp((int)resultR, 0, 255), Clamp((int)resultG, 0, 255), Clamp((int)resultB, 0, 255));
        }
    }
}
