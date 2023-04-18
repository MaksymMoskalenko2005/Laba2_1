using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_1_2
{
    internal class Triangle:Line
    {
        protected int Cx;
        protected int Cy;
        protected int Cz;
        // конструктор похідного класу 2(Від похідного класу 1)
        public Triangle(int Ax, int Ay, int Az, int Bx, int By, int Bz, int Cx, int Cy, int Cz) : base(Ax, Ay, Az, Bx, By, Bz)
        {
            this.Cx = Cx;
            this.Cy = Cy;
            this.Cz = Cz;
        }
        public double ABlength()
        {
            return Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
        }
        public double AClength()
        {
            return Math.Sqrt(Math.Pow(Cx - Ax, 2) + Math.Pow(Cy - Ay, 2) + Math.Pow(Cz - Az, 2));
        }
        public double BClength()
        {
            return Math.Sqrt(Math.Pow(Cx - Bx, 2) + Math.Pow(Cy - By, 2) + Math.Pow(Cz - Bz, 2));
        }
        // методи знаходження площі та периметру
        public double perimetr()
        {
            return ABlength() + AClength() + BClength();
        }
        public bool exists()
        {
            if ((ABlength() + AClength() > BClength()) && (ABlength() + BClength() > AClength()) && (BClength() + AClength() > ABlength()))
            {
                return true;
            }
            else return false;
        }
        public double square()
        {
            return Math.Sqrt(0.5 * perimetr() * (0.5 * perimetr() - ABlength()) * (0.5 * perimetr() - AClength()) * (0.5 * perimetr() - BClength()));
        }
    }
}
