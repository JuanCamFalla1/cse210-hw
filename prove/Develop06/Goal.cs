

public abstract class Goal
{
    public string _shortName;
    public string _description;
    public int _points;

    public int Points => _points;
    public virtual int Bonus => 0;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetDetailsString();
}
