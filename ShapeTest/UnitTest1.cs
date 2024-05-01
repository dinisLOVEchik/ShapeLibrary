using NUnit.Framework.Legacy;
using ShapeLibrary;

namespace ShapeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void Circle_CalculateArea_ValidRadius()
        {
            double radius = 5;
            Circle circle = new Circle(radius);
            double area = circle.CalculateArea();

            ClassicAssert.AreEqual(78.5, area);
        }
        [Test]
        //[ExpectedException(typeof(ArgumentOutOfRangeException), AllowDerivedTypes = true)]
        public void Circle_CalculateArea_InvalidRadius()
        {
            double radius = -1;
            ClassicAssert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
        }

        [Test]
        public void Triangle_CalculateArea_ValidSides()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);
            double area = triangle.CalculateArea();
            ClassicAssert.AreEqual(6, area);
        }

        [Test]
        public void Triangle_CalculateArea_InvalidSides()
        {
            double side1 = -1;
            double side2 = 2;
            double side3 = 3;
            Triangle triangle = new Triangle(side1, side2, side3);
            triangle.CalculateArea();
        }

        [Test]
        public void Triangle_CalculateArea_InvalidTriangle()
        {
            double side1 = 1;
            double side2 = 2;
            double side3 = 4;
            Triangle triangle = new Triangle(side1, side2, side3);
            triangle.CalculateArea();
        }

        [Test]
        public void Triangle_IsRightTriangle_RightTriangle()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 5;
            Triangle triangle = new Triangle(side1, side2, side3);
            bool isRightTriangle = triangle.IsRightTriangle(side1, side2, side3);
            ClassicAssert.IsTrue(isRightTriangle);
        }

        [Test]
        public void Triangle_IsRightTriangle_NotRightTriangle()
        {
            double side1 = 3;
            double side2 = 4;
            double side3 = 6;
            Triangle triangle = new Triangle(side1, side2, side3);
            bool isRightTriangle = triangle.IsRightTriangle(side1, side2, side3);
            ClassicAssert.IsFalse(isRightTriangle);
        }
    }
}