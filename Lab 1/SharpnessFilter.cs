using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{

    internal class SharpnessFilter : MatrixFilter
    {
        public SharpnessFilter()
        {
            float[,] arr = { { -1, -1, -1 }, { -1, 9, -1 }, { -1, -1, -1 } };
            kernel = arr;
            
        }
    }
}
