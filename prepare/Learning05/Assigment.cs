using System.Reflection.Metadata;

public class Assignment 
{
    protected string _studenName = "";
    private string _topic = "";
    

    
    public Assignment (string studentname, string topic)
    {
        _studenName = studentname;
        _topic = topic;
    
    }

    public Assignment ()
    {
        _studenName = "studentname";
        _topic = "topic";
    
    }
    public string GetSummary ()
    {
        return $"{_studenName} - {_topic}";

    }

}