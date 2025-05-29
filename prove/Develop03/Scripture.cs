// Will hold scripture and up date as words are removed 

public class Scripture
{
    private ScriptureReference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference; 
        _words = new List<Word>(); 

        string[] rawParts = text.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (string part in rawParts)
        {
            _words.Add(new Word(part));
        }
    }

    public void HideRandomWords(int count)
    {
        List<Word> visibleWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (word.IsVisible)
            {
                visibleWords.Add(word);
            }
        }

        int wordsToHide = count;
        if (wordsToHide > visibleWords.Count)
        {
            wordsToHide = visibleWords.Count;
        }

        for (int i = 0; i < wordsToHide; i++)
        {
            if (visibleWords.Count == 0)
            {
                break;
            }

            int indexToHide = _random.Next(0, visibleWords.Count);
            visibleWords[indexToHide].IsVisible = false;

            visibleWords.RemoveAt(indexToHide);
        }
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsVisible)
            {
                return false;
            }
        }
        return true;
    }

    public string GetDisplayText()
    {
        List<string> displayedParts = new List<string>();
        foreach (Word word in _words)
        {
            displayedParts.Add(word.GetDisplayText());
        }
        string scriptureText = string.Join(" ", displayedParts);
        return $"{_reference.GetDisplayText()}\n{scriptureText}";
    }
}