public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void RunActivity()
    {
        DisplayStartingMessage();

        Random random = new Random();
        Console.WriteLine($"\nConsider the following prompt:\n\n--- {_prompts[random.Next(_prompts.Count)]} ---\n");
        Console.WriteLine("When you have thought about the prompt, press enter to continue.");
        Console.ReadLine(); 
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountdown(5); 
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        //keeps track of used questions to avoid repetition (exceeding requirement)!!! thank you internet :)
        List<string> availableQuestions = new List<string>(_questions);

        while (DateTime.Now < endTime)
        {
            if (availableQuestions.Count == 0)
            {
                availableQuestions = new List<string>(_questions);
            }
            int questionIndex = random.Next(availableQuestions.Count);
            string currentQuestion = availableQuestions[questionIndex];
            availableQuestions.RemoveAt(questionIndex); 
            Console.Write($"\n> {currentQuestion} ");
            ShowSpinner(8); 
        }

        DisplayEndingMessage();
    }
}