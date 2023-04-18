using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_1_2
{
    class Point
    {
        protected int Ax;
        protected int Ay;
        protected int Az;
        // конструктор базового класу
        public Point(int Ax, int Ay, int Az)
        {
            this.Ax = Ax;
            this.Ay = Ay;
            this.Az = Az;
        }
    }
}
