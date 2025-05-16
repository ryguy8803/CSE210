public class Journal 
{
    public static void SaveEntryToFile(string entry)
    {
            
        Console.WriteLine("Enter the name of the file to save:");
        string fileName = Console.ReadLine();
        string filePath = fileName + ".txt";
        File.AppendAllText(filePath, entry + Environment.NewLine);
        Console.WriteLine("Entry saved successfully!");
        
    }
}


