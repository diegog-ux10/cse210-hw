class Swimming : Activity
{
    public int _laps;
    public Swimming(DateTime date, int length, int laps) : base(date, length)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        return this._laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetLength()) * 60;
    }

    public override double GetPace()
    {
        return GetLength() / GetDistance();
    }
}