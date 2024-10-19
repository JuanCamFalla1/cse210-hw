public class ListingActivity : Activity
{
    private List<string> _responses = new List<string>();
    private List<string> _Prompts = new List<string> 
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description) 
    {
    }

    public string GetTitle()
    {
        return DisplayStartingMessage();
    }

    public void Run(int time) 
    {
        SetDuration(time);
        Console.WriteLine("");
        ShowSpinner(4); 

        Console.WriteLine("\nList as many responses as you can to the following prompt:");
        Console.WriteLine($"--- {GetRandomPrompt()} ---\n");
        Console.Write("You may begin: "); 
        ShowCountDown(7);
        Console.WriteLine("");
        

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        while (DateTime.Now < endTime)        
        {   
            Console.Write(">");
            string response = Console.ReadLine(); 
            if (!string.IsNullOrWhiteSpace(response))
            {
                _responses.Add(response); 
            }
        }

        Console.WriteLine("");
        Console.WriteLine($"You listed { _responses.Count } items!\n");        
        Console.Write("Well done!!");
        ShowSpinner(4);
        Console.WriteLine("");
        Console.Write(DisplayEndingMessage());
        ShowSpinner(6);
    }

    public string GetRandomPrompt() 
    {
        Random random = new Random();
        int index = random.Next(_Prompts.Count);
        return _Prompts[index];
    }
}