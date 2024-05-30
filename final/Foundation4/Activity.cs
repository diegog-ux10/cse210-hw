abstract class Activity
{
    private DateTime _date;
    private int _length;

    public Activity(DateTime date, int length)
    {
        this._date = date;
        this._length = length;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{this._date.ToShortDateString()} {GetType().Name} ({this._length} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace {GetPace()} min per mile";
    }

    public int GetLength()
    {
        return this._length;
    }
}