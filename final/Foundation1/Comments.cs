class Comment
{
    private string _username;
    private string _text;

    public Comment(string commenterName, string text)
    {
        this._username = commenterName;
        this._text = text;
    }

    public string DisplayComment()
    {
        return $"{this._username}: {this._text}";
    }
}