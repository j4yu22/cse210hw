using System;
using System.Collections.Generic;

public class Reference
{
    private List<Verse> scriptures;
    private string scriptureReferences;

    // Constructor that accepts either a single verse string or multiple verse strings
    public Reference(string book, string chapter, int startVerse, int endVerse, params string[] verses)
    {
        scriptures = new List<Verse>();
        for (int i = 0; i < verses.Length; i++)
        {
            scriptures.Add(new Verse(verses[i]));
        }
        if (startVerse == endVerse)
        {
            this.scriptureReferences = $"{book} {chapter}:{startVerse}";
        }
        else
        {
            this.scriptureReferences = $"{book} {chapter}:{startVerse}-{endVerse}";
        }
    }

    public string GetReferenceString()
    {
        return scriptureReferences;
    }

    public void PrintScripture()
    {
        foreach (var verse in scriptures)
        {
            verse.PrintVerse();
        }
    }

    public void BlankWords(int minWords, int maxWords)
    {
        Random random = new Random();
        foreach (var verse in scriptures)
        {
            int wordsToBlank = random.Next(minWords, maxWords + 1);
            verse.BlankRandomWords(wordsToBlank);
        }
    }
}
