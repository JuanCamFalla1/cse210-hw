using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();      

        PromptGenerator generator = new PromptGenerator();
        string entryText = "";

        Console.WriteLine("Welcome to the Journal Program!");

        string response = "0";

         while (response != "5")
         {
            if (response != "5")
            {
                Console.WriteLine("Please select one of the following choices:\n"
                            + "1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n");
                Console.Write("What Would you like to do? ");
                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "1":
                    string prompt = generator.GetRandomPrompt();
                    Console.WriteLine($"{prompt}");
                    Console.Write("> ");
                    entryText = Console.ReadLine();
                    journal.AddEntry(new Entry(entryText, prompt));
                    break;

                    case "2":
                        journal.DisplayAll();
                        break;

                    case "3":
                        Console.Write("Enter the filename to load: ");
                        string loadFile = Console.ReadLine();
                        journal.LoadFromFile(loadFile);
                        break;                        

                    case "4":
                        Console.Write("Enter the filename to save: ");
                        string saveFile = Console.ReadLine();
                        journal.SaveToFile(saveFile);
                        break;
                        

                    case "5":
                        response = "5";                    
                        break;       
                        

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }

            
         }

    }
}