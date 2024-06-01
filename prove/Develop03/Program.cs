using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Hardcoded as placeholder
        List<Reference> references = new List<Reference>
        {
            new Reference("John", "1", 1, 1, "In the beginning was the Word, and the Word was with God, and the Word was God."),
            new Reference("1 Nephi", "3", 7, 7, "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them."),
            new Reference("3 Nephi", "11", 24, 26, "And now behold, these are the words which ye shall say, calling them by name, saying:" ,
                                                    "Having authority given me of Jesus Christ, I baptize you in the name of the Father, and of the Son, and of the Holy Ghost. Amen.", 
                                                    "And then shall ye immerse them in the water, and come forth again out of the water.")
        };

        Console.WriteLine("Select the scripture to memorize:");
        for (int i = 0; i < references.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {references[i].GetReferenceString()}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        Reference selectedReference = references[choice];

        while (true)
        {
            Console.Clear();
            selectedReference.PrintScripture();
            Console.WriteLine("Press Enter to blank out 2-3 new words, or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            else if (string.IsNullOrEmpty(input))
            {
                selectedReference.BlankWords(2, 3);
            }
        }
    }
}
