using System;

public class Address 
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string address, string city, string state, string country)
    {
        this._streetAddress = address;
        this._city = city;
        this._state = state;
        this._country = country;

    }

    public string AddressToString() 
    {
        return $"{this._streetAddress}\n{this._city}\n{this._state}\n{this._country}";
    }

}