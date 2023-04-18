using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_1
{
    class Figure
    {
        int x = 0;
        int y = 1;
        int z = 2;
        public int[] cordA = new int[3];
        public int[] cordB = new int[3];
        public int[] cordC = new int[3];
        public Figure(int[] A, int[]B, int[]C)
        {
            this.cordA = A;
            this.cordB = B;
            this.cordC = C;
        }
        public double ABlength()
        {
            double x1mx2 = cordB[x] - cordA[x];
            double y1my2 = cordB[y] - cordA[y];
            double z1mz2 = cordB[z] - cordA[z];
            return(double) Math.Sqrt(Math.Pow(x1mx2, 2) + Math.Pow(y1my2, 2) + Math.Pow(z1mz2, 2));
        }
        public double AClength()
        {
            double x1mx2 = cordC[x] - cordA[x];
            double y1my2 = cordC[y] - cordA[y];
            double z1mz2 = cordC[z] - cordA[z];
            return (double)Math.Sqrt(Math.Pow(x1mx2, 2) + Math.Pow(y1my2, 2) + Math.Pow(z1mz2, 2));
        }
        public double BClength()
        {
            double x1mx2 = cordC[x] - cordB[x];
            double y1my2 = cordC[y] - cordB[y];
            double z1mz2 = cordC[z] - cordB[z];
            return (double)Math.Sqrt(Math.Pow(x1mx2, 2) + Math.Pow(y1my2, 2) + Math.Pow(z1mz2, 2));
        }
    }
}
