using System;

public class Entry {
    public readonly DateTime _date;
    public readonly string _prompText;
    public readonly string _entryText;

    public Entry(string prompText, string entryText, DateTime date)
    {   
        _date = date;
        _prompText = prompText;
        _entryText = entryText;
    }

    public Entry(string prompText, string entryText) : this(prompText, entryText, DateTime.Now)
    {
    }

    public void Display()
    {
        string date = _date.ToShortDateString();
        Console.WriteLine($"Date: {date} - Prompt: {_prompText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }

}