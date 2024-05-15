using System.ComponentModel;

class Journal
{
    private List<Entry> entries = new List<Entry>();
    public void NewEntry(string[] args)
    {
        Console.WriteLine("Prompt here");
        string response = Console.ReadLine();
        entries.Add(new Entry(response));
    }
    static string DisplayEntries(string[] args)
    {
        //format and display entries
    }
    static void SaveJournal(string[] args)
    {
        //save entries to file
    }
    static void LoadJournal(string[] args)
    {
        //load entries from file
    }
}