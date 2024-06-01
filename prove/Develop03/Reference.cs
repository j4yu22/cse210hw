//reference can take the words list as empty because each instance of reference needs the list<words>
//look into an override here too for looping through printing the words

using System;
using System.Collections.Generic;

public class Reference
{
    private List<Verse> scriptures;
    private string scriptureReferences;
    private string fileAddress;

    public Reference(string book, string chapter, int verse, string verseText)
    {
        this.fileAddress = verseText;
        scriptures = new List<Verse>();
        scriptures.Add(new Verse(verseText));
        this.scriptureReferences = $"{book} {chapter}:{verse}";
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
