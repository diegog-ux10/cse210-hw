class Video
{
    private string _title;
    private string _author;
    private int _length;
    private readonly List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        this._length = length;
    }

    public void AddComment(Comment comment)
    {
        this._comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return this._comments.Count;
    }

    public List<Comment> GetComments()
    {
        return this._comments;
    }

    public void GetVideoDetails() 
    {
        Console.WriteLine($"Title: {this._title}");
        Console.WriteLine($"Auhtor: {this._author}");
        Console.WriteLine($"Lenght: {this._length}");
        Console.WriteLine($"Number of Comments: {GetCommentCount()}");
        Console.WriteLine("Comments:");
        foreach (var comment in this.GetComments())
        {
            Console.WriteLine(comment.DisplayComment());
        }
        Console.WriteLine();
    }
}