
public class ChecklistGoal : Goal
{
    public int _amountCompleted;
    public int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= _target;
    }

    public override int Bonus => _bonus;

    public override string GetDetailsString()
    {
        string completionStatus = IsComplete() ? "[X]" : "[ ]";
        return $"{completionStatus} Checklist Goal: {_shortName}, Description: {_description}, Points: {_points}, Completed: {_amountCompleted}/{_target}, Bonus: {_bonus}";

    }
}
