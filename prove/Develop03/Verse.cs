using System;
using System.Collections.Generic;

public class Verse
{
    private List<Word> words;

    // Constructor
    public Verse(List<string> verses)
    {
        words = new List<Word>();
        foreach (var verse in verses)
        {
            words.Add(new Word(verse));
        }
    }

    // Extract words from a verse
    public void VerseRipper(string verse)
    {
        // Implementation for extracting words from the verse string
        // Assuming words are separated by spaces
        string[] wordArray = verse.Split(' ');
        foreach (var wordStr in wordArray)
        {
            words.Add(new Word(wordStr));
        }
    }

    // Modify the verse
    public string ModifyVerse()
    {
        // Modify the verse as required and return the string
        // For example, return all words concatenated
        return string.Join(" ", words.ConvertAll(w => w.GetWord()));
    }

    // Print the verse
    public void PrintVerse()
    {
        Console.WriteLine(ModifyVerse());
    }
}
