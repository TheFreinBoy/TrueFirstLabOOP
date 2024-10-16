using System;
using Triangle;
namespace Triangle
{
    public class Ttriangle
    {
        protected double a, b, c;

        public Ttriangle()
        {
            a = 1;
            b = 1;
            c = 1;
        }

        public Ttriangle(double a, double b, double c)
        {
            Exceptions(a, b, c);
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Ttriangle(Ttriangle other)
        {
            this.a = other.a;
            this.b = other.b;
            this.c = other.c;
        }
        public double[] GetSortedSides()
        {
            double[] sides = { a, b, c };
            Array.Sort(sides);
            return sides;
        }

        public double A
        {
            get { return a; }
            set {
                if (Exist(value, b, c))
                {
                    a = value;
                }
                else Exceptions(a, b, c);
            }
        }

        public double B
        {
            get { return b; }
            set {
                if (Exist(value, a, c))
                {
                    b = value;
                }
                else Exceptions(a, b, c);
            }
        }

        public double C
        {
            get { return c; }
            set {
                if (Exist(value, b, a))
                {
                    c = value;
                }
                else Exceptions(a, b, c);
            }
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        public double CalcArea()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public void Exceptions(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Сторони повинні бути додатніми");
            }
            if (a >= b + c || b >= a + c || c >= a + b)
            {
                throw new ArgumentException("Такого трикутника не існує");
            }
        }

        public bool Exist(double a, double b, double c)
        {
            return (a < b + c && b < a + c && c < a + b);
        }

       public static bool operator ==(Ttriangle t1, Ttriangle t2)
        {
            if (t1 is null || t2 is null)
            {
                return false;
            }
            double[] sortedSides1 = t1.GetSortedSides();
            double[] sortedSides2 = t2.GetSortedSides();

            return sortedSides1[0] == sortedSides2[0] &&
                   sortedSides1[1] == sortedSides2[1] &&
                   sortedSides1[2] == sortedSides2[2];
        }

        public static bool operator !=(Ttriangle t1, Ttriangle t2)
        {
            return !(t1 == t2);
        }      
        public override bool Equals(object? triangle1)
        {            
            if (triangle1 is Ttriangle otherTriangle)
            {
                
                return this == otherTriangle;
            }
            
           
            return false;
        }
        public override int GetHashCode()
        {           
            return HashCode.Combine(a, b, c);
        }
      
        public override string ToString()
        {
            return $"a = {a}, b = {b}, c = {c}, Периметр = {Perimeter()}, Площа = {CalcArea()}";
        }

        public static Ttriangle operator *(double number, Ttriangle triangle)
        { 
            return new Ttriangle(triangle.a * number, triangle.b * number, triangle.c * number);
        }
        public static Ttriangle operator *(Ttriangle triangle, double number)
        {
            return new Ttriangle(triangle.a * number, triangle.b * number, triangle.c * number);
        }     
    }
}

