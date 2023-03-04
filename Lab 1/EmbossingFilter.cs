﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class EmbossingFilter : Filters
    {
        private float[,] kernel = { { 0, 1, 0 }, { 1, 0, -1 }, { 0, -1, 0 } };
        public EmbossingFilter()
        {

        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            float resultR = 0, resultG = 0, resultB = 0;
            int radiusX = kernel.GetLength(0) / 2; 
            int radiusY = kernel.GetLength(1) / 2;  

            for (int l = -radiusY; l <= radiusY; l++)
            {
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(i + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(j + l, 0, sourceImage.Height - 1);

                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    Color resultColor = Color.FromArgb(
                                               (int)(0.36 * neighborColor.R) +
                                               (int)(0.53 * neighborColor.G) +
                                               (int)(0.11 * neighborColor.B),

                                               (int)(0.36 * neighborColor.R) +
                                               (int)(0.53 * neighborColor.G) +
                                               (int)(0.11 * neighborColor.B),

                                               (int)(0.36 * neighborColor.R) +
                                               (int)(0.53 * neighborColor.G) +
                                               (int)(0.11 * neighborColor.B));

                    resultR += resultColor.R * kernel[k + radiusX, l + radiusY];
                    resultG += resultColor.G * kernel[k + radiusX, l + radiusY];
                    resultB += resultColor.B * kernel[k + radiusX, l + radiusY];
                }
            }

            return Color.FromArgb(
                Clamp((((int)resultR + 255) / 2), 0, 255),
                Clamp((((int)resultG + 255) / 2), 0, 255),
                Clamp((((int)resultB + 255) / 2), 0, 255));
        }
    }
}
