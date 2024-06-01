using System;
using System.Collections.Generic;

public class Verse
{
    private List<Word> words;

    public Verse(string verse)
    {
        words = new List<Word>();
        VerseRipper(verse);
    }

    public void VerseRipper(string verse)
    {
        string[] wordArray = verse.Split(' ');
        foreach (var wordStr in wordArray)
        {
            words.Add(new Word(wordStr));
        }
    }

    public string ModifyVerse()
    {
        return string.Join(" ", words.ConvertAll(w => w.GetWord()));
    }

    public void PrintVerse()
    {
        Console.WriteLine(ModifyVerse());
    }

    public void BlankRandomWords(int wordsToBlank)
    {
        Random random = new Random();
        int blankedWords = 0;
        while (blankedWords < wordsToBlank)
        {
            int index = random.Next(words.Count);
            if (!words[index].CheckBlank())
            {
                words[index].Blank();
                blankedWords++;
            }
        }
    }
}
