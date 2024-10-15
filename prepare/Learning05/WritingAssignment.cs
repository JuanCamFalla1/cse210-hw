public class WrittingAssignment : Assignment
{
    private string _title;

    public WrittingAssignment (string studentname, string topic, string title) :base (studentname , topic)
    {
        _title = title;
    }

    public string GetWritingInformation () 
    {
        return $"{GetSummary ()} \n{_title} by {_studenName}";
    }
}