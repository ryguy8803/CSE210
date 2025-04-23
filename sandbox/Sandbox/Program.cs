using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("please enter the radious: ");
        string text = Console.ReadLine();
        double radius = double.Parse(text);

        double area = Math.PI * radius * radius;
        
        Console.WriteLine($"Hello {area} Sandbox World!");
    
    }
}