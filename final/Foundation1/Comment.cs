public class Comment
{
    private string _name;
    private string _comment;

    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public string Name
    {
        get { return _name; }
    }

    public string Text
    {
        get { return _comment; }
    }
}