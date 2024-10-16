using System;
using System.Diagnostics;
using System.IO.Compression;
using System.Text;
using Triangle;

namespace Triangle
{
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Введіть три сторони першого трикутника");
        Console.Write("Введіть сторону а:");
        double a = Double.Parse(Console.ReadLine());
        Console.Write("Введіть сторону b:");
        double b = Double.Parse(Console.ReadLine());
        Console.Write("Введіть сторону c:");
        double c = Double.Parse(Console.ReadLine());
        Ttriangle triangle= new Ttriangle(a,b,c);         
        double perimeter = triangle.Perimeter();
        double area = triangle.CalcArea();
        Console.WriteLine($"Периметр трикутника: {perimeter}");
        Console.WriteLine($"Площа трикутника: {area}");
        Console.WriteLine($"Трикутник: {triangle}");
        Console.WriteLine("Введіть три сторони другого трикутника для порівняння"); 
        Console.Write("Введіть сторону а1:");
        double a1 = Double.Parse(Console.ReadLine());
        Console.Write("Введіть сторону b1:");
        double b1 = Double.Parse(Console.ReadLine());
        Console.Write("Введіть сторону c1:");
        double c1 = Double.Parse(Console.ReadLine());
        Ttriangle triangle1 = new Ttriangle(a1,b1,c1);
        Console.WriteLine($"Трикутник 2 : {triangle1}");
        EqualsTriangle(triangle, triangle1);
        Console.Write("Введіть число, яке буде множиться на перший трикутник та потім призма, або навпаки:");
        double number = Double.Parse(Console.ReadLine());
        Ttriangle scaledTriangle1 = number * triangle;  
        Ttriangle scaledTriangle2 = triangle * number;
        Console.WriteLine($"Трикутник, помножений на {number} :" + scaledTriangle1);
        Console.WriteLine($"{number}, помножений на Трикутник :" + scaledTriangle2);
        Console.WriteLine("Тепер ми створюємо пряму призму, в основі якої буде наш перший трикутник");
        Console.Write("Давайте додамо висоту нашої призми: ");
        double height = Double.Parse(Console.ReadLine());
        TtrianglePrizm prizm = new TtrianglePrizm(a, b, c, height);
        Console.WriteLine(prizm);
        TtrianglePrizm prizm1 = new TtrianglePrizm(a1, b1, c1, height);
        Console.WriteLine(prizm1);
        EqualsTPrizm(prizm, prizm1);
        TtrianglePrizm scaledPrizm1 = number * prizm;
        TtrianglePrizm scaledPrizm2 = prizm * number;
        Console.WriteLine($"Призма, помножена на {number} :" + scaledPrizm1);
        Console.WriteLine($"{number}, помножений на Призму :" + scaledPrizm2);
    }
    static void EqualsTriangle(Ttriangle triangle, Ttriangle triangle1)
    {
        if (triangle == triangle1 )
        {
            Console.WriteLine("Трикутники рівні.");
        }
        else
        {
            Console.WriteLine("Трикутники нерівні.");
        }
    }
    static void EqualsTPrizm(TtrianglePrizm prizm, TtrianglePrizm prizm1)
    {
        if (prizm == prizm1)
        {
            Console.WriteLine("Призми рівні.");
        }
        else
        {
            Console.WriteLine("Призми нерівні.");
        }
    }
}
}
