class Quote
{
    private string text;
    private string newText;

    public Quote() 
    {
        string[] lines = System.IO.File.ReadAllLines("qoute.txt");
        text = lines[1];
    }

    public string getQouteText()
    {
        return text;
    }

    public void updateText(string newText) 
    {
        text = newText;
    }
}