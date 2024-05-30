using System;

class Reception : Event
{
    private readonly List<string> _attendance = [];

    public Reception(string title, string description, DateTime date, string time, Address address)
        : base(title, description, date, time, address)
    {

    }

    public override string GetFullDetails()
    {
        string details = GetStandardDetails();
        int count = 1;

        details += $"\nAttendance:\n";
        foreach (string name in this._attendance)
        {
            details += $"{count}: {name}\n";
            count += 1;
        }
        return details;
    }

    public override string GetShortDescription()
    {
        return $"Reception: {base._title} - {base._date}";
    }

    public void RegisterAttendance(string name) 
    {
        this._attendance.Add(name);
    }
}