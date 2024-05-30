class Lecture : Event
{
    private readonly string _speaker;
    private readonly int _capacity;

    public Lecture(string title, string description, DateTime date, string time, Address address, string speaker, int capacity)
        : base(title, description, date, time, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
    }

    public override string GetFullDetails()
    {
        return $"{GetStandardDetails()}\nSpeaker: {this._speaker}\nCapacity: {this._capacity}";
    }

    public override string GetShortDescription()
    {
        return $"Lecture: {base._title} - {base._date}";
    }
}