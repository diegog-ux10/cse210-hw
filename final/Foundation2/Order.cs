using System;
class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        this._customer = customer;
    }

    public void AddProduct(Product product)
    {
        this._products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;
        foreach (Product product in this._products)
        {
            total += product.GetTotalCost();
        }
        total += this._customer.IsInUSA() ? 5 : 35;
        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in this._products)
        {
            label += $"{product.GetProductName()} ({product.GetProductID()})\n";
        }
        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{this._customer.GetCustomerName()}\n{this._customer.GetCustomerAddress()}";
    }
}