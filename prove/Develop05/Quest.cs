using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

public class Quest
{
    private int score;
    private List<Goal> goals;

    public Quest()
    {
        score = 0;
        goals = new List<Goal>();
    }

    [JsonProperty("score")]
    public int Score
    {
        get { return score; }
        set { score = value; }
    }

    [JsonProperty("goals")]
    public List<Goal> Goals
    {
        get { return goals; }
        set { goals = value; }
    }

    public void CreateGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.Clear();
        foreach (var goal in goals)
        {
            string status = (goal is ChecklistGoal checklistGoal && checklistGoal.GetTimesCompleted() >= checklistGoal.NCompletionsGoal) ? "[X]" : "[ ]";
            Console.WriteLine($"{status} {goal.GetName()}");
        }
    }

    public void DisplayScore()
    {
        Console.Clear();
        Console.WriteLine($"Your score is: {score}");
    }

    public void RecordEvent(string goalName)
    {
        var goal = goals.Find(g => g.GetName() == goalName);
        if (goal != null)
        {
            goal.MarkCompleted();
            score += goal.GetPoints();
        }
    }

    public void SaveGoals(string filePath = "goals.json")
    {
        try
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented, Converters = new List<JsonConverter> { new GoalConverter() } };
            string json = JsonConvert.SerializeObject(this, settings);
            File.WriteAllText(filePath, json);
            Console.WriteLine("Goals saved successfully.");
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine($"Access to the path '{filePath}' is denied: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving goals: {ex.Message}");
        }
    }

    public static Quest LoadGoals(string filePath = "goals.json")
    {
        try
        {
            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found.", filePath);
            }

            string json = File.ReadAllText(filePath);
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Converters = new List<JsonConverter> { new GoalConverter() } };
            Quest quest = JsonConvert.DeserializeObject<Quest>(json, settings);
            Console.WriteLine("Goals loaded successfully.");
            return quest;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while loading goals: {ex.Message}");
            return new Quest();
        }
    }
}
