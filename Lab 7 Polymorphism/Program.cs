using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();  
            Square square = new Square();
            Circle circle = new Circle();
            Parallelogram parallelogram = new Parallelogram();
            Ellipse ellipse = new Ellipse();

            double rectangleArea = rectangle.Area();
            double squareArea = square.Area();
            double circleArea = circle.Area();
            double parallelogramArea = parallelogram.Area();
            double ellipseArea = ellipse.Area();

            Console.WriteLine($"{rectangle.Name} Area: {rectangleArea}");
            Console.WriteLine($"{square.Name} Area: {squareArea}");
            Console.WriteLine($"{circle.Name} Area: {circleArea}");
            Console.WriteLine($"{parallelogram.Name} Area: {parallelogramArea}");
            Console.WriteLine($"{ellipse.Name} Area: {ellipseArea}");
            Console.ReadLine();

            Geometry a = rectangle;

            Geometry b = square;
            Geometry c = circle;
            Geometry d = parallelogram;
            Geometry e = ellipse;

            rectangleArea = a.Area();
            squareArea = b.Area();
            circleArea = c.Area();
            parallelogramArea = d.Area();
            ellipseArea = e.Area();

            Console.WriteLine($"{rectangle.Name} Area: {rectangleArea}");
            Console.WriteLine($"{square.Name} Area: {squareArea}");
            Console.WriteLine($"{circle.Name} Area: {circleArea}");
            Console.WriteLine($"{parallelogram.Name} Area: {parallelogramArea}");
            Console.WriteLine($"{ellipse.Name} Area: {ellipseArea}");
            Console.ReadLine();

        }
    }
}
