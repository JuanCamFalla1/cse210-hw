public class Mathassignment : Assignment
{

    private string _textbookSeciton;
    private string _problems;

    public Mathassignment (string studentname, string topic, String textbooksection, string problems) : base (studentname, topic)
    {
        _textbookSeciton = textbooksection;
        _problems = problems;
    }
    public string GetHomeworkList ()
    {
        return $"{GetSummary()} \nSection {_textbookSeciton} Problems {_problems}";
    }

}