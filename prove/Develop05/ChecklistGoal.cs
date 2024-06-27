using Newtonsoft.Json;

public class ChecklistGoal : Goal
{
    [JsonProperty("NCompletionsGoal")]
    public int NCompletionsGoal { get; private set; }

    [JsonProperty("BonusPoints")]
    public int BonusPoints { get; private set; }

    [JsonProperty("timesCompleted")]
    private int timesCompleted;

    public ChecklistGoal(int points, string name, int nCompletionsGoal, int bonusPoints) : base(points, name)
    {
        this.NCompletionsGoal = nCompletionsGoal;
        this.BonusPoints = bonusPoints;
        this.timesCompleted = 0;
    }

    [JsonConstructor]
    public ChecklistGoal(int points, string name, int nCompletionsGoal, int bonusPoints, int timesCompleted) : base(points, name)
    {
        this.NCompletionsGoal = nCompletionsGoal;
        this.BonusPoints = bonusPoints;
        this.timesCompleted = timesCompleted;
    }

    public override void MarkCompleted()
    {
        timesCompleted++;
    }

    public override int GetPoints()
    {
        if (timesCompleted >= NCompletionsGoal)
        {
            return points + BonusPoints;
        }
        return points;
    }

    public int GetTimesCompleted()
    {
        return timesCompleted;
    }
}
