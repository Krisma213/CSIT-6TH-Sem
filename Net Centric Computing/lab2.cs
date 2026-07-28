using System;

class Shape
{
    public virtual double Area()
    {
        return 0;
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Length { get; set; }
    public double Breadth { get; set; }

    public Rectangle(double length, double breadth)
    {
        Length = length;
        Breadth = breadth;
    }

    public override double Area()
    {
        return Length * Breadth;
    }
}

class Program
{
    static void Main()
    {
        Shape s;

        s = new Circle(5);
        Console.WriteLine("Area of Circle = " + s.Area());

        s = new Rectangle(10, 5);
        Console.WriteLine("Area of Rectangle = " + s.Area());
    }
}
