using System; // Required for String.Format if you were to use it, but not strictly for string interpolation

public class ScriptureReference
{
    
    private string _book;
    private int _chapter;
    private int _startVerse; 
    private int _endVerse;   

    
    public string Book
    {
        get { return _book; }
    }

    public int Chapter
    {
        get { return _chapter; }
    }

    public int StartVerse 
    {
        get { return _startVerse; }
    }

    public int EndVerse 
    {
        get { return _endVerse; }
    }

    // Constructor for a verse range (e.g., "Proverbs 3:5-6")
    public ScriptureReference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    
    public string GetDisplayText()
    {
        
        if (StartVerse == EndVerse) 
        {
            return $"{Book} {Chapter}:{StartVerse}"; 
        }
        else
        {
            return $"{Book} {Chapter}:{StartVerse}-{EndVerse}"; 
        }
    }
}