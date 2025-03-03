using System;

namespace Wk7Ex2
{
    class Program
    {
        //Abstract class Shape.
        internal abstract class Shape
        {
            //Abstract method CalculateArea.
            public abstract void CalculateArea();
        }
        //Class Circle that inherits from Shape.
        class Circle : Shape
        {
            //Private variable radius.
            private double radius;
            //Constructor of the class Circle.
            public Circle(double radius)
            {
                this.radius = radius;
            }
            //Method CalculateArea that overrides the abstract method CalculateArea of the class Shape.
            public override void CalculateArea()
            {
                //Calculates the area of a circle.
                double area = 3.14 * radius * radius;
                //Prints the area of a circle.
                Console.WriteLine($"Area of a Circle: {area}");
            }
        }
        //Class Rectangle that inherits from Shape.
        class Rectangle : Shape
        {
            //Private variables length.
            private double length;
            //Private variables width.
            private double width;
            //Constructor of the class Rectangle.
            public Rectangle(double length, double width)
            {
                this.length = length;
                this.width = width;
            }
            //Method CalculateArea that overrides the abstract method CalculateArea of the class Shape.
            public override void CalculateArea()
            {
                //Calculates the area of a rectangle.
                double area = length * width;
                //Prints the area of a rectangle.
                Console.WriteLine($"Area of a Rectangle: {area}");
            }
        }
        //Class Triangle that inherits from Shape.
        class Triangle : Shape
        {
            //Private variables baseSize.
            private double baseSize;
            //Private variables height.
            private double height;
            //Private variables constant.
            private double constant = 0.5;
            //Constructor of the class Triangle.
            public Triangle(double baseSize, double height)
            {
                this.baseSize = baseSize;
                this.height = height;
            }
            //Method CalculateArea that overrides the abstract method CalculateArea of the class Shape.
            public override void CalculateArea()
            {
                //Calculates the area of a triangle.
                double area = constant * baseSize * height;
                //Prints the area of a triangle.
                Console.WriteLine($"Area of a Triangle: {area}");
            }
        }
        //Main method.
        static void Main(string[] args)
        {
            //Styling.
            Console.WriteLine("--------------------------------------------");
            //Styling.
            Console.WriteLine("AREA OF A CIRCLE, A RECTANGLE AND A TRIANGLE");
            //Styling.
            Console.WriteLine("--------------------------------------------");
            //Instanciacion of the objects myCircle.
            Circle myCircle = new Circle(5);
            //Calls the method CalculateArea of myCircle.
            myCircle.CalculateArea();
            //Instanciacion of the objects myRentangle.
            Rectangle myRectangle = new Rectangle(5, 10);
            //Calls the method CalculateArea of myRectangle.
            myRectangle.CalculateArea();
            //Instanciacion of the objects myTriangle.
            Triangle myTriangle = new Triangle(5, 10);
            //Calls the method CalculateArea of myTriangle.
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