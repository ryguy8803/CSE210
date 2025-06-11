public class BreathingActivity : Activity
{
    public BreathingActivity() : base ("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public void RunActivity()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(4); 
            if (DateTime.Now >= endTime) break; 

            Console.Write("Breathe out...");
            ShowCountdown(6); 
        }

        DisplayEndingMessage();
    }
 

}