using System;
using System.Numerics;
using System.Security.Cryptography;
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
        public double this[int index]
        {
            get
            {
                return index switch
                {
                    0 => A,
                    1 => B,
                    2 => C,
                    3 => D,
                    _ => throw new IndexOutOfRangeException("Індекс повинен бути 0, 1, 2 або 3.")
                };
            }
            set
            {   
                _ = index switch
                {
                    0 => A = value,
                    1 => B = value,
                    2 => C = value,
                    3 => D = value,
                    _ => throw new IndexOutOfRangeException("Індекс повинен бути 0, 1, 2 або 3.")
                };
            }
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
        public bool BelongPoint  (double x, double y, double z)
        {
            bool chek = A * x + B * y + C * z + D == 0.001;
            
            return chek;
        }
        public override string ToString()
        {
            return $"{A}x + {B}y + {C}z + {D} = 0";
        }
        

        


    }    
}