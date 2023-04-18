using Laba2_1;
class Program
{
    static void Main(string[] args)
    {
        int x = 0;
        int y = 1;
        int z = 2;
        string Ax1 = "", Ay1 = "", Az1 = "", Bx1 = "", By1 = "", Bz1 = "", Cx1 = "", Cy1 = "", Cz1 = "";
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
        int[] A = new int[3];
        A[x] = Ax2;
        A[y] = Ay2;
        A[z] = Az2;
        int[] B = new int[3];
        B[x] = Bx2;
        B[y] = By2;
        B[z] = Bz2;
        int[] C = new int[3];
        C[x] = Cx2;
        C[y] = Cy2;
        C[z] = Cz2;
        Triangle triangle = new Triangle(A, B, C);
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
                if (input == "length")
                {
                    Console.WriteLine("AB: " + triangle.ABlength() + " BC: " + triangle.BClength() + " AC: " + triangle.AClength());
                }
                if (input == "perimetr")
                {
                    Console.WriteLine("Периметр: " + triangle.perimetr());
                }
                if (input == "square")
                {
                    Console.WriteLine("Площа: " + triangle.square());
                }
                if (input == "stop")
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
    
 