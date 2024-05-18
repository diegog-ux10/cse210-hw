public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        this._text = text;
        this._isHidden = false;
    }

    public void Hide()
    {
        this._isHidden = true;
    }

    public bool IsHidden()
    {
        return this._isHidden;
    }

    public void show()
    {
        this._isHidden = false;
    }

    public override string ToString()
    {
        return this._isHidden ? "_____" : this._text;
    }
}
