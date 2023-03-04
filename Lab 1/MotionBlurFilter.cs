using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    internal class MotionBlurFilter : MatrixFilter
    {
        public MotionBlurFilter()
        {
            float n = 5;
            kernel = new float[(int)n, (int)n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    kernel[i, j] = 1f / (float)(n * n);
                }
            }
        }
    }
}
