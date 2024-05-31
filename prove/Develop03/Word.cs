// look into overwriting the 2 string method for hiding words and printing them.
//override lets you override an inheritied method
using System;

public class Word
{
    private string word;
    private bool isBlank;
    private int wordLen;

    // Constructor
    public Word(string word)
    {
        this.word = word;
        this.isBlank = false;
        this.wordLen = word.Length;
    }

    // Get the word
    public string GetWord()
    {
        return word;
    }

    // Blank the word
    public void Blank()
    {
        isBlank = true;
    }

    // Check if the word is blank
    public bool CheckBlank()
    {
        return isBlank;
    }
}
