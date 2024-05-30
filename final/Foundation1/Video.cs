class Video
{
    private string _title { get; set; }
    private string _author { get; set; }
    private int _length { get; set; }
    private List<Comment> _comments { get; set; } = new List<Comment>();

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