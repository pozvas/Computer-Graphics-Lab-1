using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class IncreasingFIlter : Filters
    {
        private float[,] _struct = {};
        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            return new Color();

        }
    }
}
