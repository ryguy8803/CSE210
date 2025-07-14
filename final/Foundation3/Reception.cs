class Reception : Event
{
    private string _rsvpemail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpemail)
        : base(title, description, date, time, address)
    {
        _rsvpemail = rsvpemail;
    }

    public override string GetFullDetails()
    {
        // Now calling base.GetStandardDetails() directly
        return $"{base.GetStandardDetails()}\nType: Reception\nRSVP Email: {_rsvpemail}";
    }

}