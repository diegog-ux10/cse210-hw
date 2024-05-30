using System;

abstract class Event
{
    protected readonly string _title;
    private readonly string _description;
    protected readonly DateTime _date;
    private readonly string _time;
    private readonly Address _address;

    protected Event(string title, string description, DateTime date, string time, Address address)
    {
        this._title = title;
        this._description = description;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public string GetStandardDetails()
    {
        return $"{this._title}\n{this._description}\n{this._date.ToShortDateString()} at {this._time}\n{this._address.AddressToString()}";
    }

    public virtual string GetFullDetails()
    {
        return GetStandardDetails();
    }

    public abstract string GetShortDescription();
}