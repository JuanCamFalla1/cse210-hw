using System;

class Program
{
    static void Main(string[] args)
    {
        
        Square Squareshape = new Square (15, "blue");        
        Rectangle Rectangleshape = new Rectangle ("red",5,5);        
        Circle Circleshape = new Circle ("yellow", 5);
        
        // Console.WriteLine(Squareshape.GetArea ());
        // Console.WriteLine(Squareshape.Getcolor ());

        List <Shape> shapes = new List<Shape> ();

        shapes.Add (Squareshape);
        shapes.Add (Rectangleshape);
        shapes.Add (Circleshape);

        foreach (Shape shape in shapes)
        {
            
            Console.WriteLine (shape.GetArea());
            Console.WriteLine (shape.Getcolor());

            Console.WriteLine ($"the {shape.Getcolor()} shape has an area of:{shape.GetArea()}");

        }
        
        

    }
}