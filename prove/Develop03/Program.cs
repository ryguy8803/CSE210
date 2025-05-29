using System;

class Program
{
    static void Main(string[] args)
    {
        
        ScriptureReference proverbsReference = new ScriptureReference("Proverbs", 3, 5, 6);
        string proverbsText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture currentScripture = new Scripture(proverbsReference, proverbsText);

        string userInput = "";

        // Loop 
        while (userInput.ToLower() != "quit" && !currentScripture.IsCompletelyHidden())
        {
            Console.Clear(); 
            Console.WriteLine(currentScripture.GetDisplayText()); 

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            userInput = Console.ReadLine(); // Get user input

            if (userInput.ToLower() != "quit")
            {
                currentScripture.HideRandomWords(3); 
            }
        }

        Console.Clear(); 
        Console.WriteLine(currentScripture.GetDisplayText()); 
        Console.WriteLine("\nAll words are hidden or you chose to quit. Goodbye!");
    }
}