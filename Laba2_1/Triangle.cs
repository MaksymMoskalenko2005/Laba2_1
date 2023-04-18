using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_1
{
    internal class Triangle:Figure
    {
        public Triangle(int[] A, int[] B, int[] C) : base(A, B, C)
        {

        }
        public double perimetr()
        {
            double perimetr = BClength() + ABlength() + AClength();
            return perimetr;
        }
        public double square()
        {
            double square = Math.Sqrt(0.5 * perimetr() * (0.5 * perimetr() - ABlength()) * (0.5 * perimetr() - AClength()) * (0.5 * perimetr() - BClength()));
            return square;
        }
        public bool exists()
        {
            if ((ABlength() + AClength() > BClength()) && (ABlength() + BClength() > AClength()) && (BClength() + AClength() > ABlength()))
            {
                return true;
            }
            else return false;
        }
    }
}
