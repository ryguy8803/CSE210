using System;

class Program
{
    static void Main(string[] args)
    {
        // Hardcode the Proverbs 3:5-6 scripture
        ScriptureReference proverbsReference = new ScriptureReference("Proverbs", 3, 5, 6);
        string proverbsText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture currentScripture = new Scripture(proverbsReference, proverbsText);

        string userInput = "";

        // Loop until the user types 'quit' or all words are hidden
        while (userInput.ToLower() != "quit" && !currentScripture.IsCompletelyHidden())
        {
            Console.Clear(); // Clear the console screen for a clean display
            Console.WriteLine(currentScripture.GetDisplayText()); // Display the scripture

            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            userInput = Console.ReadLine(); // Get user input

            if (userInput.ToLower() != "quit")
            {
                currentScripture.HideRandomWords(3); // Hide 3 random words each time the user presses Enter
            }
        }

        Console.Clear(); // Clear one last time before exiting
        Console.WriteLine(currentScripture.GetDisplayText()); // Display the final state
        Console.WriteLine("\nAll words are hidden or you chose to quit. Goodbye!");
    }
}