using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    abstract class Filters
    {
       protected Bitmap resultImage;
       
        public Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
        {
            resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);
            var g = Graphics.FromImage(resultImage);
            g.Clear(Color.White);
            for (int i = 0; i < sourceImage.Width; i++){
                worker.ReportProgress((int)((float)i / resultImage.Width * 100));
                if (worker.CancellationPending)
                    return null;    
                for (int j = 0; j < sourceImage.Height; j++)
                    resultImage.SetPixel(i, j, calculateNewPixelColor(sourceImage, i, j));
            }
            return resultImage;
        }
        protected abstract Color calculateNewPixelColor(Bitmap sourceImage, int i, int j);
        public int Clamp(int value, int min, int max)
        {
            if (value > max) return max;
            if (value < min) return min;
            return value;
        }
    }
}
