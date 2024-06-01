// look into overwriting the 2 string method for hiding words and printing them.
//override lets you override an inheritied method
using System;

public class Word
{
    private string word;
    private bool isBlank;
    private int wordLen;

    public Word(string word)
    {
        this.word = word;
        this.isBlank = false;
        this.wordLen = word.Length;
    }

    public string GetWord()
    {
        if (isBlank)
        {
            return new string('_', wordLen);
        }
        return word;
    }

    public void Blank()
    {
        isBlank = true;
    }

    public bool CheckBlank()
    {
        return isBlank;
    }

    public override string ToString()
    {
        return GetWord();
    }
}
