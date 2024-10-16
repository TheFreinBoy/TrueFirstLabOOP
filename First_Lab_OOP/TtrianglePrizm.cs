using System;
using Triangle;

namespace Triangle
{
   public class TtrianglePrizm : Ttriangle
    {
        protected double height;

        public TtrianglePrizm(double a, double b, double c, double height) : base(a, b, c)
        {
            if (height <= 0)
            {
                throw new ArgumentException("Висота призми повинна бути додатною");
            }
            this.height = height;
        }

        public double Height
        {
            get { return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Висота призми повинна бути додатною");
                }
                height = value;
            }
        }

        public double Volume()
        {
            
            return CalcArea() * height;
        }

        public double SurfaceArea()
        {
            // S поверхні = 2 * S основи + S бічних поверхонь
            double baseArea = CalcArea(); 
            double lateralSurfaceArea = Perimeter() * height; 
            return 2 * baseArea + lateralSurfaceArea;
        }
        
         public static bool operator ==(TtrianglePrizm p1, TtrianglePrizm p2)
        {
            if (p1 is null || p2 is null)
                return false;

            double[] sortedBaseSides1 = p1.GetSortedSides();
            double[] sortedBaseSides2 = p2.GetSortedSides();

            return sortedBaseSides1[0] == sortedBaseSides2[0] &&
                   sortedBaseSides1[1] == sortedBaseSides2[1] &&
                   sortedBaseSides1[2] == sortedBaseSides2[2] &&
                   p1.height == p2.height; 
        }

        public static bool operator !=(TtrianglePrizm p1, TtrianglePrizm p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            if (obj is TtrianglePrizm otherPrism)
            {
                return this == otherPrism;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return (a, b, c, height).GetHashCode();
        }

        public static TtrianglePrizm operator *(double number, TtrianglePrizm prizm)
        { 
            return new TtrianglePrizm(prizm.a * number, prizm.b * number, prizm.c * number, number * prizm.height);
        }
        public static TtrianglePrizm operator *(TtrianglePrizm triangle, double number)
        {
            return new TtrianglePrizm(triangle.a * number, triangle.b * number, triangle.c * number, triangle.height * number);
        }   
        public override string ToString()
        {
            return $"Пряма призма з трикутною основою: \n" +
                   $"Основний трикутник: a = {a}, b = {b}, c = {c}, Периметр = {Perimeter()}, Площа основи = {CalcArea()}\n" +
                   $"Висота призми: {height}, Об'єм призми: {Volume()}, Площа поверхні призми: {SurfaceArea()}";
        }  

    }
}
