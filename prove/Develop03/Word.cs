// replaces words with ______
public class Word
{
    public string Text;
    public bool IsVisible;


    // Constructor
    public Word(string text)
    {
        Text = text;
        IsVisible = true;
    }

    public string GetDisplayText()
    {
        if (IsVisible)
        {
            return Text;
        }
        else
        {
            return "__"; // Placeholder for hidden words
        }
    }
}