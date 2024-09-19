using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade Percentage? ");
        string useranswer = Console.ReadLine();
        int number = int.Parse (useranswer);
        string grade = "";

        if (number >= 90)
        {
            Console.WriteLine("Congratulations you passed ");
            grade = "A";
        }
        else if (number >= 80)
        {
            Console.WriteLine("Congratulations you passed ");
            grade = "B";
        }
        else if (number >= 70)
        {
            Console.WriteLine("Congratulations you passed ");
            grade = "C";
        }
        else if (number >= 60)
        {
            Console.WriteLine("Best of Lucks next time you missed");
            grade = "D";
        }

        else
        {
            Console.WriteLine("Best of Lucks next time you missed");
            grade = "F";
        }
        
        Console.WriteLine($"Your grade is: {grade}.");
    

        
    }
}