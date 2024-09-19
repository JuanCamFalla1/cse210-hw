using System;

class Program
{
    static void Main(string[] args)
    
    {
        
        // Console.Write("What is the magic number? ");
        // string useranswer = Console.ReadLine();
        // int number = int.Parse (useranswer);

        Console.WriteLine("you have to guess the number between 1 to 100, Good Luck!");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        string response = "yes";

    while (response == "yes")
    {
        Console.Write("What is your guess? ");
        response = Console.ReadLine();
        int guess = int.Parse (response);
        if (guess == number)
        {
            Console.WriteLine("You guessed it!");
            response = "no";
        }
        else if (guess > number)
        {
            Console.WriteLine("lower");
            response = "yes";
        }
        else if (guess < number)
        {
            Console.WriteLine("higher");
            response = "yes";
        }
    }



    }
}   