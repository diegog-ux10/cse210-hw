using System;

class Product
{
    private readonly string _name;
    private readonly string _productId;
    private readonly decimal _price;
    private readonly int _quantity;

    public Product(string name, string productId, decimal price, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return this._price * this._quantity;
    }

    public string GetProductName()
    {
        return this._name;
    }

    public string GetProductID()
    {
        return this._productId;
    }
}
