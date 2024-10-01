using System;

class Program
{
    static void Main(string[] args)
    {
        
        Fraction f1 = new Fraction ();
        Fraction f2 = new Fraction (5);
        Fraction f3 = new Fraction (3,4);
        Fraction f4 = new Fraction (1,3);


        f1.GetFractionString ();
        Console.WriteLine(f1.GetDecimalValue ());
        f2.GetFractionString ();
        Console.WriteLine(f2.GetDecimalValue ());
        f3.GetFractionString ();
        Console.WriteLine(f3.GetDecimalValue ());
        f4.GetFractionString ();
        Console.WriteLine(f4.GetDecimalValue ());
       

    }
}