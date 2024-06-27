using Newtonsoft.Json;

public class EternalGoal : Goal
{
    [JsonProperty("timesCompleted")]
    private int timesCompleted;

    public EternalGoal(int points, string name) : base(points, name)
    {
        this.timesCompleted = 0;
    }

    [JsonConstructor]
    public EternalGoal(int points, string name, int timesCompleted) : base(points, name)
    {
        this.timesCompleted = timesCompleted;
    }

    public override void MarkCompleted()
    {
        timesCompleted++;
    }

    public override int GetPoints()
    {
        return points;
    }

    public int GetTimesCompleted()
    {
        return timesCompleted;
    }
}
