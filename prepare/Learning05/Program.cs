using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student1 = new Assignment("camilo", "mishel");
        Mathassignment Student2 = new Mathassignment ("Juan", "Felipe","7.3", "8-19");
        WrittingAssignment Student3 =new WrittingAssignment ("Mary Waters", "Art Class", "How to create a trouble" );
        Console.WriteLine (student1.GetSummary());
        Console.WriteLine (Student2.GetHomeworkList());
        Console.WriteLine (Student3.GetWritingInformation ());

        

    }
}