using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {
       double rectArea = Rect(4, 5);
       Console.WriteLine($"Rectabgle area: {rectArea}");

        double circleArea = Circle(4);
        Console.WriteLine($"Circle area is about {circleArea}");

        double triangleArea = Triangle(10, 9);
        Console.WriteLine($"Triangle has an area of: {triangleArea}");

    }

    static double Rect(double length, double width) {
            double area = length * width;
            return area;
    }

    static double Circle(double radius) {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
    }

    static double Triangle(double bottom, double height) {
        double area = 0.5 * bottom * height;
        return area;
    }

  }
}