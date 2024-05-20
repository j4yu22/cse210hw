using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void NewEntry()
    {
        string prompt = Entry.GetPrompt();
        Console.WriteLine(prompt);
        Console.WriteLine("Please write your entry:");
        string response = Console.ReadLine();

        entries.Add(new Entry(prompt, response));
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveJournal()
    {
        Console.Write("Enter the filename to save your journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(filename, true))
        {
            foreach (Entry entry in entries)
            {
                sw.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    public void LoadJournal()
    {
        Console.Write("Enter the filename to load your journal from: ");
        string filename = Console.ReadLine();

        try
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                entries.Clear();
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        entries.Add(new Entry(parts[0], parts[1], parts[2]));
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found, please check the filename and try again.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
