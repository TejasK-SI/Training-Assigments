using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeHierarchy_Assgn3
{
    public interface IShape
    {
        public double CalculateArea();

        public double CalculatePerimeter();
    }

    class Circle : IShape
    {
        public double Radius
        {
            get;
        }

        public Circle(double radius)
        {
            this.Radius = radius;         
        }

        public double CalculateArea()
        {
            return Math.Round(Math.PI * Radius * Radius,2);
        }

        public double CalculatePerimeter()
        {
            return Math.Round(2 * Math.PI * Radius);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Details of Circle: ");
            Console.WriteLine("Area : " + CalculateArea());
            Console.WriteLine("Perimeter : " + CalculatePerimeter());
            Console.WriteLine();
        }
    }

    class Rectangle : IShape
    {
        public double Length { get; }

        public double Width { get; }

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double CalculateArea()
        {
            return Math.Round(Length * Width,2);
        }

        public double CalculatePerimeter()
        {
            return Math.Round(2 * ( Length + Width ));
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Details of Rectangle: ");
            Console.WriteLine("Area : " + CalculateArea());
            Console.WriteLine("Perimeter : " + CalculatePerimeter());
            Console.WriteLine();
        }
    }

    class Triangle : IShape
    {
        public double Side1 { get; }

        public double Side2 { get; }

        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double CalculateArea()
        {
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Round(Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3)));
        }

        public double CalculatePerimeter()
        {
            return Math.Round(Side1 + Side2 + Side3);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Details of Triangle: ");
            Console.WriteLine("Area of : " + CalculateArea());
            Console.WriteLine("Perimeter : " + CalculatePerimeter());
            Console.WriteLine();
        }
    }
}
