public abstract class User
{
    protected string _name;
    protected string _birthdate;
    protected int _email;

    protected void ShowInfo(int seconds)
    {
        Console.WriteLine($"{this._name} {this._birthdate} {this._email}");
    }
}

public class Customer: User
{
    public void ShowBuyingList()
    {
        // Implementation...
    }
}

public class Employee: User
{
    public void AddNewItem()
    {
        // Implementation...
    }
}