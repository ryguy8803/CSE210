public class MathAssignment : Assignment
{
    private string _textbooksection;
    private string _problems;

    public MathAssignment(string studentname, string topic, string textbookSection, string problems)
        : base(studentname, topic)
    {
        _textbooksection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbooksection} {_problems}";
    }
}