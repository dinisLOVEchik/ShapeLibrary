

namespace ShapeLibrary
{
    public class Triangle:IShape
    {
        private double _side1;
        private double _side2;
        private double _side3;
        public Triangle(double side1, double side2, double side3) 
        {
            _side1 = side1;
            _side2 = side2;
            _side3 = side3;
        }

        public double CalculateArea()
        {
            double s = (_side1 + _side2 + _side3) / 2;
            return Math.Sqrt(s * (s - _side1) * (s - _side2) * (s - _side3));
        }
        public bool IsRightTriangle(double side1, double side2, double side3)
        {
            return Math.Pow(side1, 2) + Math.Pow(side2, 2) == Math.Pow(side3, 2) ||
                Math.Pow(side2, 2) + Math.Pow(side3, 2) == Math.Pow(side1, 2) ||
                Math.Pow(side3, 2) + Math.Pow(side1, 2) == Math.Pow(side2, 2);
        }
        public bool IsTriangleValid(double side1, double side2, double side3)
        {
            return side1 + side2 > side3 &&
                side2 + side3 > side1 &&
                side3 + side1 > side2;
        }
    }
}
