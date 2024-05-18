using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        this._reference = reference;
        this._words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public bool HideRandomWords(int numberToHide)
    {
        Random random = new();
        List<Word> notHiddenWords = this._words.Where(word => !word.IsHidden()).ToList();

        if (!notHiddenWords.Any()) return false;

        for (int i = 0; i < numberToHide && notHiddenWords.Count > 0; i++)
        {
            Word wordToHide = notHiddenWords[random.Next(notHiddenWords.Count)];
            wordToHide.Hide();
            notHiddenWords.Remove(wordToHide);
        }
        return true;
    }

    public override string ToString()
    {
        string scriptureText = string.Join(" ", this._words);
        return $"{this._reference}\n{scriptureText}";
    }
}
