using GeometryLibrary.Shapes;

namespace GeometryLibrary
{
    public static class ShapeFactory
    {
        public static IShape CreateCircle(double radius) => new Circle(radius);

        public static IShape CreateTriangle(double a, double b, double c) => new Triangle(a, b, c);

        // Можно добавлять другие фигуры здесь
    }
}
