using System;

class Customer
{
    private string _name;
    private Address _address; 

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public bool IsInUSA()
    {
        return this._address.IsInUSA();
    }

    public string GetCustomerName()
    {
        return this._name;
    }

    public string GetCustomerAddress()
    {
        return this._address.ToString();
    }
}