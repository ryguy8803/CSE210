using System;

class Car
{
    // These are the pieces of information (data) a Car has
    public string Color;  // Like 'Red', 'Blue'
    public int Speed;     // Like 0, 60, 100
    public string Model;  // Like 'Sedan', 'SUV'

    // This is a special function called a 'constructor'.
    // It's like the assembly instructions for when you first build a Car.
    // It sets up the initial values.
    public Car(string carColor, string carModel)
    {
        Color = carColor; // Set the Car's color
        Model = carModel; // Set the Car's model
        Speed = 0;        // All new cars start at 0 speed
    }

    // These are actions (methods/functions) a Car can do
    public void StartEngine()
    {
        Console.WriteLine("Engine started!");
    }

    public void Accelerate(int amount)
    {
        Speed += amount; // Increase the speed by 'amount'
        Console.WriteLine($"Accelerating! Current speed: {Speed} mph");
    }

    public void Honk()
    {
        Console.WriteLine("Beep! Beep!");
    }
}