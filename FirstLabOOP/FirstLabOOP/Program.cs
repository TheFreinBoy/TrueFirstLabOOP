using System;
using System.Text;
using Name;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Ми маємо рівняння площини Ax + By + Cz + D = 0 ");
        Console.WriteLine("Давайте введемо A, B, C та D:");
        Console.Write("Введіть А: ");
        int A = int.Parse(Console.ReadLine());
        Console.Write("Введіть B: ");
        int B = int.Parse(Console.ReadLine());
        Console.Write("Введіть C: ");
        int C = int.Parse(Console.ReadLine());
        Console.Write("Введіть D: ");
        int D = int.Parse(Console.ReadLine());
        PlaneEquestion plane = new PlaneEquestion(A, B, C, D);
        Console.WriteLine($"Оновлене рівняння площини ({A}x + {B}y + {C}z + {D} = 0)");
        Console.WriteLine("Тепер давайте введемо x y та z:");
        Console.Write("Введіть x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введіть y: ");
        double y = double.Parse(Console.ReadLine());
        Console.Write("Введіть z: ");
        double z = double.Parse(Console.ReadLine());
        double? xIntersection = plane.X;
        double? yIntersection = plane.Y;
        double? zIntersection = plane.Z;

        if (plane.BelongPoints(x, y, z) == true)
        {
            Console.WriteLine($"Точка ({x}, {y}, {z}) належить площині.");
        }
        else
        {
            Console.WriteLine($"Точка ({x}, {y}, {z}) не належить площині.");
        }

        PrintIntersection("X", xIntersection);
        PrintIntersection("Y", yIntersection);
        PrintIntersection("Z", zIntersection);


    }
    static void PrintIntersection(string point, double? intersection)
    {
        switch (intersection)
        {
            case double value when point == "X":
                Console.WriteLine($"Площина перетинає вісь {point} в точці: ({value}, 0, 0)");
                break;
            case double value when point == "Y":
                Console.WriteLine($"Площина перетинає вісь {point} в точці: (0, {value}, 0)");
                break;
            case double value when point == "Z":
                Console.WriteLine($"Площина перетинає вісь {point} в точці: (0, 0, {value})");
                break;
            case null:
                Console.WriteLine($"Площина не перетинає вісь {point}.");
                break;
        }
    }


}
