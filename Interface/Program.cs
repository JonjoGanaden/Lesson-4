using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();
            double a = 10;
            double b = 20;
            double c = 1.0;
            double d = 10;
            double area = 0.0;
            double perimeter = 0.0;

            rec.height = a;
            rec.width = b;

            triangle.height = a;
            triangle.width = b;
            triangle.side = d;

            area = rec.Area();
            Console.WriteLine("Area of Rectangle is : {0:F}", area);
            perimeter = rec.perimeter();
            Console.WriteLine("Perimeter of Rectangle is : {0:F}", perimeter);
            Console.WriteLine("--------------------------");

            Console.WriteLine("Circle area and Perimeter");
            circle.radius = c;
            area = circle.Area();
            Console.WriteLine("Area of a Circle is : {0:F}", area);
            perimeter = circle.perimeter();
            Console.WriteLine("Perimeter of a Circle is : {0:F}", perimeter);
            Console.WriteLine("--------------------------");

            area = triangle.Area();
            Console.WriteLine("Area of Triangle is : {0:F}", area);
            perimeter = triangle.perimeter();
            Console.WriteLine("Perimeter of Triangle is : {0:F}", perimeter);

            Console.ReadLine();
        }
    }
}
