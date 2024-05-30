class Running : Activity
{
    public double _distance;

    public Running(DateTime date, int length, double distance) : base(date, length)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return this._distance;
    }

    public override double GetSpeed()
    {
        return this._distance / GetLength() * 60;
    }

    public override double GetPace()
    {
        return GetLength() / this._distance;
    }
}