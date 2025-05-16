using System;

class Program
{
    static void Main(string[] args)
    {
        string name = UserName();
        Console.WriteLine($"Your name is {name}");
        
        int number = PromptUserNumber();
        Console.WriteLine($"Your number is {number}");

        int squarednumber = SquareNumber(number);
        Console.WriteLine($"{name}, your number is {number}. This is it squared: {squarednumber}");
    }

    static int PromptUserNumber()
    {
        Console.Write("Enter your favorite number ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static string UserName()
    {
        Console.Write("Enter your name ");
        string name = (Console.ReadLine());
        return name;
    }

    static int SquareNumber(int number)
    {
        int squarednumber = number * number;
        return squarednumber;
    }
}