using System;
using System.Collections.Generic;

class Job {
    public void getInfo() {
        Console.WriteLine("What is the name of the company you worked at? ");
        string companyName = Console.ReadLine();
        Console.WriteLine("What was your job title? ");
        string title = Console.ReadLine();

        Console.WriteLine("What was your start year? ");
        int startYear = int.Parse(Console.ReadLine());
        Console.WriteLine("What was your end year? ");
        int endYear = int.Parse(Console.ReadLine());

        if (!Program.jobHistory.ContainsKey(companyName)) {
            Program.jobHistory.Add(companyName, new Program.jobInfo(title, startYear, endYear));
        } else {
            Console.WriteLine("Entry for this company already exists.");
        }
    }
    public void printHistory(){
        foreach (var item in Program.jobHistory)
        {
            Console.WriteLine($"Company: {item.Key}, Title: {item.Value.Title}, Start Year: {item.Value.StartYear}, End Year: {item.Value.EndYear}");
        }
    }
}
