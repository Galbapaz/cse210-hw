using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] parts = text.Split(' ');

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }
    public void HideRandomWords(int numberToHide)
    {
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int index = _random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string text = _reference.GetDisplayText() + "\n\n";

        foreach (Word word in _words)
        {
            text += word.GetDisplayText() + " ";
        }

        return text.Trim();
    }

    public string GetOriginalText()
    {
        string text = "";

        foreach (Word word in _words)
        {
            text += word.GetOriginalText() + " ";
        }

        return text.Trim();
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
