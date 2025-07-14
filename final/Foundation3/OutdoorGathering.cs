class OutdoorGathering : Event
{
    private string _weatherforecast;

    public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherforecast)
        : base(title, description, date, time, address)
    {
        _weatherforecast = weatherforecast;
    }
    public override string GetFullDetails()
    {
        
        return $"{base.GetStandardDetails()}\nType: Outdoor Gathering\nWeather Forecast: {_weatherforecast}";
    }
    
}