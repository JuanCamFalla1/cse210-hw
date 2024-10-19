public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    }

    public void Run(int time)
    {
        SetDuration(time);

        int inhaleTime = 5;
        int exhaleTime = 5;

        Console.WriteLine("");
        
        ShowSpinner(4); 

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);

        while (DateTime.Now < endTime)        
        {   
            Console.WriteLine("");
            Console.Write("Breathe in...");
            ShowCountDown(inhaleTime);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Now Breathe out...");
            ShowCountDown(exhaleTime);
            Console.WriteLine("");
            
        }
        Console.WriteLine("");
        Console.Write("Well done!!");
        ShowSpinner(4);
        Console.WriteLine("");
        Console.Write(DisplayEndingMessage());
        ShowSpinner(6);
    }

    public string GetTitle()
    {
        return DisplayStartingMessage();
    }
}