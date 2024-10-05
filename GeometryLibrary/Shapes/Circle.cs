
namespace GeometryLibrary.Shapes
{
    public class Circle : IShape
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            if (IsPositiveRadius(radius))
            {
            _radius = radius;
            }
        }

        private bool IsPositiveRadius(double radius)
        {
            if (radius > 0)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Радиус должен быть больше нуля");
            }
        }

        public double Area => Math.PI * _radius * _radius;
    }
}
