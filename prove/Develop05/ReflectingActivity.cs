

public class ReflectingActivity : Activity
{   
    
    private List<string> _Prompts = new List<string> 
        { "Think of a time when you stood up for someone else.",
         "Think of a time when you did something really difficult.", 
         "Think of a time when you helped someone in need.", 
         "Think of a time when you did something truly selfless.", };
    private List<string> _Questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };


    public ReflectingActivity (string name, string description) : base (name, description)
    {
    }
    public string GetTitle()
    {
        return DisplayStartingMessage();
    }

    public void Run (int time) 
    {
        SetDuration(time);
        Console.WriteLine("");
        
        ShowSpinner(4); 

       

        Console.WriteLine("\nConsider the Following Prompt:");
        Console.WriteLine($"--- {GetRandomPrompt ()} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("\nNow ponder on each of the following Questions as they related to this expirience");
        Console.Write("You may beging: "); ShowCountDown(5);
        Console.Clear ();
        


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(time);


        while (DateTime.Now < endTime)        
        {   
            Console.Write(GetRandomQuestion());ShowSpinner(8); 
            Console.WriteLine("");
            
            
            
        }

        Console.WriteLine("");
        Console.Write("Well done!!");
        ShowSpinner(4);
        Console.WriteLine("");
        Console.Write(DisplayEndingMessage());
        ShowSpinner(6);
    } 

    public string GetRandomPrompt () 
    {           
        Random random = new Random();
        int index = random.Next(_Prompts.Count);
        return _Prompts[index];
        
    }

    
    public string GetRandomQuestion () 
    {
        Random random = new Random();
        int index = random.Next(_Questions.Count);
        return _Questions [index];        

    }
       
        

}