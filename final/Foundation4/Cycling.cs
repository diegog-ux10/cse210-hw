class Cycling : Activity
{
    public double _speed;

    public Cycling(DateTime date, int length, double speed) : base(date, length)
    {
        this._speed = speed;
    }

    public override double GetDistance()
    { 
        return this._speed * GetLength() / 60;
    }

    public override double GetSpeed()
    {
        return this._speed;
    }

    public override double GetPace()
    {
        return 60 / this._speed;
    }
}