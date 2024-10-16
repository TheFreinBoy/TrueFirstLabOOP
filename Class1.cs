using System.Buffers.Binary;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using Triangle; 

namespace TriangleTests
{
    [TestFixture]
    public class TtriangleTests
    {
        [Test]
        public void Perimeter_CorrectPerimeter_ReturnsExpectedValue() 
        {
            
            double a =3,b =4,c=5;
            
            double result = a + b + c;
            
            ClassicAssert.AreEqual(12, result);
            
        }     

        [Test]
        public void CalcArea_CorrectArea_ReturnsExpectedValue() //1
        {
            Ttriangle triangle = new Ttriangle(3, 4, 5);

            double result = triangle.CalcArea();

            ClassicAssert.AreEqual(6, result); 
        }

        [Test]
        public void CalcArea2_CorrectArea_ReturnsExpectedValue() //2
        {
            double a =8, b =10 , c =9;
            Ttriangle triangle = new Ttriangle(a, b, c);
            double p = (a + b + c)/2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            double actual = triangle.CalcArea();

            ClassicAssert.AreEqual(area, actual); 
        }
        

        [Test]
        public void OperatorEquals_TrianglesAreEqual_ReturnsTrue()
        {           
            Ttriangle triangle1 = new Ttriangle(3, 4, 5);
            Ttriangle triangle2 = new Ttriangle(3, 4, 5);
        
            ClassicAssert.IsTrue(triangle1 == triangle2);
            
        }

        [Test]
        public void OperatorNotEquals_TrianglesAreNotEqual_ReturnsTrue()
        {
            
            Ttriangle triangle1 = new Ttriangle(3, 4, 5);
            Ttriangle triangle2 = new Ttriangle(3, 4, 4);

            
            ClassicAssert.IsTrue(triangle1 != triangle2);
        }

        [Test]
        public void OperatorMultiply_TriangleMultipliedByNumber_ReturnsScaledTriangle()
        {
            
            Ttriangle triangle = new Ttriangle(3, 4, 5);
            double number = 2;
           
            Ttriangle actual = triangle * number;

            
            ClassicAssert.AreEqual(new Ttriangle(6, 8, 10), actual);
        }

        [Test]
        public void OperatorMultiply_NumberMultipliedByTriangle_ReturnsScaledTriangle()
        {
            
            Ttriangle triangle = new Ttriangle(3, 4, 5);
            double number = 2;
            
            Ttriangle result = number * triangle;

           
            ClassicAssert.AreEqual(new Ttriangle(6, 8, 10), result);
        }
    }

    [TestFixture]
    public class TtrianglePrizmTests
    {
        [Test]
        public void Volume_CorrectVolume_ReturnsExpectedValue()
        {
            
            double a =8, b =10 , c =9, d = 10;
            TtrianglePrizm prizm = new TtrianglePrizm(a, b, c, d);
            double p = (a + b + c)/2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            double result = area * 10;
            double actual = prizm.Volume();                      
            
            ClassicAssert.AreEqual(result, actual ); 
        }

        [Test]
        public void SurfaceArea_CorrectSurfaceArea_ReturnsExpectedValue()
        {
        
            double a =3, b =4 , c =5, h = 10;
            TtrianglePrizm prizm = new TtrianglePrizm(a, b, c, h);
            double p = (a + b + c)/2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));        
            double lateralSurfaceArea = (a+b+c) * h;
            double actual = 2 * area + lateralSurfaceArea;
            double result = prizm.SurfaceArea();
        
            ClassicAssert.AreEqual(result, actual); 
        }

        [Test]
        public void InvalidHeight_ThrowsArgumentException()
        {
            
            Assert.Throws<ArgumentException>(() => new TtrianglePrizm(3, 4, 5, -1));
        }
    }
}
