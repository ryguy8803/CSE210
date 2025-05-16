using System;

public class Entry
{
    public static string WriteEntry()
        {
            List<string> prompts = new List<string>() 
            {
                "What are you grateful for today?",
                "Describe a moment that made you smile today.",
                "What is a challenge you are currently facing and how are you approaching it?",
                "Write about a person who inspired you today and why.",
                "What is something you learned today?",
                "Reflect on a goal you have and what steps you can take to achieve it.",
                "Describe your mood and what might be influencing it.",
                "What is a small act of kindness you witnessed or performed today?",
                "What are three things you appreciate about yourself?"
            };

             Random random = new Random();
             int randomIndex = random.Next(prompts.Count);
             string selectedPrompt = prompts[randomIndex];
             Console.WriteLine($"Today's prompt: {selectedPrompt}");
             Console.WriteLine("Enter your journal entry:");
             string entryText = Console.ReadLine();
             string currentDate = DateTime.Now.ToShortDateString();
            return $"{currentDate}|{selectedPrompt}|{entryText}";
            
             
        }

}