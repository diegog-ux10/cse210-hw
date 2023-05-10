class Author 
{
    private string name;

    public Author()
    {
        string[] lines = System.IO.File.ReadAllLines("qoute.txt");
        name = lines[0];
    }

    public string getAuthorName() {
        return name;
    }
}