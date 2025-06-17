using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.Color;
            double area = s.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}
public abstract class Shape
{
    public string Color { get; set; }
    public abstract double GetArea();
    public Shape(string color)
    {
        Color = color;
    }
}

public class Square : Shape
{
    public double Side { get; set; }

    public Square(string color, double side) : base(color)
    {
        Side = side;
    }
    public override double GetArea()
    {
        return Side * Side;
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(string color, double length, double width) : base(color)
    {
        Length = length;
        Width = width;
    }
    public override double GetArea()
    {
        return Length * Width;
    }
}
public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(string color, double radius) : base(color)
    {
        Radius = radius;
    }

    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}
