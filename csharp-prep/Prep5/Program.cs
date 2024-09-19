using System;

class Program
{
    static void Main(string[] args)

    {   
        DisplayWelcome ();
        string UserName = PromptUserName();
        int number1 = PromptUserNumber();
        int Sqrnumber = SquareNumber (number1);
        DisplayResult (UserName, Sqrnumber);


        


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string useranswer = Console.ReadLine();
        int number = int.Parse (useranswer);
        return number;
    }

    static int SquareNumber(int number)
    {
        int sqr = number * number;
        return sqr;
    }
    
    static void DisplayResult(string UserName, int sqr)
    
    {
        Console.WriteLine($"{UserName}, the square of your number is {sqr}");
    }


    }
}