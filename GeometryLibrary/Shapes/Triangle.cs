
namespace GeometryLibrary.Shapes
{
    public class Triangle : IShape
    {
        private readonly double _a;
        private readonly double _b;
        private readonly double _c;

        public Triangle(double a, double b, double c)
        {
            if (IsTriangle(a, b, c))
            {
                _a = a;
                _b = b;
                _c = c;
            }
        }

        private bool IsTriangle(double a, double b, double c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Стороны не образуют треугольник");
            }
            else
            {
                return true;
            }
        }

        public double Area
        {
            get
            {
                double s = (_a + _b + _c) / 2;
                return Math.Sqrt(s * (s - _a) * (s - _b) * (s - _c));
            }
        }

        public bool IsRightAngled()
        {
            var sides = new[] { _a, _b, _c };
            Array.Sort(sides);
            return Math.Abs(Math.Pow(sides[2], 2) - (Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2))) < 1e-10;
        }
    }
}
