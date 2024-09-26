using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

/*Реалізувати клас, що представляє рівняння площини ( Ax + By + Cz + D = 0 ) і містить опис індексатора для доступу до коефіцієнтів цього рівняння. Передбачити 
  методи введеня/виведення, знаходження точки перетину з осями координат та метод перевірки належності точки площині.*/
namespace Name
{
    class PlaneEquestion
    {
        protected double A, B, C, D;

        public PlaneEquestion(double A, double B, double C, double D)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.D = D;

        }
        public double? X
        {
            get
            {
                if (A != 0)
                    return -D / A;
                else
                    return null;
            }
        }
        public double? Y
        {
            get
            {
                if (B != 0)
                    return -D / B;
                else
                    return null;
            }
        }
        public double? Z
        {
            get
            {
                if (C != 0)
                    return -D / C;
                else
                    return null;
            }
        }
        public bool BelongPoints(double x, double y, double z)
        {
            bool chek = A * x + B * y + C * z + D == 0;

            return chek;
        }
        public override string ToString()
        {
            return $"{A}x + {B}y + {C}z + {D} = 0";
        }





    }
}