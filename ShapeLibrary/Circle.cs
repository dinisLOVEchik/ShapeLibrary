

namespace ShapeLibrary
{
    public class Circle : IShape
    {
        private double _radius;
        public Circle(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(radius), "Радиус должен быть больше нуля!");
            }
            _radius = radius;
        }

        public double CalculateArea()
        {
            return Math.Round(Math.Pow(_radius, 2) * Math.PI, 1);
        }
    }
}
