using System;

namespace ArchitectArithmetic
{
  class Program
  {
    public static void Main(string[] args)
    {

        double materialCost = 180;

       double rectArea = Rect(125500, 00);
       Console.WriteLine($"Rectangle area: {rectArea}");

        double circleArea = Circle(375);
        Console.WriteLine($"Circle area is about {circleArea}");

        double triangleArea = Triangle(750, 500);
        Console.WriteLine($"Triangle has an area of: {triangleArea}");

        double totalArea = rectArea + circleArea / 2 + triangleArea;
        Console.WriteLine($"Total Area is: {totalArea}");

        double totalCost = materialCost * totalArea;
        // double roundedTotalCost = Math.Floor(totalCost * 100) / 100;
        Console.WriteLine($"Total Cost of this job is: {roundedTotalCost} Pesos");

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