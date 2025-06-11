
public class ListingActivity : Activity
{
    private List<string> _prompts;
    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }
    public void RunActivity()
    {
        Random random = new Random();
        DisplayStartingMessage();
        Console.WriteLine($"\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");
        Console.Write("You may begin in: ");
        ShowCountdown(5);
        Console.WriteLine();
        Console.WriteLine("Start listing items:");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        int itemCount = 0;
        while (DateTime.Now < endTime)
        {
            if (Console.KeyAvailable) 
            {
                Console.ReadLine(); 
                itemCount++;
            }
            else
            {
                Thread.Sleep(100);
            }
        }
        Console.WriteLine($"\nYou listed {itemCount} items."); 

        DisplayEndingMessage();

    }
}
