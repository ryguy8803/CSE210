using System;

public class Program
{
    public static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running run1 = new Running("03 Nov 2022", 30, 3.0);
        Cycling cycle1 = new Cycling("04 Nov 2022", 60, 15.0);
        Swimming swim1 = new Swimming("05 Nov 2022", 45, 60);

        Running run2 = new Running("10 Nov 2022", 45, 5.2);
        Cycling cycle2 = new Cycling("11 Nov 2022", 90, 18.0);
        Swimming swim2 = new Swimming("12 Nov 2022", 30, 40);

        activities.Add(run1);
        activities.Add(cycle1);
        activities.Add(swim1);
        activities.Add(run2);
        activities.Add(cycle2);
        activities.Add(swim2);

        Console.WriteLine("--- Fitness Activity Summary ---");
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}