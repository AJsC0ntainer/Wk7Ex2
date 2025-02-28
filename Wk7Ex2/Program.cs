using System;

namespace Wk7Ex2
{
    class Program
    {
        internal abstract class Shape
        {
            public abstract void CalculateArea();
        }
        class Circle : Shape
        {
            private double radius;

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public override void CalculateArea()
            {
                double area = 3.14 * radius * radius;
                Console.WriteLine($"Area of a Circle: {area}");
            }
        }
        class Rectangle : Shape
        {
            private double length;
            private double width;

            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }
            public override void CalculateArea()
            {
                double area = length * width;
                Console.WriteLine($"Area of a Rectangle: {area}");
            }
        }
        class Triangle : Shape
        {
            private double baseSize;
            private double height;
            private double constant = 0.5;

            public Triangle(double baseSize, double height)
            {
                this.baseSize = baseSize;
                this.height = height;
            }
            public override void CalculateArea()
            {
                double area = constant * baseSize * height;
                Console.WriteLine($"Area of a Triangle: {area}");
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("AREA OF A CIRCLE, A RECTANGLE AND A TRIANGLE");
            Console.WriteLine("--------------------------------------------");
            Circle myCircle = new Circle(5);
            myCircle.CalculateArea();

            Rectangle myRectangle = new Rectangle(5, 10);
            myRectangle.CalculateArea();

            Triangle myTriangle = new Triangle(5, 10);
            myTriangle.CalculateArea();

            //Styling.
            Console.WriteLine();
            //Signal the end of the program to the user.
            Console.WriteLine("End of the program, Press Any Key to Exit...");
            //Read the key input and exit
            Console.ReadLine();

            //Pushed to GitHub Repo Wk7Ex2




        }
    }
}