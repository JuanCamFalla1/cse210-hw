public class Entry
{
    public string PromptText { get; }
    public string EntryText { get; }

    public Entry(string entryText, string promptText)
    {
        EntryText = entryText;
        PromptText = promptText;
    }

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string date = theCurrentTime.ToShortDateString();
        
        Console.WriteLine($"Date: {date} - Prompt: {PromptText}");
        Console.WriteLine($"Entry: {EntryText}");
    }
}