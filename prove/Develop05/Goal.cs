using Newtonsoft.Json;

public abstract class Goal
{
    [JsonProperty("points")]
    protected int points;

    [JsonProperty("name")]
    protected string name;

    public Goal(int points, string name)
    {
        this.points = points;
        this.name = name;
    }

    public abstract void MarkCompleted();
    public abstract int GetPoints();
    public string GetName()
    {
        return name;
    }
}
