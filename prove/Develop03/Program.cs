using System;

class Program
{
    static void Main(string[] args)
    {
        // Example usage
        Reference reference = new Reference("Genesis", "1", 1, 10, "path/to/file.txt");
        reference.FindVerses("Genesis", 1, 10, "path/to/file.txt");
        reference.PrintScripture();
    }
}
