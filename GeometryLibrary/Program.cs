using GeometryLibrary.Shapes;

namespace GeometryLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            double r = 10;
            var circle = ShapeFactory.CreateCircle(r);
            Console.WriteLine($"Площадь круга с радиусом {r} = {circle.Area}");


            double a = 5, b = 4, c = 3;
            var triangle = (Triangle)ShapeFactory.CreateTriangle(a, b, c);
            Console.WriteLine($"\nПлощадь треугольника со сторонами {a}, {b} и {c} = {triangle.Area}");
            Console.WriteLine(triangle.IsRightAngled()?"Прямоугольный":"Не прямоугольный");

            a = 5;
            b = 5;
            c = 3;
            triangle = (Triangle)ShapeFactory.CreateTriangle(a, b, c);
            Console.WriteLine($"\nПлощадь треугольника со сторонами {a}, {b} и {c} = {triangle.Area}");
            Console.WriteLine(triangle.IsRightAngled() ? "Прямоугольный" : "Не прямоугольный");

            Console.ReadLine();
        }
    }
}
