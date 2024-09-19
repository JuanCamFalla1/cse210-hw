using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();       
        
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        string response = "yes";
        int number1 = 0;

    while (response == "yes")
        { 
        Console.Write("Enter number: ");
        string useranswer = Console.ReadLine();
        int data = int.Parse (useranswer);

        if  (data != 0) 
        {
        numbers.Add(data);
        number1++;
        }
        else 
        {
            response = "no";
        }
        }

        int suma = numbers.Sum();
        Console.WriteLine($"The sum is: {suma}");
        float average = ((float)suma) / number1;
        Console.WriteLine($"The average is: {average}   ");

         int max_number = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max_number)
            {
                max_number = number;
            }
        }

        Console.WriteLine($"The largest number is: {max_number}");





    }
}