using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class SourceFilter : Filters
    {
        private Color col1;
        private Color col2;
        public SourceFilter(Color col1, Color col2)
        {
            this.col1 = col1;   
            this.col2 = col2;   
        }

        protected override Color calculateNewPixelColor(Bitmap sourceImage, int i, int j)
        {
            Color col = sourceImage.GetPixel(i, j);
            return Color.FromArgb(col.R * col2.R / col1.R, col.G * col2.G / col1.G, col.B * col2.B / col1.B);
        }
    }
}
