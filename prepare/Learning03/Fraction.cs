public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        this._top = 1;
        this._bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        this._top = wholeNumber;
        this._bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this._top = top;
        this._bottom = bottom;
    }
    public int GetTop()
    {
        return this._top;
    }

    public void SetTop(int value)
    {
        this._top = value;
    }

    // Getters and setters for denominator
    public int GetBottom()
    {
        return this._bottom;
    }

    public void SetBottom(int value)
    {
        if (value == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        this._bottom = value;
    }

    // Method to get the fraction string in the form "numerator/denominator"
    public string GetFractionString()
    {
        return $"{this._top}/{this._bottom}";
    }

    // Method to get the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)this._top / this._bottom;
    }

}