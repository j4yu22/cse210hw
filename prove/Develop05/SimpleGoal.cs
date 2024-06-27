public class SimpleGoal : Goal
{
    public SimpleGoal(int points, string name) : base(points, name)
    {
    }

    public override void MarkCompleted()
    {
        // Logic for marking the goal as completed
    }

    public override int GetPoints()
    {
        return points;
    }
}
