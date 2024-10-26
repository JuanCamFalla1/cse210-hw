
public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goals are never complete
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "[X]" : "[ ]";
        return $"{completionStatus} Eternal Goal: {_shortName}, Description: {_description}, Points: {_points}";
    }
}
