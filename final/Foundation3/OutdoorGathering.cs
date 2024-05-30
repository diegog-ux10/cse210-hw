using System;

class OutdoorGathering : Event
{
    public string _weather;

    public OutdoorGathering(string title, string description, DateTime date, string time, Address address, string weather)
        : base(title, description, date, time, address)
    {
        this._weather = weather;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nWeather: {this._weather}";
    }

    public override string GetShortDescription()
    {
        return $"Outdoor Gathering: {base._title} - {base._date}";
    }
}