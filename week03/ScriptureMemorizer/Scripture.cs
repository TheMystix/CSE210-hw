using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(" ")
                     .Select(word => new Word(word))
                     .ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count == 0)
            return;

        visibleWords = visibleWords.OrderBy(w => rand.Next()).ToList();

    
        foreach (var word in visibleWords.Take(numberToHide))
        {
            word.Hide();
        }
    }

    public string GetDisplayText()
    {
        string reference = _reference.GetDisplayText();
        string text = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{reference}\n{text}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}
