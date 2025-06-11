using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Mindfulness Program!");
            Console.WriteLine("<1> Start breathing activity");
            Console.WriteLine("<2> Start reflection activity");
            Console.WriteLine("<3> Start listening activity");
            Console.WriteLine("<4> Quit");
            Console.WriteLine("Enter option here:");
            int choice = int.Parse(Console.ReadLine());
            HandelMenuChoice(choice);

            if (choice == 4)
            {
                break;
            }
        }

    }
    static void HandelMenuChoice(int choice)
    {
        if (choice == 1)
        {
            BreathingActivity breathingActivity = new BreathingActivity();
            breathingActivity.RunActivity();
        }

        if (choice == 2)
        {
            ReflectionActivity reflectionActivity = new ReflectionActivity();
            reflectionActivity.RunActivity();
        }

        if (choice == 3)
        {
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.RunActivity();
        }
    }
}