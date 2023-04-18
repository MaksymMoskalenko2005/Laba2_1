using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_1_2
{
    internal class Line:Point
    {
        protected int Bx;
        protected int By;
        protected int Bz;
        // конструктор похідного класу 1
        public Line(int Ax, int Ay, int Az, int Bx, int By, int Bz) : base(Ax, Ay, Az)
        {
            this.Bx = Bx;
            this.By = By;
            this.Bz = Bz;
        }
        // метод знаходження довжини лінії
        public double lineLength()
        {
            double result;
            result = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));
            return result;
        }
    }
}
