public class Reference
{
    private readonly string _book;
    private readonly int _chapter;
    private readonly int _verse;
    private readonly int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = verse;
        this._endVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        this._book = book;
        this._chapter = chapter;
        this._verse = startVerse;
        this._endVerse = endVerse;
    }

    public override string ToString()
    {
        if (this._verse == this._endVerse)
            return $"{this._book} {this._chapter}:{this._verse}";
        else
            return $"{this._book} {this._chapter}:{this._verse}-{this._endVerse}";
    }
}
