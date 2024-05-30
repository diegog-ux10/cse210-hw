using System;

class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        this._street = street;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    public bool IsInUSA()
    {
        return this._country.ToLower() == "usa";
    }

    public override string ToString()
    {
        return $"{this._street}\n{this._city}, {this._state}\n{this._country}";
    }
}