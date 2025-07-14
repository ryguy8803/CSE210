using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address lectureAddress = new Address("123 University Ave", "Rexburg", "ID", "USA");
        Address receptionAddress = new Address("456 Grand Ballroom", "Metropolis", "NY", "USA");
        Address outdoorAddress = new Address("789 Lakeside Park", "Green Valley", "WA", "USA");

        // Create events
        Lecture lectureEvent = new Lecture("The Future of AI", "An insightful talk on artificial intelligence.",
                                           "2025-08-15", "10:00 AM", lectureAddress, "Dr. Ada Lovelace", 100);

        Reception receptionEvent = new Reception("Annual Military Gala", "Join us for an evening of networking and fine dining.",
                                               "2025-09-20", "6:00 PM", receptionAddress, "rsvp@company.com");

        OutdoorGathering outdoorEvent = new OutdoorGathering("Summer Music Festival", "Enjoy live music and food trucks under the sun.",
                                                           "2025-07-25", "2:00 PM", outdoorAddress, "Sunny with a high of 85°F");

        // Display marketing messages for each event
        Console.WriteLine("--- Lecture Event Marketing ---");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine("\n--- Reception Event Marketing ---");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine("\n--- Outdoor Gathering Event Marketing ---");
        Console.WriteLine("\nStandard Details:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}

