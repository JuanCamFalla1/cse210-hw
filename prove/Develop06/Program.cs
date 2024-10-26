using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        string response = "0";

        while (response != "6")
        {
            Console.Clear();
            Console.WriteLine ($"\nYou have {goalManager.score} points.\n");

            Console.WriteLine("Menu Options:\n"
                        + "1. Create A New Goal\n"
                        + "2. List Goals\n"
                        + "3. Save Goals\n"
                        + "4. Load Goals\n"
                        + "5. Record Event\n"
                        + "6. Quit\n");

            Console.Write("\nSelect a Choice from the Menu: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    goalManager.CreateGoal();
                    break;

                case "2":
                    goalManager.ListGoalDetails();
                    break;

                 case "3":
                    Console.Write("Enter filename to save goals: ");
                    string saveFile = Console.ReadLine();
                    goalManager.SaveGoals(saveFile);
                    break;

                case "4":
                    Console.Write("Enter filename to load goals: ");
                    string loadFile = Console.ReadLine();
                    goalManager.LoadGoals(loadFile);
                    break;

                case "5":
                    goalManager.RecordEvent();
                    break;

                case "6":
                    response = "6";
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

