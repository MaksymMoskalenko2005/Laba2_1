using Laba2_1_2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Line: Point");
        Console.WriteLine("");
        string pointAx="", pointAy="", pointAz="";
        Console.WriteLine("Введiть координати точки А: ");
        Console.Write("x:");
        pointAx = Console.ReadLine();
        Console.Write("y:");
        pointAy = Console.ReadLine();
        Console.Write("z:");
        pointAz = Console.ReadLine();
        int pointAx2 = Convert.ToInt32(pointAx);
        int pointAy2 = Convert.ToInt32(pointAy);
        int pointAz2 = Convert.ToInt32(pointAz);
        string pointBx = "", pointBy = "", pointBz = "";
        Console.WriteLine("Введiть координати точки B: ");
        Console.Write("x:");
        pointBx = Console.ReadLine();
        Console.Write("y:");
        pointBy = Console.ReadLine();
        Console.Write("z:");
        pointBz = Console.ReadLine();
        int pointBx2 = Convert.ToInt32(pointBx);
        int pointBy2 = Convert.ToInt32(pointBy);
        int pointBz2 = Convert.ToInt32(pointBz);
        Line line = new Line(pointAx2, pointAy2, pointAz2, pointBx2, pointBy2, pointBz2);
        Console.WriteLine("___________________________");
        Console.WriteLine("length:   дiзнатися довжину");
        Console.WriteLine("stop:     зупинити програму");
        Console.WriteLine("___________________________");
        while (true)
        {
            string input;
            input = Console.ReadLine();
            if(input=="length")
            {
                Console.WriteLine(line.lineLength());
            }
            if(input=="stop")
            {
                break;
            }
        }
        Console.WriteLine("Triangle:Line");
        Console.WriteLine("");
        string Ax1="", Ay1 = "", Az1 = "", Bx1 = "", By1 = "", Bz1 = "", Cx1 = "", Cy1 = "", Cz1 = "";
        Console.WriteLine("Введiть координати точки А: ");
        Console.Write("x:");
        Ax1 = Console.ReadLine();
        int Ax2 = Convert.ToInt32(Ax1);
        Console.Write("y:");
        Ay1 = Console.ReadLine();
        int Ay2 = Convert.ToInt32(Ay1);
        Console.Write("z:");
        Az1 = Console.ReadLine();
        int Az2 = Convert.ToInt32(Az1);
        Console.WriteLine("Введiть координати точки B: ");
        Console.Write("x:");
        Bx1 = Console.ReadLine();
        int Bx2 = Convert.ToInt32(Bx1);
        Console.Write("y:");
        By1 = Console.ReadLine();
        int By2 = Convert.ToInt32(By1);
        Console.Write("z:");
        Bz1 = Console.ReadLine();
        int Bz2 = Convert.ToInt32(Bz1);
        Console.WriteLine("Введiть координати точки C: ");
        Console.Write("x:");
        Cx1 = Console.ReadLine();
        int Cx2 = Convert.ToInt32(Cx1);
        Console.Write("y:");
        Cy1 = Console.ReadLine();
        int Cy2 = Convert.ToInt32(Cy1);
        Console.Write("z:");
        Cz1 = Console.ReadLine();
        int Cz2 = Convert.ToInt32(Cz1);
        Triangle triangle = new Triangle(Ax2,Ay2,Az2, Bx2, By2, Bz2, Cx2, Cy2, Cz2);
        if (triangle.exists())
        {
            Console.WriteLine("___________________________");
            Console.WriteLine("length:   дiзнатися довжину сторiн трикутника");
            Console.WriteLine("perimetr: дiзнатися периметр трикутника");
            Console.WriteLine("square:   дiзнатися площу трикутника");
            Console.WriteLine("stop:     зупинити програму");
            Console.WriteLine("___________________________");
        }
        while (true)
        {
            if (triangle.exists())
            {
                string input;
                input = Console.ReadLine();
                if (input=="length")
                {
                    Console.WriteLine("AB: "+triangle.ABlength()+" BC: "+triangle.BClength()+" AC: "+triangle.AClength());
                }
                if(input=="perimetr")
                {
                    Console.WriteLine("Периметр: "+triangle.perimetr());
                }
                if(input=="square")
                {
                    Console.WriteLine("Площа: "+triangle.square());
                }
                if(input=="stop")
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("Трикутник не iснує");
                break;
            }
        }
    }
}
