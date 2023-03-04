﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class MaxFilter : Filters
    {
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            int radiusX = 3 / 2;
            int radiusY = 3 / 2;
            int q = 0;
            int[] colorsR = new int[9];
            int[] colorsG = new int[9];
            int[] colorsB = new int[9];
            for (int l = -radiusY; l <= radiusY; l++)
                for (int k = -radiusX; k <= radiusX; k++)
                {
                    int idX = Clamp(i + k, 0, sourceImage.Width - 1);
                    int idY = Clamp(j + l, 0, sourceImage.Height - 1);
                    Color neighborColor = sourceImage.GetPixel(idX, idY);
                    colorsR[q] = neighborColor.R;
                    colorsG[q] = neighborColor.G;
                    colorsB[q] = neighborColor.B;
                    q++;
                }
            Sort(colorsR);
            Sort(colorsB);
            Sort(colorsG);
            return Color.FromArgb(colorsR[8], colorsG[8], colorsB[8]);
        }


        private void Swap(ref int x, ref int y)
        {
            int t = x;
            x = y;
            y = t;
        }
        private void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                        Swap(ref arr[i], ref arr[j]);
                }
        }
    }
}
