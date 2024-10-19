using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have \nand how you can use it in other aspects of your life.");
        ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        // Counters for activity sessions
        int breathingCount = 0;
        int reflectingCount = 0;
        int listingCount = 0;

        string response = "0";

        while (response != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:\n"
                        + "1. Start Breathing Activity\n"
                        + "2. Start Reflecting Activity\n"
                        + "3. Start Listing Activity\n"
                        + "4. Quit\n");
            Console.WriteLine($"\nYou have completed the Breathing Activity {breathingCount} time(s).");
            Console.WriteLine($"You have completed the Reflecting Activity {reflectingCount} time(s).");
            Console.WriteLine($"You have completed the Listing Activity {listingCount} time(s).");
            Console.Write("\nSelect a Choice from the Menu: ");
            string answer = Console.ReadLine();
            switch (answer)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine(breathing.GetTitle());
                    Console.Write("How long, in seconds, would you like for your session? ");
                    var time = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.Write("Get Ready....");
                    breathing.Run(time);
                    breathingCount++; // Increment the breathing activity counter
                    
                    break;

                case "2":
                    Console.Clear();
                    Console.WriteLine(reflecting.GetTitle());
                    Console.Write("\nHow long, in seconds, would you like for your session? ");
                    var _time = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.Write("Get Ready....");
                    reflecting.Run(_time);
                    reflectingCount++; // Increment the reflecting activity counter
                    
                    break;

                case "3":
                    Console.Clear();
                    Console.WriteLine(listing.GetTitle());
                    Console.Write("\nHow long, in seconds, would you like for your session? ");
                    var _time2 = int.Parse(Console.ReadLine());
                    Console.Clear();
                    Console.Write("Get Ready....");
                    listing.Run(_time2);
                    listingCount++; // Increment the listing activity counter
                    
                    break;

                case "4":
                    response = "4";
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            
        }
    }
}