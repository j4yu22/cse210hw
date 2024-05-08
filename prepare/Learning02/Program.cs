using System;
using System.Collections.Generic;

class Program
{
    public class jobInfo
    {
        public string Title { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }

        public jobInfo(string title, int startYear, int endYear)
        {
            Title = title;
            StartYear = startYear;
            EndYear = endYear;
        }
    }
    public static Dictionary<string, jobInfo> jobHistory = new Dictionary<string, jobInfo>();

    static void Main(string[] args)
    {
        Job job = new Job();
        
        bool keepAdding = true;
        while (keepAdding)
        {
            job.getInfo();
            Console.WriteLine("Do you want to add another job? (y/n)");
            string answer = Console.ReadLine().Trim().ToLower();
            if (answer != "y")
            {
                keepAdding = false;
            }
        }
        bool askForPrint = true;
        while (askForPrint)
        {
            Console.WriteLine("Do you want to print job history? (y/n)");
            string answer = Console.ReadLine().Trim().ToLower();
            if (answer == "y")
            {
                job.printHistory();
                askForPrint = false;
            }
            else
            {
                askForPrint = false;
            }
        }
    }
}
