using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("What is the Magic number: ");
        // int answer = int.Parse(Console.ReadLine());
       
        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1, 11);
        int guess = -1;

        while (answer != guess)
        {
            Console.Write("What is your guess: ");
            guess = int.Parse(Console.ReadLine());
        
        
            if (answer > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (answer < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("You got it");
            }
        }

    }

}