
public class GoalManager
{
    private List<Goal> goals;
    public int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void CreateGoal()
    {
        Console.WriteLine("Select Goal Type:\n1. Simple Goal\n2. Eternal Goal\n3. Checklist Goal");
        string choice = Console.ReadLine();
        Console.Write("Enter Goal Name: ");
        string name = Console.ReadLine();
        Console.Write("Enter Goal Description: ");
        string description = Console.ReadLine();
        Console.Write("Enter Goal Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter Target Count: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter Bonus Points: ");
                int bonus = int.Parse(Console.ReadLine());
                goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    public void ListGoalDetails()
    {

        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }        
    }

    public void SaveGoals(string file)

{
    
    
        Console.WriteLine($"Attempting to save goals to file: {file}");
        using (StreamWriter writer = new StreamWriter(file))
        {
            writer.WriteLine(score); // Save the score first
            foreach (var goal in goals)
            {
                if (goal is SimpleGoal simpleGoal)
                {
                    writer.WriteLine($"Simple|{simpleGoal._shortName}|{simpleGoal._description}|{simpleGoal.Points}|{simpleGoal.IsComplete()}");
                }
                else if (goal is EternalGoal eternalGoal)
                {
                    writer.WriteLine($"Eternal|{eternalGoal._shortName}|{eternalGoal._description}|{eternalGoal.Points}");
                }
                else if (goal is ChecklistGoal checklistGoal)
                {
                    writer.WriteLine($"Checklist|{checklistGoal._shortName}|{checklistGoal._description}|{checklistGoal.Points}|{checklistGoal.IsComplete()}|{checklistGoal._amountCompleted}|{checklistGoal._target}|{checklistGoal.Bonus}");
                }
            }
        }
        Console.WriteLine("Goals successfully saved.");
    
   
}
    public void LoadGoals(string file)
{
    
        Console.WriteLine($"Attempting to load goals from file: {file}");
        if (File.Exists(file))
        {
            goals.Clear();
            using (StreamReader reader = new StreamReader(file))
            {
                string line = reader.ReadLine();
                score = int.Parse(line); // Load the score

                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    if (parts.Length < 4) continue;
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);
                    bool isComplete = parts.Length > 4 && bool.Parse(parts[4]);
                    switch (type)
                    {
                        case "Simple":
                            var simpleGoal = new SimpleGoal(name, description, points);
                            if (isComplete) simpleGoal.RecordEvent(); // Mark as complete if applicable
                            goals.Add(simpleGoal);
                            break;
                        case "Eternal":
                            goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "Checklist":
                            if (parts.Length >= 7)
                            {
                                int amountCompleted = int.Parse(parts[5]);
                                int target = int.Parse(parts[6]);
                                int bonus = int.Parse(parts[7]);
                                var checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                                for (int i = 0; i < amountCompleted; i++)
                                {
                                    checklistGoal.RecordEvent();
                                }
                                goals.Add(checklistGoal);
                            }
                            break;
                        default:
                            Console.WriteLine("Unknown goal type.");
                            break;
                    }
                }
            }
            Console.WriteLine("Goals successfully loaded.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    

}
    public int GetScore ()
    {
        return score; 
    }
    public void RecordEvent()
    {
        Console.WriteLine("Select Goal to Record Event:");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetDetailsString()}");
        }
        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < goals.Count)
        {
            goals[choice].RecordEvent();
            score += goals[choice].Points;
            if (goals[choice].IsComplete())
            {
                score += goals[choice].Bonus;
            }
            Console.WriteLine($"Event recorded. Current score: {score}");
        }
        else
        {
            Console.WriteLine("Invalid choice.");
        }
    }
}
