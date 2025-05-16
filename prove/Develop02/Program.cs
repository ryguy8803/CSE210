using System;

class Program
{
    static List<string> journalEntries = new List<string>();
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Welcome to the Abstraction Journal!");
            Console.WriteLine("<1> Write a new entry to your journal");
            Console.WriteLine("<2> Save entry to file");
            Console.WriteLine("<3> Load file");
            Console.WriteLine("<4> View journal");
            Console.WriteLine("<5> Exit");
            Console.WriteLine("Enter option here:");
            int choice = int.Parse(Console.ReadLine());
            HandelMenuChoice(choice);

            if (choice == 5)
            {
                break; 
            }
        }

    }


    static void HandelMenuChoice(int choice)
    {
        if (choice == 1)
        {
            string entry = Entry.WriteEntry(); 
            journalEntries.Add(entry);         
            Console.WriteLine("Entry added to journal.");
        }

        else if (choice == 2)
        {
            if (journalEntries.Count > 0)
            {
                Console.WriteLine("Saving entries to file...");
                foreach (string savedEntry in journalEntries)
                {
                    Journal.SaveEntryToFile(savedEntry);
                }
                journalEntries.Clear(); 
                 Console.WriteLine("Entries saved successfully!");
            }
            else
            {
                Console.WriteLine("No entries to save.");
            }
        }
        else if (choice == 3)
        {
            Console.WriteLine("Enter the file to load:");
            string filePath = Console.ReadLine();

            
            string[] lines = File.ReadAllLines(filePath);
            journalEntries.AddRange(lines); 
            Console.WriteLine("Entries loaded successfully!");
        }
        else if (choice == 4)
        {
            for (int i = 0; i < journalEntries.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {journalEntries[i]}");
                } 
        }
    }

}
