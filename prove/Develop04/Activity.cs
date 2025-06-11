public class Activity
{
    protected int _duration;
    private string _description;
    private string _name;

    public Activity(string name, string description)
    {
        _duration = 0; //set to 0 so the user can input it later
        _description = description;
        _name = name;
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(250); 
            Console.Write("\b \b"); 

            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }
    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000); 
            Console.Write("\b \b");
            if (i >= 10) // Handle two-digit numbers
            {
                Console.Write("\b \b");
            }
        }
        Console.WriteLine(); 
    }
    public void DisplayStartingMessage()
    {
        Console.Clear(); 
        Console.WriteLine($"--- {_name} Activity ---");
        Console.WriteLine($"\n{_description}");

        Console.Write("\nHow long, in seconds, would you like for your session? ");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
        Console.WriteLine("\nPrepare to begin...");
        ShowSpinner(5); 
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        ShowSpinner(3); 

        Console.WriteLine($"\nYou have completed the {_name} Activity for {_duration} seconds.");
        ShowSpinner(5); 
    }
}
